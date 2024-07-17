using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
public class data
{
    [JsonProperty("createdDate")]
    public DateTime createdDate { get; set; }

    [JsonProperty("dNSSEC")]
    public string dNSSEC { get; set; }

    [JsonProperty("domainName")]
    public string domainName { get; set; }

    [JsonProperty("domainStatus")]
    public string[] domainStatus { get; set; }

    [JsonProperty("expiryDate")]
    public DateTime expiryDate { get; set; }

    [JsonProperty("registrar")]
    public string registrar { get; set; }

    [JsonProperty("registrarAbuseContactEmail")]
    public string registrarAbuseContactEmail { get; set; }

    [JsonProperty("registrarAbuseContactPhone")]
    public string registrarAbuseContactPhone { get; set; }

    [JsonProperty("registrarIANAID")]
    public string registrarIANAID { get; set; }

    [JsonProperty("registrarURL")]
    public string registrarURL { get; set; }

    [JsonProperty("registrarWHOISServer")]
    public string registrarWHOISServer { get; set; }

    [JsonProperty("registryDomainID")]
    public string registryDomainID { get; set; }

    [JsonProperty("updatedDate")]
    public DateTime updatedDate { get; set; }

}

public class ResponseObj
{
    [JsonProperty("status")]
    public string status { get; set; }

    [JsonProperty("error")]
    public object error { get; set; }

    [JsonProperty("data")]
    public data data { get; set; }

}

}
