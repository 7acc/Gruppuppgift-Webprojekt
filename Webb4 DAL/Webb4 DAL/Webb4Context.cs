
using System.Data.Entity;
using Webb4_DAL.Models;

namespace Webb4_DAL
{
    public class Webb4Context : DbContext
    {
        public Webb4Context():base("Webb4Context")
        {
            //SetInitializer<Webb4Context>(new DropCreateDatabaseIfModelChanges<Webb4Context>());
        }



        public DbSet<OrderApart> OrderDataModels { get; set; }
        public DbSet<ApartmentData> AppartmentDataModels { get; set; }
        public DbSet<ApartmentPhotoData> ApartmentPhotoDataModels { get; set; }
        public DbSet<AreaData> AreaDataModels { get; set; }
        public DbSet<FeaturesData> FeatuersDataModels { get; set; }
        public DbSet<FormHousingData> FormHousingDataModels { get; set; }
        public DbSet<SizeData> SizeDataModels { get; set; }
        public DbSet<UserData> UserDatagDataModels { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<UserData>().HasRequired(m => m.UserApartmentM)
            //   .WithMany(m => m.).HasForeignKey(m => m.ApartmentId);
            //modelBuilder.Entity<ApartmentData>().HasRequired(m => m.ApartmentSizeM)
            //.WithMany(m => m.SizeApartmentM).HasForeignKey(m => m.SizeId);
            //modelBuilder.Entity<Entity2>().HasMany(e => e.Entity1s)
            //    .WithMany(e => e.Entity2s);

            //modelBuilder.Entity<ApartmentData>()
            //   .HasMany(c => c.ApartmentUserM).WithMany(i => i.UserApartmentM)
            //   .Map(t => t.MapLeftKey("Id")
            //       .MapRightKey("Id")
            //       .ToTable("UserDataApartmentDatas"));

        }
        
    }

   
}
