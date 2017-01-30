using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webb4_DAL.ModelsV2
{
    public class User
    {
        public User()
        {
            this.SavedAppartments = new HashSet<Appartment>();
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual Adress Adress { get; set; }
      
        public virtual ICollection<Appartment> SavedAppartments{ get; set; }

    }
}
