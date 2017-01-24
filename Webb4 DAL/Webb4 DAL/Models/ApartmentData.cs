using System;

namespace Webb4_DAL.Models
{
    public class ApartmentData
    {

        public Guid Id { get; set; }
        //ForeignKey
        public Guid AreaId { get; set; }
        //ForeignKey
        public Guid AdressId { get; set; }
        //ForeignKey
        public Guid SizeId { get; set; }
        //ForeignKey
        public Guid HousingId { get; set; }
        //ForeignKey
        public Guid ApartPhotoId { get; set; }
        //ForeignKey
        public Guid FeatursId { get; set; }


        public int BuildYear { get; set; }
        public decimal Ytakvm { get; set; }
        public int Floor { get; set; }
        public int Rent { get; set; } 

        public DateTime Available { get; set; }
        public DateTime SisstAnmälningsdag { get; set; }
        public DateTime VisningsDatum { get; set; }


        public FeaturesData ApartmentFeatureM { get; set; }
        public ApartmentPhotoData ApartmentPhotoM { get; set; }
        public FormHousingData ApartmentFormHousingM { get; set; }
        public SizeData ApartmentSizeM { get; set; }
        public AreaData ApartmentAreaM { get; set; }
        public AdressData ApartmentAdressM { get; set; }

    }
}
