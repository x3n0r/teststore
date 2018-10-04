namespace VeriStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tbl_companydata
    {
        public int Id { get; set; }

        public string name { get; set; }

        public string slogan { get; set; }

        [StringLength(50)]
        public string contact_phone { get; set; }

        [StringLength(50)]
        public string contact_email { get; set; }

        [StringLength(50)]
        public string IBAN { get; set; }

        [StringLength(50)]
        public string BIC { get; set; }

        [StringLength(64)]
        public string address_street { get; set; }

        [StringLength(64)]
        public string address_postcode { get; set; }

        [StringLength(64)]
        public string address_city { get; set; }

        [StringLength(64)]
        public string address_country { get; set; }

        public string logo { get; set; }
    }
}
