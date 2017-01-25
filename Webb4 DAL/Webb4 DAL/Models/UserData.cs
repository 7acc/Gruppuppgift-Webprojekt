using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webb4_DAL.Models
{
    public class UserData
    {
        public UserData()
        {
            //this.WatchListM = new HashSet<ApartmentData>();
        }
        //[Key]
        //[Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }

        public Guid? ApartmentId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }

        public ApartmentData UserApart { get; set; }
        //public virtual ICollection<ApartmentData> ApartmentDatasM { get; set; }
    }
}
