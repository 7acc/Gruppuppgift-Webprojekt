using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Webb4_DAL.ModelsV2;

namespace Webb4_DAL.ViewModels2
{
    public class DistrictViewModel
    { 
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
