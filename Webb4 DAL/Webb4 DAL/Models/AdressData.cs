using System;
using System.Collections.Generic;

namespace Webb4_DAL.Models
{
    public class AdressData
    {
        public AdressData()
        {
            this.AdressApartmentM= new HashSet<ApartmentData>();
            this.AdressUserM = new HashSet<UserData>();
        }
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string PostalNumber { get; set; }
        public string City { get; set; }

        public virtual  ICollection<ApartmentData> AdressApartmentM { get; set; }
        public virtual ICollection<UserData> AdressUserM { get; set; }
    }
}
