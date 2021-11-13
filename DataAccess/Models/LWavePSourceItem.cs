using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.DataAccess.Models
{
    [Table("LWavePSourceItem")]
    public class LWavePSourceItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LWavePSourceItemId { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? P { get; set; }
        public double? Teta { get; set; }

        public Guid LWavePItemId { get; set; }
        public LWavePItem LWavePItem { get; set; }
    }
}
