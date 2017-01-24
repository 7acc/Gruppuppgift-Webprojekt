using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Webb4_DAL.Models;

namespace ViewModels.VyModels
{
    public class FeaturesViewModel
    {

        public FeaturesViewModel()
        {
            this.FeatureApartment = new HashSet<ApartmentViewModel>();
        }
        public virtual ICollection<ApartmentViewModel> FeatureApartment { get; set; }
        public Guid Id { get; set; }
        public bool Hiss { get; set; }
        public bool Balkog { get; set; }
        public bool Stadsnät { get; set; }
        public bool Tvättmaskin { get; set; }
        public bool Torltumlare { get; set; }
        public bool Diskmaskin { get; set; }
        public bool Comhem { get; set; }
        public bool Imd { get; set; }
        public bool Säkerhetsdörr { get; set; }

        //[Key]
        //[ForeignKey("FeaturesOfAppartment")]
        //public Guid ApertmentId { get; set; }
        //public ApartmentViewModel FeaturesOfApartment { get; set; }
    }
}
