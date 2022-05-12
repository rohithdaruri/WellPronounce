﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WellPronounce.Web.ApiModels
{
    public class StandardTextRequestModel
    {
        [JsonPropertyName("legalFirstName")]
        public string LegalFirstName { get; set; }
        [JsonPropertyName("legalLastName")]
        public string LegalLastName { get; set; }
        [JsonPropertyName("preferedName")]
        public string PreferedName { get; set; }
        [JsonPropertyName("language")]
        public string Language { get; set; }
        [JsonPropertyName("processType")]
        public string ProcessType { get; set; }
    }
}
