namespace RehberApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Directory")]
    public partial class Directory
    {
        public int directoryId { get; set; }

        public int? userId { get; set; }

        public int? recordedUserId { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
