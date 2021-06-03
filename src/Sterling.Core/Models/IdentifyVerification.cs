using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Sterling.Core.Models
{
    public class DetectedCandidateInfo
    {

        [JsonProperty("dob")]
        public string Dob { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("givenNames")]
        public string GivenNames { get; set; }

        [JsonProperty("familyName")]
        public string FamilyName { get; set; }

        [JsonProperty("documentType")]
        public string DocumentType { get; set; }
    }

    public class IdentifyVerification
    {

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("candidateId")]
        public string CandidateId { get; set; }

        [JsonProperty("isValid")]
        public bool IsValid { get; set; }

        [JsonProperty("messages")]
        public List<string> Messages { get; set; }

        [JsonProperty("detectedCandidateInfo")]
        public DetectedCandidateInfo DetectedCandidateInfo { get; set; }
    }


}
