using System.Collections.Generic;
using An.MyAon.Common;

namespace Aon.MyAon.Persistence.Database
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<Subscription> Subscription { get; set; }
        public Language Lanuage { get; set; }

        public TaxonomyTerm Country { get; set; }
        public TaxonomyTerm BusinessUnit { get; set; }
        public TaxonomyTerm MarketDevision { get; set; }
    }
}