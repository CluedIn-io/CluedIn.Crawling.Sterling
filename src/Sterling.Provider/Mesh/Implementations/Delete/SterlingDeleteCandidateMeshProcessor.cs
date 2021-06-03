using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core;
using CluedIn.Crawling.Sterling.Core;
using CluedIn.Providers.Mesh;

namespace CluedIn.Provider.Sterling.Mesh.Implementations.Create
{
    public class SterlingDeleteCandidateMeshProcessor : SterlingDeleteMeshProcessor
    {
        public SterlingDeleteCandidateMeshProcessor(ApplicationContext appContext)
            : base(appContext, "https://api.us.int.sterlingcheck.app/v2/candidates", SterlingConstants.Candidate )
        {
        }

    }
}
