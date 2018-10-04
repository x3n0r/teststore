namespace VeriStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_animal
    {
        public int Id { get; set; }

        [StringLength(64)]
        public string name { get; set; }

        [StringLength(64)]
        public string species { get; set; }

        [StringLength(64)]
        public string race { get; set; }

        public DateTime? date_of_birth { get; set; }

        public string notes { get; set; }

        public int? cust_id { get; set; }
    }
}
