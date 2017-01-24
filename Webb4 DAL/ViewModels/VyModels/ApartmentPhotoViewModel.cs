using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Webb4_DAL.Models;

namespace ViewModels.VyModels
{
    public class ApartmentPhotoViewModel
    {

        public ApartmentPhotoViewModel()
        {
            this.ApartmentPhoto = new HashSet<ApartmentViewModel>();
        }
        public virtual ICollection<ApartmentViewModel> ApartmentPhoto { get; set; }
        [Key]
        public Guid Id { get; set; }
        
        public string Url { get; set; }
        public string Description { get; set; }
    }
}
