using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webb4___MVC;
using Webb4___MVC.Models.User;
using Webb4_DAL;
using Webb4_DAL.Repositories;
using Webb4_DAL.Models;

namespace Webb4_businesslayer
{
    class UserManager
    {
        UserRepository<UserDataModel> userRepository = new UserRepository<UserDataModel>(new Webb4_Context());
        
        //public bool LogInUser(UserLoginViewModel User)
        //{
        //    UserDataModel userToLogIn = userRepository.
        //}
    }
}
