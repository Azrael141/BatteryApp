using Battery.Data.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Battery.Data.Models
{
    public class DayPlan : BaseEntity
    {
        [Column(TypeName = "date")]
        public DateTime Day { get; set; }

        [ForeignKey(nameof(User))]
        public string IdUser { get; set; }
        public virtual User User { get; set; }

        [ForeignKey(nameof(Task))]
        public Guid IdTask { get; set; }
        public virtual Task Task { get; set; }
    }
}
