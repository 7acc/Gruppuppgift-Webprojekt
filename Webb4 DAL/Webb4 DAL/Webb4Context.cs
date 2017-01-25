
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


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<ApartmentData>()
        //        .HasMany(s => s.ApartmentFeatureM)
        //        .WithMany(c => c.FeatureApartmentM)
        //        .Map(cs =>
        //        {
        //            cs.MapLeftKey("ApartmentRefId");
        //            cs.MapRightKey("FeatureRefId");
        //            cs.ToTable("ApartmentFeature");
        //        });
        //}
    }

   
}
