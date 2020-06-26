using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Tool.ManagementClass
{
    //Token的管理类
    public class TokenManagement
    {
        [JsonProperty("secret")]
        public string Secret { get; set; }

        [JsonProperty("issuer")]
        public string Issuer { get; set; }

        [JsonProperty("audience")]
        public string Audience { get; set; }

        [JsonProperty("accessExpiration")]
        public int AccessExpiration { get; set; }
    }
}
