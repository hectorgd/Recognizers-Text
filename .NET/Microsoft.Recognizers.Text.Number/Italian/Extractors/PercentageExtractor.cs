﻿using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text.RegularExpressions;

using Microsoft.Recognizers.Definitions.Italian;

namespace Microsoft.Recognizers.Text.Number.Italian
{
    public sealed class PercentageExtractor : BasePercentageExtractor
    {
        public PercentageExtractor() : base(new NumberExtractor()) { }
        
        protected override ImmutableHashSet<Regex> InitRegexes()
        {
            HashSet<string> regexStrs = new HashSet<string>
            {
                NumbersDefinitions.NumberWithSuffixPercentage,
                NumbersDefinitions.NumberWithPrefixPercentage
            };

            return BuildRegexes(regexStrs);
        }
    }
}
