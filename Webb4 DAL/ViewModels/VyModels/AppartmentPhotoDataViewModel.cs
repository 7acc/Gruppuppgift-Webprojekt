using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Webb4_DAL.Models;

namespace ViewModels.VyModels
{
    public class AppartmentPhotoDataViewModel
    {
        [Key]
        public Guid PhotoId { get; set; }
        [Key]
        [ForeignKey("PhotoFor")]
        public Guid ApartmentId { get; set; }

        public string Url { get; set; }
        public string Description { get; set; }

        public AppartmentDataModel PhotoFor { get; set; }
    }
}
