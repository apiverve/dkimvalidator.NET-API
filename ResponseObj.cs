using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class issuesfound
{
    [JsonProperty("code")]
    public string code { get; set; }

    [JsonProperty("message")]
    public string message { get; set; }

    [JsonProperty("type")]
    public string type { get; set; }

}

public class data
{
    [JsonProperty("dkim_host")]
    public string dkimhost { get; set; }

    [JsonProperty("dkim_record")]
    public string dkimrecord { get; set; }

    [JsonProperty("dkim_records_count")]
    public int dkimrecordscount { get; set; }

    [JsonProperty("has_dkim_record")]
    public bool hasdkimrecord { get; set; }

    [JsonProperty("host")]
    public string host { get; set; }

    [JsonProperty("issues_found")]
    public issuesfound[] issuesfound { get; set; }

    [JsonProperty("key_type")]
    public string keytype { get; set; }

    [JsonProperty("selector")]
    public string selector { get; set; }

    [JsonProperty("valid")]
    public bool valid { get; set; }

    [JsonProperty("version")]
    public string version { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

    [JsonProperty("code")]
    public int code { get; set; }

}

}
