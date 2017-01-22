﻿using System;
using Webb4_DAL.Models;

namespace ViewModels.VyModels
{
    public class AppartmentDataViewModel
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
