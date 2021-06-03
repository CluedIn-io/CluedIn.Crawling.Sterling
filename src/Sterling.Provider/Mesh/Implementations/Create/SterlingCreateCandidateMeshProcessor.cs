using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core;
using CluedIn.Crawling.Sterling.Core;
using CluedIn.Providers.Mesh;

namespace CluedIn.Provider.Sterling.Mesh.Implementations.Create
{
    public class SterlingCreateCandidateMeshProcessor : SterlingCreateMeshProcessor
    {
        public SterlingCreateCandidateMeshProcessor(ApplicationContext appContext)
            : base(appContext, "https://api.us.int.sterlingcheck.app/v2/candidates", SterlingConstants.Candidate )
        {
        }

    }

    public class SterlingCreateScreeningMeshProcessor : SterlingCreateMeshProcessor
    {
        public SterlingCreateScreeningMeshProcessor(ApplicationContext appContext)
            : base(appContext, "https://api.us.int.sterlingcheck.app/v2/screenings", SterlingConstants.Screening)
        {
        }

    }
}
