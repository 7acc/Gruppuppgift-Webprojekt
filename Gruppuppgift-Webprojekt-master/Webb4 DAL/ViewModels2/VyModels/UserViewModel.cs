using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Webb4_DAL.ModelsV2;

namespace Webb4_DAL.ViewModels2
{
    public class UserViewModel
    {
        public UserViewModel()
        {
            SavedAppartments = new HashSet<Appartment>();
        }
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual Adress Adress { get; set; }

        public virtual ICollection<Appartment> SavedAppartments { get; set; }
    }
}