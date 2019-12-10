using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TRTCCSharpDemo
{
    class Login
    {
        public class Shop
        {
            public string companyName { get; set; }
            public string createdAt { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string ownerMobile { get; set; }
            public string ownerName { get; set; }
            public string state { get; set; }
            public string validThru { get; set; }
        }

        public class Admin
        {
            public string createdAt { get; set; }
            public string id { get; set; }
            public string name { get; set; }
            public string role { get; set; }
            public string shopId { get; set; }
            public string username { get; set; }
        }

        public class AccessToken
        {
            public string expiryTime { get; set; }
            public string token { get; set; }
        }

        public class Result
        {
            public Shop shop { get; set; }
            public Admin admin { get; set; }
            public AccessToken accessToken { get; set; }
        }

        public class RootObject
        {
            public string errcode { get; set; }
            public Result result { get; set; }
        }

        public RootObject rootObject { get; set; }
    }
}
