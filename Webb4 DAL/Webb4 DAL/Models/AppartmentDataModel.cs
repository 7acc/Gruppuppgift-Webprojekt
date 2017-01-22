using System;

namespace Webb4_DAL.Models
{
    public class AppartmentDataModel
    {
        public Guid Id { get; set; }
        public AdressDataModel AppartmentAdress { get; set; }
        public bool Available { get; set; }

        public DateTime SisstAnmälningsdag { get; set; }
        public DateTime VisningsDatum { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbUrl { get; set; }
        
    }
}
