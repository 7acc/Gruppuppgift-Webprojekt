﻿using System;

namespace Webb4_DAL.Models
{
    public class AppartmentPhotoDataModel
    {
        public Guid PhotoId { get; set; }
        public Guid ApartmentId { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public AppartmentDataModel PhotoFor { get; set; }
    }
}
