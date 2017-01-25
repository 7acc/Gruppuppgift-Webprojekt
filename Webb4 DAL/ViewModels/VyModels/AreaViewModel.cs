using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.VyModels
{
    public class AreaViewModel
    {

        public AreaViewModel()
        {
            AreaApartment = new HashSet<ApartmentViewModel>();
        }
        [Key]
        public Guid Id { get; set; }
        public string AreaName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public virtual ICollection< ApartmentViewModel> AreaApartment { get; set; }
    }
}
