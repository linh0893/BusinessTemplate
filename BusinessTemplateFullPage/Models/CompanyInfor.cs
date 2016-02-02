namespace BusinessTemplateFullPage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CompanyInfor")]
    public partial class CompanyInfor
    {
        [Required]
        [StringLength(100)]
        public string Company_name { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Account_Admin { get; set; }

        [StringLength(50)]
        public string Account_password { get; set; }

        [StringLength(200)]
        public string Address { get; set; }

        public double? location_lat { get; set; }

        public double? lacation_lng { get; set; }

        [StringLength(100)]
        public string link_logo { get; set; }

        [StringLength(4000)]
        public string About { get; set; }

        [StringLength(100)]
        public string Company_image { get; set; }

        [StringLength(100)]
        public string Company_video { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CompanyId { get; set; }
    }
}
