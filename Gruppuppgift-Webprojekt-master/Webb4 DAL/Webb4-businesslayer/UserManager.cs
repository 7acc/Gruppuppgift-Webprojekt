
using System.Threading.Tasks;
using ViewModels2.VyModels;

using Webb4_businesslayer.HelpMapper;
using Webb4_DAL;
using Webb4_DAL.ModelsV2;
using Webb4_DAL.Repositories;


namespace Webb4_businesslayer
{
   public class UserManager
    {
        GenericRepository<User> userRepository = new GenericRepository<User>(new Webb4Context());
        public UserMapping UserMapping { get; set; }
        public UserManager()
        {
            UserMapping = new UserMapping();
        }
   
        //----------------------------------------------------------------------------
        public void RegisterUser2(UserViewModel UserToRegister)
        {
            var repo = new TestRepo();
            repo.RegisterUser(UserToRegister.ViewModelToUser());
        }
        public UserViewModel GetUserToLogin2(string email, string password)
        {
            var repo = new TestRepo();
            var userToLogin = repo.Login(email, password);
            if (userToLogin != null)
            {
                return userToLogin.UserToViewModel();
            }
            else
            {
                return null;
            }
        }
    }
}
