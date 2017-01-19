using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Webb4_DAL.Models
{
    class AppartmentDataModel
    {
     

        public Guid AppartmentId { get; set; }
        public AdressDataModel AppartmentAdress { get; set; }
        public bool Available { get; set; }

        public DateTime SisstAnmälningsdag { get; set; }
        public DateTime VisningsDatum { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbUrl { get; set; }

   
        
    }
}
