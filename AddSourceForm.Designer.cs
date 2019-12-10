namespace TRTCCSharpDemo
{
    partial class AddSourceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.speakerDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.speakerDeviceLabel = new System.Windows.Forms.Label();
            this.micDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.micDeviceLabel = new System.Windows.Forms.Label();
            this.cameraDeviceComboBox = new System.Windows.Forms.ComboBox();
            this.cameraDeviceLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.speakerDeviceComboBox);
            this.panel1.Controls.Add(this.speakerDeviceLabel);
            this.panel1.Controls.Add(this.micDeviceComboBox);
            this.panel1.Controls.Add(this.micDeviceLabel);
            this.panel1.Controls.Add(this.cameraDeviceComboBox);
            this.panel1.Controls.Add(this.cameraDeviceLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(24, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(402, 262);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "选择画面源";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TRTCCSharpDemo.Properties.Resources.close_normal;
            this.pictureBox1.Location = new System.Drawing.Point(362, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(148, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "选择画面源";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speakerDeviceComboBox
            // 
            this.speakerDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speakerDeviceComboBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.speakerDeviceComboBox.FormattingEnabled = true;
            this.speakerDeviceComboBox.Location = new System.Drawing.Point(105, 169);
            this.speakerDeviceComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.speakerDeviceComboBox.Name = "speakerDeviceComboBox";
            this.speakerDeviceComboBox.Size = new System.Drawing.Size(270, 28);
            this.speakerDeviceComboBox.TabIndex = 29;
            // 
            // speakerDeviceLabel
            // 
            this.speakerDeviceLabel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.speakerDeviceLabel.Location = new System.Drawing.Point(19, 168);
            this.speakerDeviceLabel.Name = "speakerDeviceLabel";
            this.speakerDeviceLabel.Size = new System.Drawing.Size(80, 27);
            this.speakerDeviceLabel.TabIndex = 28;
            this.speakerDeviceLabel.Text = "音频输出:";
            this.speakerDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // micDeviceComboBox
            // 
            this.micDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.micDeviceComboBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.micDeviceComboBox.FormattingEnabled = true;
            this.micDeviceComboBox.Location = new System.Drawing.Point(105, 126);
            this.micDeviceComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.micDeviceComboBox.Name = "micDeviceComboBox";
            this.micDeviceComboBox.Size = new System.Drawing.Size(270, 28);
            this.micDeviceComboBox.TabIndex = 27;
            // 
            // micDeviceLabel
            // 
            this.micDeviceLabel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.micDeviceLabel.Location = new System.Drawing.Point(18, 125);
            this.micDeviceLabel.Name = "micDeviceLabel";
            this.micDeviceLabel.Size = new System.Drawing.Size(79, 27);
            this.micDeviceLabel.TabIndex = 26;
            this.micDeviceLabel.Text = "音频输入:";
            this.micDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cameraDeviceComboBox
            // 
            this.cameraDeviceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cameraDeviceComboBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cameraDeviceComboBox.FormattingEnabled = true;
            this.cameraDeviceComboBox.Location = new System.Drawing.Point(105, 78);
            this.cameraDeviceComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cameraDeviceComboBox.Name = "cameraDeviceComboBox";
            this.cameraDeviceComboBox.Size = new System.Drawing.Size(270, 28);
            this.cameraDeviceComboBox.TabIndex = 25;
            // 
            // cameraDeviceLabel
            // 
            this.cameraDeviceLabel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.cameraDeviceLabel.Location = new System.Drawing.Point(18, 77);
            this.cameraDeviceLabel.Name = "cameraDeviceLabel";
            this.cameraDeviceLabel.Size = new System.Drawing.Size(81, 27);
            this.cameraDeviceLabel.TabIndex = 24;
            this.cameraDeviceLabel.Text = "视频输入:";
            this.cameraDeviceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cameraDeviceLabel.Click += new System.EventHandler(this.cameraDeviceLabel_Click);
            // 
            // AddSourceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(81)))), ((int)(((byte)(108)))));
            this.ClientSize = new System.Drawing.Size(450, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(450, 320);
            this.Name = "AddSourceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AddSourceForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox speakerDeviceComboBox;
        private System.Windows.Forms.Label speakerDeviceLabel;
        private System.Windows.Forms.ComboBox micDeviceComboBox;
        private System.Windows.Forms.Label micDeviceLabel;
        private System.Windows.Forms.ComboBox cameraDeviceComboBox;
        private System.Windows.Forms.Label cameraDeviceLabel;
    }
}