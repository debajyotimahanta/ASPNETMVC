

using System.Collections;
using System.Collections.Generic;

namespace Aon.MyAon.Persistence.Database
{
    public class Subscription
    {
        public int Id { get; set; }
       public List<TaxonomyTerm> SubscriptionTerms { get; set; }
        public virtual  User Subscriber { get; set; }

        
    }

    public enum TaxonomyTermCategoris
    {
        Country,
        BusinessUnit,
        PracticeGroup
    }
}