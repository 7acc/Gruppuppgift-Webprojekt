using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.VyModels
{
    public class FeaturesViewModel
    {

        public FeaturesViewModel()
        {
            FeatureApartment = new HashSet<ApartmentViewModel>();
        }
        [Key]
        public Guid Id { get; set; }
        public bool Elevator { get; set; }
        public bool Balcony { get; set; }
        public bool Comhem { get; set; }
        public bool WashingMachine { get; set; }

        public virtual ICollection<ApartmentViewModel> FeatureApartment { get; set; }

    }
}
