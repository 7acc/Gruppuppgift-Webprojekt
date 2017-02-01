using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModels2.VyModels
{
    public class AppartmentViewModel
    {

        public AppartmentViewModel()
        {
            Features = new HashSet<FeaturesViewModel>();
            Photos = new HashSet<AppartmentPhotoViewModel>();
        }


        [Key]
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


        public virtual  AdressViewModel Adress { get; set; }
        public virtual  HousingTypeViewModel Housing { get; set; }
        public virtual  DistrictViewModel District { get; set; }
               
        public virtual  ICollection<FeaturesViewModel> Features { get; set; }
        public virtual  ICollection<AppartmentPhotoViewModel> Photos { get; set; }
             
        public virtual ICollection<UserViewModel> UsersFollowing { get; set; }

    }
}
