using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.DataAccess.Models
{
    [Table("LWaveErSourceItem")]
    public class LWaveErSourceItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LWaveErSourceItemId { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Ej { get; set; }
        public double? R { get; set; }
        public double? Teta { get; set; }

        public Guid LWaveErItemId { get; set; }
        public LWaveErItem LWaveErItem { get; set; }
    }
}
