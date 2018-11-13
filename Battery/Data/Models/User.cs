using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Battery.Data.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime Birthday { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
    }
}
