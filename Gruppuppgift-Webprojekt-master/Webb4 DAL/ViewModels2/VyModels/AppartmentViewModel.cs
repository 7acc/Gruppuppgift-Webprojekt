using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Webb4_DAL.ModelsV2;


namespace Webb4_DAL.ViewModels2
{
    public class AppartmentViewModel
    {

        public AppartmentViewModel()
        {
            Features = new HashSet<FeaturesViewModel>();
            Photos = new HashSet<AppartmentPhotoViewModel>();
           
        }


      
        public int Id { get; set; }
        public int Area { get; set; }
        public int Rent { get; set; }
        public int NrOfRooms { get; set; }
        public int BuildinFloors { get; set; }
        public int Floor { get; set; }
        public DateTime BuildYear { get; set; }
        public DateTime MoveInDate { get; set; }
        public DateTime LastAdmissionDate { get; set; }
        public DateTime PublicationDate { get; set; }
        public bool Avalible { get; set; }


        public  AdressViewModel Adress { get; set; }
        public  FormHousingViewModel Housing { get; set; }
        public AreaViewModel  District { get; set; }


        public  ICollection<FeaturesViewModel> Features { get; set; }
        public  ICollection<AppartmentPhotoViewModel> Photos { get; set; }

       

    }
}
