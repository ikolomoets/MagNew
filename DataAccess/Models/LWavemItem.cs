using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.DataAccess.Models
{
    [Table("LWavemItem")]
    public class LWavemItem
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid LWavemItemId { get; set; }
        public string Title { get; set; }
        public int? SourcesAmount { get; set; }
        public DateTime? LastModify { get; set; }

        public List<LWavemSourceItem> LWavemSourceItems { get; set; }
    }
}
