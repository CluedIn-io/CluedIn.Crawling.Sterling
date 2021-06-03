using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Sterling.Vocabularies
{
    public class CandidateVocabulary : SimpleVocabulary
    {
        public CandidateVocabulary()
        {
            VocabularyName = "Sterling Candidate"; // TODO: Set value
            KeyPrefix = "sterling.Candidate"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "Candidate"; // TODO: Check value

            AddGroup("Candidate Details", group =>
            {
                SysUpdatedOn = group.Add(new VocabularyKey("ActionStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));

            });
        }
        public VocabularyKey SysUpdatedOn { get; internal set; }
    }
}
