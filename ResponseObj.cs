using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace APIVerve
{
    /// <summary>
    /// Data data
    /// </summary>
    public class Data
    {
        [JsonProperty("domainStatus")]
        public string[] DomainStatus { get; set; }

        [JsonProperty("domainName")]
        public string DomainName { get; set; }

        [JsonProperty("registryDomainID")]
        public string RegistryDomainID { get; set; }

        [JsonProperty("registrarWHOISServer")]
        public string RegistrarWHOISServer { get; set; }

        [JsonProperty("registrarURL")]
        public string RegistrarURL { get; set; }

        [JsonProperty("updatedDate")]
        public string UpdatedDate { get; set; }

        [JsonProperty("createdDate")]
        public string CreatedDate { get; set; }

        [JsonProperty("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonProperty("registrar")]
        public string Registrar { get; set; }

        [JsonProperty("registrarIANAID")]
        public string RegistrarIANAID { get; set; }

        [JsonProperty("registrarAbuseContactEmail")]
        public string RegistrarAbuseContactEmail { get; set; }

        [JsonProperty("registrarAbuseContactPhone")]
        public string RegistrarAbuseContactPhone { get; set; }

        [JsonProperty("dNSSEC")]
        public string DNSSEC { get; set; }

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
