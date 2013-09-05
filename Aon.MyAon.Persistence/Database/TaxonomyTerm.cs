using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using An.MyAon.Common;

namespace Aon.MyAon.Persistence.Database
{
    public class TaxonomyTerm
    {
        [Key]
        public string Guid { get; set; }
        public TaxonomyTermCategoris TermType { get; set; }
        public Dictionary<Language, string> Term;


    }
}