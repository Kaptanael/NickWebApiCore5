using System;

namespace NickWebApi.Options
{
    public class JwtSettings
    {
        public string Secret { get; set; }
        public string TokenLifeTime { get; set; }
    }
}
