namespace BusinessTemplateFullPage.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CoreDB : DbContext
    {
        public CoreDB()
            : base("name=CoreDB")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CompanyInfor> CompanyInfors { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<KeyWord> KeyWords { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyInfor>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyInfor>()
                .Property(e => e.Account_Admin)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyInfor>()
                .Property(e => e.Account_password)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyInfor>()
                .Property(e => e.link_logo)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyInfor>()
                .Property(e => e.Company_image)
                .IsUnicode(false);

            modelBuilder.Entity<CompanyInfor>()
                .Property(e => e.Company_video)
                .IsUnicode(false);

            modelBuilder.Entity<Image>()
                .Property(e => e.Image_link)
                .IsUnicode(false);

            modelBuilder.Entity<Image>()
                .HasMany(e => e.Products)
                .WithOptional(e => e.Image)
                .HasForeignKey(e => e.Image_id);

            modelBuilder.Entity<Image>()
                .HasMany(e => e.Products1)
                .WithMany(e => e.Images)
                .Map(m => m.ToTable("Product_Image").MapLeftKey("Image_Id").MapRightKey("Product_id"));

            modelBuilder.Entity<KeyWord>()
                .Property(e => e.KeywordEN)
                .IsUnicode(false);

            modelBuilder.Entity<KeyWord>()
                .HasMany(e => e.Products)
                .WithMany(e => e.KeyWords)
                .Map(m => m.ToTable("Product_Keyword").MapLeftKey("Key_Id").MapRightKey("Product_Id"));

            modelBuilder.Entity<KeyWord>()
                .HasMany(e => e.Topics)
                .WithMany(e => e.KeyWords)
                .Map(m => m.ToTable("Topic_Keyword").MapLeftKey("Keyword_id").MapRightKey("Topic_Id"));

            modelBuilder.Entity<Product>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.IsDisplay)
                .IsUnicode(false);
        }
    }
}
