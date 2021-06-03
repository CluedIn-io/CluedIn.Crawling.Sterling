using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core;
using CluedIn.Crawling.Sterling.Core;
using CluedIn.Providers.Mesh;

namespace CluedIn.Provider.Sterling.Mesh.Implementations.Create
{
    public class SterlingUpdateCandidateMeshProcessor : SterlingUpdateMeshProcessor
    {
        public SterlingUpdateCandidateMeshProcessor(ApplicationContext appContext)
            : base(appContext, "https://api.us.int.sterlingcheck.app/v2/candidates", SterlingConstants.Candidate )
        {
        }

    }
}
