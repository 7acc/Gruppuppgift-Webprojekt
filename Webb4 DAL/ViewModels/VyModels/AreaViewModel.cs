using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.VyModels
{
    public class AreaViewModel
    {

        public AreaViewModel()
        {
            this.AreaApartment = new HashSet<ApartmentViewModel>();
        }
        public virtual ICollection<ApartmentViewModel> AreaApartment { get; set; }
        public Guid Id { get; set; }
        public string AreaName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }

    }
}
