using System;
using System.Collections.Generic;
using System.Text;

namespace BlogProjem.Business.StringInfos
{
    public class JwtInfo
    {
        public const string Issuer = "http://localhost:52395";
        public const string Audience = "http://localhost:5000";
        public const string SecurityKey = "yavuzyavuzyavuz1";
        public const double Expires = 40;
    }
}
