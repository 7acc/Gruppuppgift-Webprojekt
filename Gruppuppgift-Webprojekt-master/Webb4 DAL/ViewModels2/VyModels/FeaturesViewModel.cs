using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Webb4_DAL.ModelsV2;

namespace Webb4_DAL.ViewModels2
{
    public class FeaturesViewModel
    {

        public FeaturesViewModel()
        {
            FeatureApartments = new HashSet<Appartment>();
        }
        [Key]
        public int Id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Appartment> FeatureApartments { get; set; }

    }
}
