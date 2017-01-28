using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webb4_DAL.ModelsV2
{
    public class Features
    {
        public int Id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Appartment> Appartments { get; set; }
    }
}