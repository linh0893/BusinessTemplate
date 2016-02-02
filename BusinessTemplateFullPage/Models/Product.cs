namespace BusinessTemplateFullPage.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Product")]
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Images = new HashSet<Image>();
            KeyWords = new HashSet<KeyWord>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Product_id { get; set; }

        [StringLength(100)]
        public string Product_name { get; set; }

        public int? Price { get; set; }

        [StringLength(50)]
        public string Status { get; set; }

        public int? Quantity { get; set; }

        [StringLength(1000)]
        public string Descriptions { get; set; }

        public int? Image_id { get; set; }

        [StringLength(50)]
        public string IsDisplay { get; set; }

        public int? TopView { get; set; }

        public int? Discount { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Discount_Start { get; set; }

        public int? Category_Id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Discount_End { get; set; }

        public virtual Category Category { get; set; }

        public virtual Image Image { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Images { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KeyWord> KeyWords { get; set; }
    }
}
