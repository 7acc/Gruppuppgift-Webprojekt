using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Webb4_DAL.ModelsV2;

namespace Webb4_DAL.ViewModels2
{
    public class FormHousingViewModel
    { 
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
