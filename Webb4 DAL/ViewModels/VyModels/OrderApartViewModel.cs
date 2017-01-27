using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ViewModels.VyModels
{
    public class OrderApartViewModel
    {
        public OrderApartViewModel()
        {
            //this.o = new HashSet<o>();
        }

        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public int? UserId { get; set; }
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

        public UserDataViewModel UserData { get; set; }
        //public virtual ICollection<o> o { get; set; }
    }
}
