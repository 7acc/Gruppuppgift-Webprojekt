using System;
using System.Collections.Generic;

namespace Webb4_DAL.Models
{
    public class ApartmentData
    {

        public ApartmentData()
        {
            ApartmentUserM = new HashSet<UserData>();
        }
        public Guid Id { get; set; }


        public Guid? FormHId { get; set; }
        public Guid? SizeId { get; set; }
        public Guid? FeatureId { get; set; }
        public Guid? AreaId { get; set; }
        public Guid? ApartImgId { get; set; }
        public int BuildYear { get; set; }
        public decimal ApartmentArea { get; set; }
        public virtual string QuantityRooms { get; set; }
        public double Floor { get; set; }
        public double Price { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public DateTime? Available { get; set; } // Tillträde
        public DateTime? DeadlineDate { get; set; } // Sista anmälsningsdatum

        public AreaData ApartmentAreaM { get; set; }
        public ApartmentPhotoData ApartmentPhotoM { get; set; }
        public virtual ICollection<UserData> ApartmentUserM { get; set; }
        public FeaturesData ApartmentFeatureM { get; set; }

        public FormHousingData ApartmentFormHousingM { get; set; }
        public SizeData ApartmentSizeM { get; set; }



    }
}
