namespace CustomerContactDetails.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Customer")]
    public partial class Customer
    {
        [Key]
        [StringLength(50)]
        public string CustId { get; set; }

        [Required]
        [StringLength(50)]
        public string CustName { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }
    }
}
