using System.Collections.Generic;
using CluedIn.Crawling.Sterling.Core;

namespace CluedIn.Crawling.Sterling.Integration.Test
{
  public static class SterlingConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { SterlingConstants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
