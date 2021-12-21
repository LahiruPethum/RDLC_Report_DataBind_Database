namespace ReportDesign
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employeedata")]
    public partial class employeedata
    {
        [StringLength(30)]
        public string Name { get; set; }

        public int? age { get; set; }

        [StringLength(20)]
        public string town { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
    }
}
