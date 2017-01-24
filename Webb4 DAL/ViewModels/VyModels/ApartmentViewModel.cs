using System;
using Webb4_DAL.Models;

namespace ViewModels.VyModels
{
    public class ApartmentViewModel
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


        public FeaturesViewModel ApartmentFeature { get; set; }
        public ApartmentPhotoViewModel ApartmentPhoto { get; set; }
        public FormHousingViewModel ApartmentFormHousing { get; set; }
        public SizeViewModel ApartmentSize { get; set; }
        public AreaViewModel ApartmentArea { get; set; }
        public AdressViewModel ApartmentAdress { get; set; }

    }
}
