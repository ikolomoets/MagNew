using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.DataAccess.Models
{
    [Table("LWaveHrSourceItem")]
    public class LWaveHrSourceItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LWaveHrSourceItemId { get; set; }
        public double? X { get; set; }
        public double? Y { get; set; }
        public double? Hj { get; set; }
        public double? R { get; set; }
        public double? Teta { get; set; }

        public Guid LWaveHrItemId { get; set; }
        public LWaveHrItem LWaveHrItem { get; set; }
    }
}
