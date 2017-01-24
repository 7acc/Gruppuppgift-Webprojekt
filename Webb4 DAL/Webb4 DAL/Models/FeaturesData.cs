﻿using System;
using System.Collections.Generic;

namespace Webb4_DAL.Models
{
    public class FeaturesData
    {

        public FeaturesData()
        {
            this.FeatureApartmentM = new HashSet<ApartmentData>();
        }
        public virtual ICollection<ApartmentData> FeatureApartmentM { get; set; }
        public Guid Id { get; set; }
        public bool Hiss { get; set; }
        public bool Balkog { get; set; }
        public bool Stadsnät { get; set; }
        public bool Tvättmaskin { get; set; }
        public bool Torltumlare { get; set; }
        public bool Diskmaskin { get; set; }
        public bool Comhem { get; set; }
        public bool Imd { get; set; }
        public bool Säkerhetsdörr { get; set; }

    }
}