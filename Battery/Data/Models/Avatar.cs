using Battery.Data.Common;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Battery.Data.Models
{
    public class Avatar : BaseEntity
    {
        [Column(TypeName = "datetime2")]
        public DateTime DtAdd { get; set; }
        public long Size { get; set; }
        public byte[] Content { get; set; }
    }
}
