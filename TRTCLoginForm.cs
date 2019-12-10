using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using ManageLiteAV;
using System.Drawing.Drawing2D;
using TRTCCSharpDemo.Common;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net;
using Newtonsoft.Json;

/// <summary>
/// Module： TRTCLoginForm
/// 
/// Function： 该界面可以让用户输入一个【房间号】和一个【用户名】
/// 
/// Notice：
/// （1）房间号为数字类型，用户名为字符串类型
///
/// （2）在真实的使用场景中，房间号大多不是用户手动输入的，而是系统分配的，
///      比如视频会议中的会议号是会控系统提前预定好的，客服系统中的房间号也是根据客服员工的工号决定的。
/// </summary>

namespace TRTCCSharpDemo
{
    public partial class TRTCLoginForm : Form
    {
        public TRTCLoginForm()
        {
            InitializeComponent();

            this.Disposed += new EventHandler(OnDisposed);
        }

        private void OnDisposed(object sender, EventArgs e)
        {
            //清理资源
        }

        private void ShowMessage(string text)
        {
            MessageForm msgBox = new MessageForm();
            msgBox.setText(text);
            msgBox.setCancelBtn(false);
            msgBox.ShowDialog();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.tbPwd.Focus();
            this.tbAccount.Text = DataManager.GetInstance().account;
            this.tbPwd.Text = DataManager.GetInstance().password;
            this.tbLiveId.Text = DataManager.GetInstance().liveId.ToString();

            if (IsTestEnv())
            {
                //this.formalEnvRadioBtn.Visible = true;
                //this.testEnvRadioBtn.Visible = true;
                //this.lifeEnvRadioBtn.Visible = true;
                //this.audioRadioBtn.Visible = true;
                //this.videoRadioBtn.Visible = true;

                //if (DataManager.GetInstance().testEnv == 0)
                //    this.formalEnvRadioBtn.Checked = true;
                //else if (DataManager.GetInstance().testEnv == 1)
                //    this.testEnvRadioBtn.Checked = true;
                //else if (DataManager.GetInstance().testEnv == 2)
                //    this.lifeEnvRadioBtn.Checked = true;
                //if (DataManager.GetInstance().pureAudioStyle)
                //    this.audioRadioBtn.Checked = true;
                //else
                //    this.videoRadioBtn.Checked = true;
            }
            else
            {
                //this.formalEnvRadioBtn.Visible = false;
                //this.testEnvRadioBtn.Visible = false;
                //this.lifeEnvRadioBtn.Visible = false;
                //this.audioRadioBtn.Visible = false;
                //this.videoRadioBtn.Visible = false;

                DataManager.GetInstance().testEnv = 0;
                DataManager.GetInstance().pureAudioStyle = false;
            }
        }

        #region Form Move

        private bool mIsMouseDown = false;
        private Point mFormLocation;     // Form的location
        private Point mMouseOffset;      // 鼠标的按下位置

