﻿using System;

namespace Webb4_DAL.Models
{
    public class FeaturesDataModel
    {

        public Guid AppertmentID { get; set; }
        
        public bool Feature1 { get; set; }
        public bool Feature2 { get; set; }
        public bool Feature3 { get; set; }
        public bool Feature4 { get; set; }
        public bool Feature5 { get; set; }
        public bool Feature6 { get; set; }

        public AppartmentDataModel FeaturesOfAppartment { get; set; }
    }
}
