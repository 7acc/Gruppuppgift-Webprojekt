using System;
using System.Collections.Generic;

namespace Webb4_DAL.Models
{
    public class FeaturesData
    {

        public FeaturesData()
        {
            this.FeatureApartmentM = new HashSet<ApartmentData>();
        }

        public int Id { get; set; }
        public bool Elevator { get; set; }
        public bool Balcony { get; set; }
        public bool Comhem { get; set; }
        public bool WashingMachine { get; set; }

        public virtual ICollection<ApartmentData> FeatureApartmentM { get; set; }


    }
}
