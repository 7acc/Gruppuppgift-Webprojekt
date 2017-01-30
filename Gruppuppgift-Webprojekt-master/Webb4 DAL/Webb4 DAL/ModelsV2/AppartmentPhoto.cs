using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webb4_DAL.ModelsV2
{
   public  class AppartmentPhoto
    {
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
