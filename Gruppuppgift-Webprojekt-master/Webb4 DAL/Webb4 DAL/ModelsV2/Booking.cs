using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webb4_DAL.ModelsV2
{
   public class Booking
    {
        public int Id { get; set; }
        public virtual User booker { get; set; }
        public virtual Appartment Appartment { get; set; }

    }
}
