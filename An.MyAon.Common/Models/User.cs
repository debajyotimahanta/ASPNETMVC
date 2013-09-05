using System.Collections.Generic;
using An.MyAon.Common.DependentClass;

namespace An.MyAon.Common.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public Language Languge { get; set; }

        public List<Subscription> Subscription { get; set; }

        public TaxonomyTerm MarketDevision { get; set; }

        public TaxonomyTerm Country { get; set; }
    }
}