using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.Sterling.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.Sterling.Unit.Test.SterlingProvider
{
    public abstract class SterlingProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<ISterlingClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected SterlingProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<ISterlingClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new Sterling.SterlingProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
