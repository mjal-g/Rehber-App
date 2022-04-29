namespace RehberApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhoneNumber")]
    public partial class PhoneNumber
    {
        public int phoneNumberId { get; set; }

        [StringLength(50)]
        public string phone { get; set; }

        public int? userId { get; set; }

        public virtual User User { get; set; }
    }
}
