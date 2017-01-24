using System;
using System.Collections.Generic;

namespace Webb4_DAL.Models
{
    public class UserData
    {
        public UserData()
        {
            this.WatchListM = new HashSet<ApartmentData>();
        }
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public AdressData UserAdressM { get; set; }
        public virtual ICollection<ApartmentData> WatchListM { get; set; }
    }
}
