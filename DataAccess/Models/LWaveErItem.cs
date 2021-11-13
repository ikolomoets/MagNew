using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.DataAccess.Models
{
    [Table("LWaveErItem")]
    public class LWaveErItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LWaveErItemId { get; set; }
        public string Title { get; set; }
        public int? SourcesAmount { get; set; }
        public DateTime? LastModify { get; set; }

        public List<LWaveErSourceItem> LWaveErSourceItems { get; set; }
    }
}
