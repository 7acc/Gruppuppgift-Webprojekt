using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webb4_DAL.ViewModels2
{
    public class ApartmentPhotoViewModel
    { 
        [Key]
        public int Id { get; set; }
        public Guid Name { get; set; }
        public string URL { get; set; }
        public string Description { get; set; }
        public bool Approved { get; set; }


        public int AppartmentId { get; set; }
        [ForeignKey("AppartmentId")]
        public virtual Appartment Appartment { get; set; }
    }
}
