
using System.Threading.Tasks;
using ViewModels.VyModels;

using Webb4_businesslayer.HelpMapper;
using Webb4_DAL;
using Webb4_DAL.Models;
using Webb4_DAL.Repositories;


namespace Webb4_businesslayer
{
   public class UserManager
    {
        GenericRepository<UserData> userRepository = new GenericRepository<UserData>(new Webb4Context());
        public UserDataMapping UserDataMapping { get; set; }
        public UserManager()
        {
            UserDataMapping = new UserDataMapping();
        }
        public async Task<UserDataViewModel> GetUserToLogin(string Email, string password)
        {
            UserDataViewModel userToLogin = null;

            var user = userRepository.LoginUser(Email, password);
            if (user != null)
            {
                userToLogin = await UserDataMapping.FromBltoUiGetById(user.Id);
            }
            return userToLogin;
        }
        public void RegisterUser(UserDataViewModel Newuser)
        {
             UserDataMapping.FromBltoUiInser(Newuser);
        }
        //----------------------------------------------------------------------------
        public void RegisterUser2(UserDataViewModel UserToRegister)
        {
            var repo = new TestRepo();
            repo.RegisterUser(UserToRegister.ViewModelToUser());
        }
        public UserDataViewModel GetUserToLogin2(string email, string password)
        {
            var repo = new TestRepo();
            var userToLogin = repo.Login(email, password);
            return userToLogin.UserToViewModel();
        }
    }
}
