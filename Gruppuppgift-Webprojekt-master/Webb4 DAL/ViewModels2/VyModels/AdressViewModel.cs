using System.ComponentModel.DataAnnotations;

namespace ViewModels2.VyModels
{
    public class AdressViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Street { get; set; }
        public int PostalNr { get; set; }
        public string City { get; set; }
    }
}
