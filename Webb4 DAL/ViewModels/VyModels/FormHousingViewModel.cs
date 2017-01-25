using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.VyModels
{
    public class FormHousingViewModel
    {
        public FormHousingViewModel()
        {
            FormHousingApartment = new HashSet<ApartmentViewModel>();
        }
        [Key]
      public Guid Id { get; set; }
        public string FormOfHousing { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ApartmentViewModel> FormHousingApartment { get; set; }
    }
}
