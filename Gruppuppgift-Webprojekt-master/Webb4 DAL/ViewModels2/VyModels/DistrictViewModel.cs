using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Webb4_DAL.ViewModels2
{
    public class AreaViewModel
    { 
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
