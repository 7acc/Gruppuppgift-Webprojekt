﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Webb4_DAL.ViewModels2
{
    public class BookingViewModel
    {
        public int Id { get; set; }
        public virtual User booker { get; set; }
        public virtual Appartment Appartment { get; set; }
    }
}