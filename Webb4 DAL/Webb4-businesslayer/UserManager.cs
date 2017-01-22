
using Webb4_DAL;
using Webb4_DAL.Repositories;
using Webb4_DAL.Models;

namespace Webb4_businesslayer
{
    class UserManager
    {
        UserRepository<UserDataModel> userRepository = new UserRepository<UserDataModel>(new Webb4Context());
        
        //public bool LogInUser(UserLoginViewModel User)
        //{
        //    UserDataModel userToLogIn = userRepository.
        //}
    }
}
