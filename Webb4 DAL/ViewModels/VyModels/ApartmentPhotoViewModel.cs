using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.VyModels
{
    public class ApartmentPhotoViewModel
    {

        public ApartmentPhotoViewModel()
        {
            PhotoInApart = new HashSet<ApartmentViewModel>();
        }


        [Key]
        public Guid Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime UpdataDate { get; set; }
        public bool Status { get; set; }
        public int PhotoSize { get; set; }

        public virtual ICollection<ApartmentViewModel> PhotoInApart { get; set; }
    }
}
