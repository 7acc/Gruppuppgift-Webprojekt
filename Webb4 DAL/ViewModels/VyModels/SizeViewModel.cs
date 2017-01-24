using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.VyModels
{
    public class SizeViewModel
    {
        public SizeViewModel()
        {
            this.SizeApartment = new HashSet<ApartmentViewModel>();
        }
        public virtual ICollection<ApartmentViewModel> SizeApartment { get; set; }
        public Guid Id { get; set; }
        public string SizekName { get; set; }
        public string Description { get; set; }
    }
}
