using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.VyModels
{
    public class FormHousingViewModel
    {
        public FormHousingViewModel()
        {
            this.FormHousingApartment = new HashSet<ApartmentViewModel>();
        }
        public virtual ICollection<ApartmentViewModel> FormHousingApartment { get; set; }
        public Guid Id { get; set; }
        public string FormOfHousing { get; set; }
        public string Description { get; set; }
    }
}
