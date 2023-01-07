using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.DTOs.Facebook
{
    public class FacebookUserAccessTokenValidation
    {
        [JsonPropertyName("data")]
        public FacebookUserAccessTokenValidationData Data { get; set; }
    }

}
