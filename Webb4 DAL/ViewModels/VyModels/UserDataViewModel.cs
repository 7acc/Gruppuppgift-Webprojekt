using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webb4_DAL.Models;

namespace ViewModels.VyModels
{
    public class UserDataViewModel
    {
        public UserDataViewModel()
        {
            this.WatchList = new HashSet<AppartmentDataModel>();
        }
        public Guid UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public AdressDataModel UserAdress { get; set; }
        public virtual ICollection<AppartmentDataModel> WatchList { get; set; }
    }
}
