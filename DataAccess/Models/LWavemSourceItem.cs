using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.DataAccess.Models
{
    [Table("LWavemSourceItem")]
    public class LWavemSourceItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LWavemSourceItemId { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? M { get; set; }
        public double? Teta { get; set; }
        
        public Guid LWavemItemId { get; set; }
        public LWavemItem LWavemItem { get; set; }
    }
}
