using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.DataAccess.Models
{
    [Table("LWavePItem")]
    public class LWavePItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LWavePItemId { get; set; }
        public string Title { get; set; }
        public int? SourcesAmount { get; set; }
        public DateTime? LastModify { get; set; }

        public List<LWavePSourceItem> LWavePSourceItems { get; set; }
    }
}
