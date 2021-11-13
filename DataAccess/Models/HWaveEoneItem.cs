using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.DataAccess.Models
{
    [Table("HWaveEoneItem")]
    public class HWaveEoneItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public DateTime? LastModify { get; set; }
        public double? P { get; set; }
        public double? G { get; set; }
        public double? K { get; set; }
        public double? nu { get; set; }
        public double? FimAx { get; set; }
        public double? E { get; set; }
    }
}
