using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.DataAccess.Models
{
    [Table("LWaveHrItem")]
    public class LWaveHrItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LWaveHrItemId { get; set; }
        public string Title { get; set; }
        public int? SourcesAmount { get; set; }
        public DateTime? LastModify { get; set; }

        public List<LWaveHrSourceItem> LWaveHrSourceItems { get; set; }
    }
}
