using System;
using System.Collections.Generic;

namespace Webb4_DAL.Models
{
    public class AreaData
    {

        public AreaData()
        {
            AreaApartmentM = new HashSet<ApartmentData>();
        }

        public int Id { get; set; }
        public string AreaName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ApartmentData> AreaApartmentM { get; set; }
    }
}
