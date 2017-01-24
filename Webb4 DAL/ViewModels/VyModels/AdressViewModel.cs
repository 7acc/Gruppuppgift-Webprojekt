using System;
using System.Collections.Generic;

namespace ViewModels.VyModels
{
    public class AdressViewModel
    {
        public AdressViewModel()
        {
            this.AdressApartment= new HashSet<ApartmentViewModel>();
            this.AdressUser = new HashSet<UserDataViewModel>();
        }
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string PostalNumber { get; set; }
        public string City { get; set; }

        public virtual  ICollection<ApartmentViewModel> AdressApartment { get; set; }
        public virtual ICollection<UserDataViewModel> AdressUser { get; set; }
    }
}
