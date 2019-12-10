using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRTCCSharpDemo.Common
{
    class ApiServer
    {

        //public static string baseUrl = "https://api-sc.wakkaa.com/1/";
        public static string baseUrl = "https://sandbox-api-sc.wakkaa.com/1/";

        //发布直播
        public static string PUBLISH_LIVE = baseUrl + "dashboard/live/save";
        //登录
        public static string SIGNIN = baseUrl + "dashboard/admin/signin";
        //获取推流地址
        public static string PUSH_URL = baseUrl + "dashboard/live/renew_push_url";
        //开始直播
        public static string START = baseUrl + "dashboard/live/start";
        //暂停直播
        public static string SUSPEND = baseUrl + "dashboard/live/suspend";
        //获取连麦直播签名
        public static string RTC_SIGNATURE = baseUrl + "dashboard/live/rtc_signature";
    }
}
