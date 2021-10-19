namespace WebAdvertiseApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Consultant
    {
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string gender { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Available_time { get; set; }

        public int? Rating { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
