using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace ViewModels2.VyModels
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            SavedAppartments = new HashSet<AppartmentViewModel>();
        }
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public  AdressViewModel Adress { get; set; }

        public virtual ICollection<AppartmentViewModel> SavedAppartments { get; set; }
    }
}