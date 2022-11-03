using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Models.EfModels.Base;
using ReFilter.Attributes;

namespace Core.Models.EfModels.Codebooks.Base
{
    public abstract class CodebookBase : DatabaseEntityTranslated<int>
    {
        [ReFilterProperty(UsedForSearchQuery = true)]
        [Column(Order = 1)]
        [Required, StringLength(40)]
        public string Code { get; set; }
    }
}
