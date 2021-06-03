using System;
using System.Net;
using System.Threading.Tasks;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Sterling.Core;
using Newtonsoft.Json;
using RestSharp;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using CluedIn.Crawling.Sterling.Core.Models;
using System.Linq;

namespace CluedIn.Crawling.Sterling.Infrastructure
{
    // TODO - This class should act as a client to retrieve the data to be crawled.
    // It should provide the appropriate methods to get the data
    // according to the type of data source (e.g. for AD, GetUsers, GetRoles, etc.)
    // It can receive a IRestClient as a dependency to talk to a RestAPI endpoint.
    // This class should not contain crawling logic (i.e. in which order things are retrieved)
    public class SterlingClient
    {
        private const string BaseUri = "http://sample.com";

        private readonly ILogger<SterlingClient> log;

        private readonly IRestClient client;

        public SterlingClient(ILogger<SterlingClient> log, SterlingCrawlJobData sterlingCrawlJobData, IRestClient client) // TODO: pass on any extra dependencies
        {
            if (sterlingCrawlJobData == null)
            {
                throw new ArgumentNullException(nameof(sterlingCrawlJobData));
            }

            if (client == null)
            {
                throw new ArgumentNullException(nameof(client));
            }

            this.log = log ?? throw new ArgumentNullException(nameof(log));
            this.client = client ?? throw new ArgumentNullException(nameof(client));

            // TODO use info from sterlingCrawlJobData to instantiate the connection
            client.BaseUrl = new Uri(BaseUri);
            client.AddDefaultParameter("api_key", sterlingCrawlJobData.ApiKey, ParameterType.QueryString);
        }

        public IEnumerable<Package> GetPackages()
        {
            var client = new RestClient("https://api.us.int.sterlingcheck.app/v2");
            var request = new RestRequest("packages", Method.GET);
            var results = client.Get<List<Package>>(request);
            return results.Data;
        }

        public IEnumerable<Candidate> GetCandidates(string candidateId)
        {
            var client = new RestClient("https://api.us.int.sterlingcheck.app/v2");
            var request = new RestRequest("candidates", Method.GET);
            var results = client.Get<List<Candidate>>(request);
            return results.Data;
        }

        public IEnumerable<Screening> GetScreenings(string screeningId)
        {
            var client = new RestClient("https://api.us.int.sterlingcheck.app/v2");
            var request = new RestRequest("screenings", Method.GET);
            var results = client.Get<List<Screening>>(request);
            return results.Data;
        }

        public IEnumerable<Screening> GetScreeningReports(string screeningId)
        {
            var client = new RestClient("https://api.us.int.sterlingcheck.app/v2");
            var request = new RestRequest("screenings/" + screeningId + "/reports", Method.GET);
            var results = client.Get<List<Screening>>(request);
            return results.Data;
        }

        public IEnumerable<string> GetBillCodes()
        {
            var client = new RestClient("https://api.us.int.sterlingcheck.app/v2");
            var request = new RestRequest("bill-codes", Method.GET);
            var results = client.Get<BillCode>(request);
            return results.Data.BillCodes;
        }

        public IdentifyVerification GetIdentifyVerification(string identifyVerificationId)
        {
            var client = new RestClient("https://api.us.int.sterlingcheck.app/v2");
            var request = new RestRequest("identity-verification/" + identifyVerificationId, Method.GET);
            var results = client.Get<IdentifyVerification>(request);
            return results.Data;
        }

        public AccountInformation GetAccountInformation()
        {
            var client = new RestClient("https://api.us.int.sterlingcheck.app/v2");
            var request = new RestRequest("account", Method.GET);
            var results = client.Get<List<Account>>(request);

            return new AccountInformation(results.Data.First().AccountId, results.Data.First().AccountName);
        }
    }
}
