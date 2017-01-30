using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Webb4_DAL.Models
{
    public class SizeData
    {
        public SizeData()
        {
            SizeApartmentM = new HashSet<ApartmentData>();
        }
        
        public int Id { get; set; }
        public string SizekName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ApartmentData> SizeApartmentM { get; set; }
    }
}
