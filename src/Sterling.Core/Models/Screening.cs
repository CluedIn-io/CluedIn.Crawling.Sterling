using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Sterling.Core.Models
{
    public class Admin
    {

        [JsonProperty("web")]
        public string Web { get; set; }
    }

    public class Links
    {

        [JsonProperty("admin")]
        public Admin Admin { get; set; }
    }

    public class Callback
    {

        [JsonProperty("uri")]
        public string Uri { get; set; }
    }

    public class ReportItem
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("estimatedCompletionTime")]
        public DateTime EstimatedCompletionTime { get; set; }
    }

    public class Screening
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("packageId")]
        public string PackageId { get; set; }

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("candidateId")]
        public string CandidateId { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("jobPosition")]
        public string JobPosition { get; set; }

        [JsonProperty("links")]
        public Links Links { get; set; }

        [JsonProperty("callback")]
        public Callback Callback { get; set; }

        [JsonProperty("reportItems")]
        public List<ReportItem> ReportItems { get; set; }

        [JsonProperty("submittedAt")]
        public DateTime SubmittedAt { get; set; }

        [JsonProperty("mailReport")]
        public bool MailReport { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime UpdatedAt { get; set; }

        [JsonProperty("estimatedCompletionTime")]
        public DateTime EstimatedCompletionTime { get; set; }
    }


}
