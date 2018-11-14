using Battery.Data.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Battery.Data.Models
{
    public class Task : BaseEntity
    {
        [Required(AllowEmptyStrings = false)]
        public string Name { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime DtCreate { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DtStart { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? DtFinish { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; }
        public TaskStatus Status { get; set; }

        [ForeignKey(nameof(User))]
        public string IdUser { get; set; }
        public virtual User User { get; set; }
    }
}
