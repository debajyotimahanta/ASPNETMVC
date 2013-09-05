using System.Collections.Generic;

namespace An.MyAon.Common.DependentClass
{
    public class TaxonomyTerm
    {
        public int Guid { get; set; }
        public Dictionary<Language, string> Label { get; set; }
    }
}