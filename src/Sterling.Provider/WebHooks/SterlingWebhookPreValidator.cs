using CluedIn.Core.Webhooks;
using CluedIn.Crawling.Sterling.Core;

namespace CluedIn.Provider.Sterling.WebHooks
{
    public class Name_WebhookPreValidator : BaseWebhookPrevalidator
    {
        public Name_WebhookPreValidator()
            : base(SterlingConstants.ProviderId, SterlingConstants.ProviderName)
        {
        }
    }
}
