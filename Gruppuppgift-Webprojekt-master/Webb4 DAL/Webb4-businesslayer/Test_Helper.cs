using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webb4_DAL.ModelsV2;
using ViewModels.VyModels;


namespace Webb4_businesslayer
{
    static class Test_Helper
    {
        public static UserDataViewModel UserToViewModel(this User UserToTransform)
        {
            var UserViewModel = new UserDataViewModel();

            UserViewModel.Id = UserToTransform.Id;
            UserViewModel.Email = UserToTransform.Email;
            UserViewModel.UserName = $"{UserToTransform.Fname} {UserToTransform.Lname}";

            return UserViewModel;
        }

        public static User ViewModelToUser(this UserDataViewModel ViewModelToTransform)
        {
            var User = new User();

            User.Id = ViewModelToTransform.Id;
            User.Email = ViewModelToTransform.Email;
            User.Password = ViewModelToTransform.Password;

            return User;
        }

       
    }

}
