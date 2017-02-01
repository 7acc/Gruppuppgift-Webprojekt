using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModels2.VyModels
{
    public class FeaturesViewModel
    {

        public FeaturesViewModel()
        {
            FeatureApartments = new HashSet<AppartmentViewModel>();
        }
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public virtual ICollection<AppartmentViewModel> FeatureApartments { get; set; }

    }
}
