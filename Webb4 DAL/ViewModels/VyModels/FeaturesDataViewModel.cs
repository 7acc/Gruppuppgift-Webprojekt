using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Webb4_DAL.Models;

namespace ViewModels.VyModels
{
    public class FeaturesDataViewModel
    {

        [Key]
        [ForeignKey("FeaturesOfAppartment")]
        public Guid AppertmentID { get; set; }
        
        public bool Feature1 { get; set; }
        public bool Feature2 { get; set; }
        public bool Feature3 { get; set; }
        public bool Feature4 { get; set; }
        public bool Feature5 { get; set; }
        public bool Feature6 { get; set; }

        public AppartmentDataModel FeaturesOfAppartment { get; set; }
    }
}
