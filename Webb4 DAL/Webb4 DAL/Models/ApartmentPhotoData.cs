﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Webb4_DAL.Models
{
    public class ApartmentPhotoData
    {

        public ApartmentPhotoData()
        {
            PhotoInApartM = new HashSet<ApartmentData>();
        }

    
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public DateTime UpdataDate { get; set; }
        public bool Status { get; set; }
        public int PhotoSize { get; set; }

        public virtual ICollection<ApartmentData> PhotoInApartM { get; set; }
    }
}
