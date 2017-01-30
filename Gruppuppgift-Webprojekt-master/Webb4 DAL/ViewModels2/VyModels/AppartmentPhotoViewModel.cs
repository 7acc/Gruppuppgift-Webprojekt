using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Webb4_DAL.ModelsV2;

namespace ViewModels2.VyModels
{
    public class AppartmentPhotoViewModel
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
