using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Issuesfound data
    /// </summary>
    public class Issuesfound
    {
        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

    }
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("dkim_host")]
        public string Dkimhost { get; set; }

        [JsonProperty("dkim_record")]
        public string Dkimrecord { get; set; }

        [JsonProperty("dkim_records_count")]
        public int Dkimrecordscount { get; set; }

        [JsonProperty("has_dkim_record")]
        public bool Hasdkimrecord { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("issues_found")]
        public Issuesfound[] Issuesfound { get; set; }

        [JsonProperty("key_type")]
        public string Keytype { get; set; }

        [JsonProperty("selector")]
        public string Selector { get; set; }

        [JsonProperty("valid")]
        public bool Valid { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

    }
    /// <summary>
    /// API Response object
    /// </summary>
    public class ResponseObj
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("data")]
        public Data Data { get; set; }

    }
}
