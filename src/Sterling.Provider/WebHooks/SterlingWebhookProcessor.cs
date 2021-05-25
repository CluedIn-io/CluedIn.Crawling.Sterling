using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;

using CluedIn.Core;
using CluedIn.Core.Agent.Jobs;
using CluedIn.Core.Configuration;
using CluedIn.Core.Data;
using CluedIn.Core.DataStore;
using CluedIn.Core.Messages.Processing;
using CluedIn.Core.Providers;
using CluedIn.Core.Webhooks;
using CluedIn.Crawling;
using CluedIn.Crawling.Sterling.Core;
using Microsoft.Extensions.Logging;
using CluedIn.Agent;

namespace CluedIn.Provider.Sterling.WebHooks
{
    public class SterlingWebhookProcessor : BaseWebhookProcessor
    {
        public SterlingWebhookProcessor(ApplicationContext appContext)
            : base(appContext)
        {
        }

        public override bool Accept(IWebhookDefinition webhookDefinition)
        {
            return webhookDefinition.ProviderId == SterlingConstants.ProviderId || base.Accept(webhookDefinition);
        }

        public override IEnumerable<Clue> DoProcess(ExecutionContext context, WebhookDataCommand command)
        {
            try
            {
                if (ConfigurationManager.AppSettings.GetFlag("Feature.Webhooks.Log.Posts", false))
                    context.Log.LogDebug(command.HttpPostData);

                var configurationDataStore = context.ApplicationContext.Container.Resolve<IConfigurationRepository>();
                if (command.WebhookDefinition.ProviderDefinitionId != null)
                {
                    var providerDefinition = context.Organization.Providers.GetProviderDefinition(context, command.WebhookDefinition.ProviderDefinitionId.Value);
                    var jobDataCheck       = context.ApplicationContext.Container.ResolveAll<IProvider>().FirstOrDefault(providerInstance => providerDefinition != null && providerInstance.Id == providerDefinition.ProviderId);
                    var configStoreData    = configurationDataStore.GetConfigurationById(context, command.WebhookDefinition.ProviderDefinitionId.Value);

                    // If you have stopped the provider then don't process the webhooks
                    if (providerDefinition?.WebHooks != null)
                        if (providerDefinition.WebHooks == false || providerDefinition.IsEnabled == false)
                            return new List<Clue>();

                    if (jobDataCheck != null)
                    {
                        var crawlJobData = new SterlingCrawlJobData();

                        var clues = new List<Clue>();

                        IAgentJobProcessorArguments jobArgs = new QueuedJob(new AgentJob(Guid.NewGuid(), AgentJobPriority.Normal, "CluedIn" + SterlingConstants.ProviderName, ProcessingRestriction.Any, null, null))
                        {
                            TaskScheduler = TaskScheduler.Default,
                        };

                        var processorState = new AgentJobProcessorState<SterlingCrawlJobData>(jobArgs, AppContext)
                        {
                            JobData = crawlJobData,
                            Status = new AgentJobStatus {Statistics = new AgentJobStatusStatistics()}
                        };

                        throw new NotImplementedException($"TODO: Implement this to populate '{clues.GetType()}' with '{processorState}'");
                    }
                }
            }
            catch (Exception exception)
            {
                using(context.Log.BeginScope(new { command.HttpHeaders, command.HttpQueryString, command.HttpPostData, command.WebhookDefinitionId }))
                {
                    context.Log.LogError(exception, "Could not process web hook message");
                }
            }

            return new List<Clue>();
        }
    }
}