        private void OnFormMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mIsMouseDown = true;
                mFormLocation = this.Location;
                mMouseOffset = Control.MousePosition;
            }
        }

        private void OnFormMouseUp(object sender, MouseEventArgs e)
        {
            mIsMouseDown = false;
        }

        private void OnFormMouseMove(object sender, MouseEventArgs e)
        {
            if (mIsMouseDown)
            {
                Point pt = Control.MousePosition;
                int x = mMouseOffset.X - pt.X;
                int y = mMouseOffset.Y - pt.Y;

                this.Location = new Point(mFormLocation.X - x, mFormLocation.Y - y);
            }
        }

        #endregion

        private void OnJoinRoomBtnClick(object sender, EventArgs e)
        {
            if (GenerateTestUserSig.SDKAPPID == 0)
            {
                ShowMessage("Error: 请先在 GenerateTestUserSig 填写 sdkappid 信息");
                return;
            }

            //SetTestEnv();
            //SetPureAudioStyle();

            string account = this.tbAccount.Text;
            string pwd = this.tbPwd.Text;
            string liveId = this.tbLiveId.Text;
            if (string.IsNullOrEmpty(account) || string.IsNullOrEmpty(pwd) || string.IsNullOrEmpty(liveId))
            {
                ShowMessage("账号、密码或直播ID不能为空！");
                return;
            }

            if (!uint.TryParse(liveId, out _))
            {
                ShowMessage(String.Format("目前支持的最大房间号为{0}", uint.MaxValue));
                return;
            }

            NameValueCollection nameValue = new NameValueCollection()
            {
                { "username", account },
                { "password", pwd }
            };
            string res = HttpUtil.WebPost(ApiServer.SIGNIN, nameValue);
            JObject jo = JObject.Parse(res);
            int errcode = int.Parse(jo["errcode"].ToString());
            if (errcode != 0)
            {
                ShowMessage("登录失败，" + jo["errmsg"].ToString());
                return;
            }

            DataManager.GetInstance().account = account;
            DataManager.GetInstance().password = pwd;
            DataManager.GetInstance().session = jo["result"]["accessToken"]["token"].ToString();

            //Live live = new Live
            //{
            //    type = 6,
            //    title = "this is live title!",
            //    intro = "this is live intro!",
            //    price = 1,
            //    password = "123",
            //    startAt = Util.GetTimeStamp().ToString(),
            //    endAt = "",
            //    state = 2
            //};

            //NameValueCollection nameValueCollection = new NameValueCollection() {
            //    {"live", JsonConvert.SerializeObject(live) }
            //};
            //string ret = HttpUtil.WebPost(ApiServer.PUBLISH_LIVE, nameValueCollection);
            //ShowMessage("ret:" + ret);



            if (uint.TryParse(liveId, out uint LiveId))
            {
                DataManager.GetInstance().liveId = LiveId;
            }

            // 从本地计算获取 userId 对应的 userSig
            // 注意！本地计算是适合在本地环境下调试使用，正确的做法是将 UserSig 的计算代码和加密密钥放在您的业务服务器上，
            // 然后由 App 按需向您的服务器获取实时算出的 UserSig。
            // 由于破解服务器的成本要高于破解客户端 App，所以服务器计算的方案能够更好地保护您的加密密钥。
            string userSig = GenerateTestUserSig.GetInstance().GenTestUserSig(account);
            if (string.IsNullOrEmpty(userSig))
            {
                ShowMessage("userSig 获取失败，请检查是否填写账号信息！");
                return;
            }

            this.Hide();
            kuaiji mainForm  = new kuaiji(this);
            mainForm.Show();
            mainForm.EnterRoom();
        }

        /// <summary>
        /// 设置连接环境，只适用于本地调试测试使用
        /// </summary>
        private void SetTestEnv()
        {
            //if (this.formalEnvRadioBtn.Checked)
            //    DataManager.GetInstance().testEnv = 0;
            //else if (this.testEnvRadioBtn.Checked)
            //    DataManager.GetInstance().testEnv = 1;
            //else if (this.lifeEnvRadioBtn.Checked)
            //    DataManager.GetInstance().testEnv = 2;
        }

        /// <summary>
        /// 设置是否使用纯音频环境进房
        /// </summary>
        private void SetPureAudioStyle()
        {
            //if (this.audioRadioBtn.Checked)
            //    DataManager.GetInstance().pureAudioStyle = true;
            //else if (this.videoRadioBtn.Checked)
            //    DataManager.GetInstance().pureAudioStyle = false;
        }

        private void OnExitPicBoxClick(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void OnRoomTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                if (e.KeyChar < 48 || e.KeyChar > 57)
                    e.Handled = true;
            }
        }

        /// <summary>
        /// 主要用于本地调试环境时，存在该文件时启动测试功能
        /// </summary>
        private bool IsTestEnv()
        {
            string path = Environment.CurrentDirectory + "\\ShowTestEnv.txt";
            return File.Exists(path);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void roomTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Type(this.panel1, 30, 0.1);
        }

        private void Type(Control sender, int p_1, double p_2) {
            GraphicsPath oPath = new GraphicsPath();
            oPath.AddClosedCurve(new Point[] { 
                    new Point(0, sender.Height / p_1),
                    new Point(sender.Width / p_1, 0),
                    new Point(sender.Width - sender.Width / p_1, 0),
                    new Point(sender.Width, sender.Height / p_1),
                    new Point(sender.Width, sender.Height - sender.Height / p_1),
                    new Point(sender.Width - sender.Width / p_1, sender.Height),
                    new Point(sender.Width / p_1, sender.Height),
                    new Point(0, sender.Height - sender.Height / p_1)},
                (float) p_2);
            sender.Region = new Region(oPath);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tbLiveId_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void userTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
