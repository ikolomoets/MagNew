using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.DataAccess.Models
{
    [Table("HWaveWSourceItem")]
    public class HWaveWSourceItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid HWaveWSourceItemId { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? P { get; set; }
        public double? G { get; set; }
        public double? K { get; set; }
        public double? nu { get; set; }
        public double? E { get; set; }
        public double? Alfa1 { get; set; }
        public double? Alfad { get; set; }

        public Guid HWaveWItemId { get; set; }
        public HWaveWItem HWaveWItem { get; set; }
    }
}
