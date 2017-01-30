using System.ComponentModel.DataAnnotations;

namespace ViewModels2.VyModels
{
    public class DistrictViewModel
    { 
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
