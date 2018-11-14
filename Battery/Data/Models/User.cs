using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Battery.Data.Models
{
    public class User : IdentityUser
    {
        [Required(AllowEmptyStrings = false)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string LastName { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Birthday { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string City { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal CurrentProfit { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal PlannedProfit { get; set; }

        [ForeignKey(nameof(Avatar))]
        public string IdAvatar { get; set; }
        public virtual Avatar Avatar { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
