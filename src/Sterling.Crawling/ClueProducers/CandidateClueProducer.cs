using System;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.Sterling.Core;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Sterling.Core.Models;
using CluedIn.Crawling.Sterling;
using CluedIn.Core.Utilities;
using CluedIn.Crawling.Sterling.Infrastructure;
using Microsoft.Extensions.Logging;
using CluedIn.Crawling.Helpers;
using System.Linq;


namespace CluedIn.Crawling.Sterling.ClueProducers
{
    public class CandidateClueProducer : BaseClueProducer<Candidate>
    {
        private readonly IClueFactory _factory;
        private readonly ILogger<SterlingClient> _log;

        public CandidateClueProducer([NotNull] IClueFactory factory, ILogger<SterlingClient> _log)

        {
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
            this._log = _log;
        }

        protected override Clue MakeClueImpl(Candidate input, Guid id)
        {
            var clue = _factory.Create(SterlingConstants.Candidate, input.Id, id);
            var data = clue.Data.EntityData;

            //var code = new EntityCode(SterlingConstants.Candidate, "ServiceNow", input.SysId);
            //data.Codes.Add(code);

            // var vocab = new IncidentVocabulary();

            if (!string.IsNullOrEmpty(input.FamilyName) && !string.IsNullOrEmpty(input.GivenName))
            {
                data.Name = $"{input.GivenName} {input.FamilyName}";
            }

            //data.Properties[vocab.ActionStatus] = input.ActionStatus.PrintIfAvailable();

            if (!data.OutgoingEdges.Any())
            {
                _factory.CreateEntityRootReference(clue, EntityEdgeType.PartOf);
            }

            return clue;
        }
    }
}

