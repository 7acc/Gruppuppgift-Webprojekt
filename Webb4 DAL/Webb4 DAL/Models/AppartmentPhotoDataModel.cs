using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webb4_DAL.Models
{
    class AppartmentPhotoDataModel
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
