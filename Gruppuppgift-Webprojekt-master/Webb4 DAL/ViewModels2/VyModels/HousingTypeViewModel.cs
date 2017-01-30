using System.ComponentModel.DataAnnotations;

namespace ViewModels2.VyModels
{
    public class HousingTypeViewModel
    { 
        [Key]
        public int Id { get; set; }
        public string Type { get; set; }
    }
}
