using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webb4_DAL.ViewModels2
{
    public class AdressViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public int PostalNr { get; set; }
        public string City { get; set; }
    }
}
