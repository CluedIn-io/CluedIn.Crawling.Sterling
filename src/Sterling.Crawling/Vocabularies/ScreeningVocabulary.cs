using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.Sterling.Vocabularies
{
    public class ScreeningVocabulary : SimpleVocabulary
    {
        public ScreeningVocabulary()
        {
            VocabularyName = "Sterling Screeing"; // TODO: Set value
            KeyPrefix = "sterling.Screeing"; // TODO: Set value
            KeySeparator = ".";
            Grouping = "Screeing"; // TODO: Check value

            AddGroup("Screeing Details", group =>
            {
                SysUpdatedOn = group.Add(new VocabularyKey("ActionStatus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible).WithDisplayName("Name"));

            });
        }
        public VocabularyKey SysUpdatedOn { get; internal set; }
    }
}
