using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.VyModels
{
    public class SizeViewModel
    {
        public SizeViewModel()
        {
            this.SizeApartment = new HashSet<ApartmentViewModel>();
        }
       [Key]
        public Guid SizeId { get; set; }
        public string SizekName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ApartmentViewModel> SizeApartment { get; set; }
    }
}
