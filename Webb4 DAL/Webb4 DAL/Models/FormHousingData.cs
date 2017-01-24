using System;
using System.Collections.Generic;

namespace Webb4_DAL.Models
{
    public class FormHousingData
    {
        public FormHousingData()
        {
            this.FormHousingApartmentM = new HashSet<ApartmentData>();
        }
        public virtual ICollection<ApartmentData> FormHousingApartmentM { get; set; }
        public Guid Id { get; set; }
        public string FormOfHousing { get; set; }
        public string Description { get; set; }
    }
}
