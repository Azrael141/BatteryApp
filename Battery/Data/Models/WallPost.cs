using Battery.Data.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Battery.Data.Models
{
    public class WallPost : BaseEntity
    {
        [Column(TypeName = "datetime2")]
        public DateTime DtCreate { get; set; }

        [Required(AllowEmptyStrings = false)]
        public string Message { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Energy { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal PlannedProfit { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CurrentProfit { get; set; }

        [ForeignKey(nameof(User))]
        public string IdUser { get; set; }
        public virtual User User { get; set; }
    }
}
