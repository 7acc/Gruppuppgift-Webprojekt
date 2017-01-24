using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Webb4_DAL.Models
{
    public class ApartmentPhotoData
    {

        public ApartmentPhotoData()
        {
            this.PhotoInApartM = new HashSet<ApartmentData>();
        }
        public virtual ICollection<ApartmentData> PhotoInApartM { get; set; }
        [Key]
        public Guid Id { get; set; }
        
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
