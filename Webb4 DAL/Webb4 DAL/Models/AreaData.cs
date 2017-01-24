using System;
using System.Collections.Generic;

namespace Webb4_DAL.Models
{
    public class AreaData
    {

        public AreaData()
        {
            this.AreaApartmentM = new HashSet<ApartmentData>();
        }
        public virtual ICollection<ApartmentData> AreaApartmentM { get; set; }
        public Guid Id { get; set; }
        public string AreaName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

    }
}
