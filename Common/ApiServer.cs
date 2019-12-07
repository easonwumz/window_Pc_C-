using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRTCCSharpDemo.Common
{
    class ApiServer
    {
        public static string baseUrl = "https://api-sc.wakkaa.com/1/";

        public static string baseUrlDebug = "https://sandbox-api-sc.wakkaa.com/1/";

        //开始直播
        public static string START = "dashboard/live/start";

        //暂停直播
        public static string SUSPEND = "dashboard/live/suspend";
    }
}
