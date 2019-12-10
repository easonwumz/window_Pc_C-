using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace TRTCCSharpDemo.Common
{
    class HttpUtil
    {
        private static string mUserAgent = null;
        private static HttpWebRequest mRequest = null;

        public HttpUtil(string userAgent)
        {
            mUserAgent = userAgent;
        }

        ~HttpUtil()
        {
            Close();
        }

        public void Close()
        {
            if (null != mRequest)
            {
                mRequest.Abort();
                mRequest = null;
            }
        }

        public static string Get(string url, int timeout)
        {
            if (string.IsNullOrEmpty(url))
            {
                return "";
            }

            mRequest = WebRequest.Create(url) as HttpWebRequest;
            mRequest.Method = "GET";
            mRequest.UserAgent = mUserAgent;
            mRequest.Timeout = timeout;

            HttpWebResponse response = mRequest.GetResponse() as HttpWebResponse;
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string respData = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            return respData;
        }

        public static string Post(string url, byte[] body, int timeout)
        {
            if (string.IsNullOrEmpty(url))
            {
                return "";
            }

            mRequest = WebRequest.Create(url) as HttpWebRequest;
            mRequest.Method = "POST";
            mRequest.UserAgent = mUserAgent;
            mRequest.Timeout = timeout;

            if (null != body)
            {
                mRequest.ContentLength = body.Length;
                mRequest.ContentType = "application/json; charset=utf-8";

                Stream requestStream = mRequest.GetRequestStream();
                if (null != requestStream)
                {
                    requestStream.Write(body, 0, body.Length);
                    requestStream.Close();
                }
            }

            HttpWebResponse response = mRequest.GetResponse() as HttpWebResponse;
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string respData = reader.ReadToEnd();

            reader.Close();
            dataStream.Close();
            response.Close();

            return respData;
        }

        public static string HttpGet(string Url, string postDataStr)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url + (postDataStr == "" ? "" : "?") + postDataStr);
            request.Method = "GET";
            request.ContentType = "application/json; charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();
            return retString;
        }

        public static string HttpPost(string url, string postDataStr)
        {
            string strReturn;
            //在转换字节时指定编码格式
            byte[] byteData = Encoding.UTF8.GetBytes(postDataStr);

            //配置Http协议头
            HttpWebRequest resquest = (HttpWebRequest)WebRequest.Create(url);

            WebHeaderCollection headerCollection = new WebHeaderCollection
            {
                { "x-api-version", "2.5" },
                //{ "x-mdi-id", "100897" },
                { "x-locale", "zh_CN" },
                 { "x-usr-sess", DataManager.GetInstance().session }
            };
            //headerCollection.Add("User-Agent", "android");
            //headerCollection.Add("x-tr-sess", DataManager.GetInstance().session);

            resquest.Headers = headerCollection;
            resquest.Method = "POST";
            //resquest.ContentType = "application/json; charset=UTF-8";
            resquest.ContentType = "application/x-www-form-urlencoded";
            resquest.UserAgent = "android";
            resquest.ContentLength = byteData.Length;

            //发送数据
            using (Stream resquestStream = resquest.GetRequestStream())
            {
                resquestStream.Write(byteData, 0, byteData.Length);
            }

            //接受并解析信息
            using (WebResponse response = resquest.GetResponse())
            {
                //解决乱码：utf-8 + streamreader.readToEnd
                StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                strReturn = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
            }

            return strReturn;
        }

        public static string WebPost(string url, NameValueCollection nameValueCollection)
        {
            if (url is null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            WebClient webClient = new WebClient();
            WebHeaderCollection headerCollection = new WebHeaderCollection
            {
                { "x-api-version", "2.5" },
                //{ "x-mdi-id", "100897" },
                { "x-locale", "zh_CN" },
                 { "x-accesstoken", DataManager.GetInstance().session }
            };
            //x-usr-sess
            //x-accesstoken
            //resquest.ContentType = "application/json; charset=UTF-8",
            //resquest.ContentType = "application/x-www-form-urlencoded"

            webClient.Headers = headerCollection;
            byte[] info = webClient.UploadValues(url, "POST", nameValueCollection);
            return Encoding.UTF8.GetString(info);
        }

        public static void AsyncWebPost(string url, NameValueCollection nameValueCollection)
        {
            if (url is null)
            {
                throw new ArgumentNullException(nameof(url));
            }

            WebClient webClient = new WebClient();
            WebHeaderCollection headerCollection = new WebHeaderCollection
            {
                { "x-api-version", "2.5" },
                //{ "x-mdi-id", "100897" },
                { "x-locale", "zh_CN" },
                 { "x-accesstoken", DataManager.GetInstance().session }
            };
            //x-usr-sess
            //x-accesstoken
            //resquest.ContentType = "application/json; charset=UTF-8",
            //resquest.ContentType = "application/x-www-form-urlencoded"

            webClient.Headers = headerCollection;
            Uri uri = new Uri(url);
            webClient.UploadValuesAsync(uri, nameValueCollection);
        }
    }
}
