using System;
using System.Collections.Generic;

namespace Webb4_DAL.Models
{
    public class SizeData
    {
        public SizeData()
        {
            this.SizeApartmentM = new HashSet<ApartmentData>();
        }
        public virtual ICollection<ApartmentData> SizeApartmentM { get; set; }
        public Guid Id { get; set; }
        public string SizekName { get; set; }
        public string Description { get; set; }
    }
}
