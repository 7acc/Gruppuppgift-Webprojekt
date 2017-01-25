using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.VyModels
{
    public class ApartmentViewModel
    {

        public ApartmentViewModel()
        {
            ApartmentUser = new HashSet<UserDataViewModel>();
        }


        [Key]
        public Guid Id { get; set; }


        public Guid? FormHId { get; set; }
        public Guid? SizeId { get; set; }
        public Guid? FeatureId { get; set; }
        public Guid? AreaId { get; set; }
        public Guid? ApartImgId { get; set; }
        public int BuildYear { get; set; }
        public decimal ApartArea { get; set; }
        public string QuantityRooms { get; set; }
        public double Floor { get; set; }
        public double Price { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public DateTime? Available { get; set; } // Tillträde
        public DateTime? DeadlineDate { get; set; } // Sista anmälsningsdatum


        public AreaViewModel ApartmentAreaV { get; set; }
        public ApartmentPhotoViewModel ApartmentPhoto { get; set; }
        public virtual ICollection<UserDataViewModel> ApartmentUser { get; set; }
        public FeaturesViewModel ApartmentFeature { get; set; }

        public FormHousingViewModel ApartmentFormHousing { get; set; }
        public SizeViewModel ApartmentSize { get; set; }

    }
}
