using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webb4_DAL.Models
{
    public class OrderApart
    {
        public OrderApart()
        {
            //this.o = new HashSet<o>();
        }

        //[Key]
        //[Required]
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? UserId { get; set; }
        public DateTime? InterestDate { get; set; } // Intresseanmälan
        public DateTime? RequiredDate { get; set; }
        public DateTime? OccupancyDate { get; set; } // Inflyttningsdatum
        public decimal ApartmentArea { get; set; } // Storleken på lägenheten i KVM
        public double Price { get; set; }
        public string OrderName { get; set; }
        public string OrderAddress { get; set; }
        public string OrderCity { get; set; }
        public string OrderRegion { get; set; }
        public string OrderPostalCode { get; set; }
        public string OrderCountry { get; set; }

        public UserData UserData { get; set; }
        //public virtual ICollection<o> o { get; set; }
    }
}

