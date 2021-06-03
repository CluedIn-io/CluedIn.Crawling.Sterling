using CluedIn.Core;
using CluedIn.Core.Messages.Processing;
using System;
using System.Collections.Generic;
using CluedIn.Core.Data;
using CluedIn.Core.Mesh;
using CluedIn.Core.Messages.WebApp;
using CluedIn.Crawling.Sterling.Core;
using System.Linq;
using RestSharp;

namespace CluedIn.Providers.Mesh
{
    public class SterlingCreateMeshProcessor : BaseMeshProcessor
    {
        public EntityType[] EntityType { get; }
        public string EditUrl { get; }

        protected SterlingCreateMeshProcessor(ApplicationContext appContext, string editUrl, params EntityType[] entityType)
            : base(appContext)
        {
            EntityType = entityType;
            EditUrl = editUrl;
        }

        public override bool Accept(MeshDataCommand command, MeshQuery query, IEntity entity)
        {
            return command.ProviderId == this.GetProviderId() && query.Action == ActionType.CREATE && EntityType.Contains(entity.EntityType);
        }

        public override void DoProcess(CluedIn.Core.ExecutionContext context, MeshDataCommand command, IDictionary<string, object> jobData, MeshQuery query)
        {
            return;
        }

        public override List<RawQuery> GetRawQueries(IDictionary<string, object> config, IEntity entity, Core.Mesh.Properties properties)
        {
           
            var sterlingCrawlJobData = new SterlingCrawlJobData(config);

            return new List<Core.Messages.WebApp.RawQuery>()
            {
                new Core.Messages.WebApp.RawQuery()
                {
                    Query = string.Format("curl --location --request POST '{0}' --header 'Content-Type: application/json' --header 'Authorization: Bearer {1}' --data-raw '{2}'", "https://api.us.int.sterlingcheck.app/v2/" + this.EditUrl, sterlingCrawlJobData.ApiKey, JsonUtility.Serialize(properties)),
                    Source = "cUrl"
                }
            };
        }

        public override Guid GetProviderId()
        {
            return SterlingConstants.ProviderId;
        }

        public override string GetVocabularyProviderKey()
        {
            return "sterling";
        }

        public override string GetLookupId(IEntity entity)
        {
            var code = entity.Codes.ToList().FirstOrDefault(d => d.Origin.Code == "Sterling");
            long id;
            if (!long.TryParse(code.Value, out id))
            {
                //It does not match the id I need.
            }

            return code.Value;
        }

        public override List<QueryResponse> RunQueries(IDictionary<string, object> config, string id, Core.Mesh.Properties properties)
        {
            var sterlingCrawlJobData = new SterlingCrawlJobData(config);
            var client = new RestClient("https://api.us.int.sterlingcheck.app/v2");
            var request = new RestRequest(EditUrl, Method.POST);
            request.AddHeader("Authorization", $"Bearer { sterlingCrawlJobData.ApiKey }" );
            request.AddJsonBody(properties);

            var result = client.ExecuteTaskAsync(request).Result;

            return new List<QueryResponse>() { new QueryResponse() { Content = result.Content, StatusCode = result.StatusCode } };
        }

        public override List<QueryResponse> Validate(ExecutionContext context, MeshDataCommand command, IDictionary<string, object> config, string id, MeshQuery query)
        {
            return new List<QueryResponse>();
        }
    }
}
