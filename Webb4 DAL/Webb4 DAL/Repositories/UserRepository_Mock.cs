using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webb4_DAL.Models;

namespace Webb4_DAL.Repositories
{
    class UserRepository_Mock : IUserRepository
    {
        public void AddAppartmentToUserViewList(Guid appartmentId)
        {
            throw new NotImplementedException();
        }

        public void AddNewUser(UserDataModel newUser)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(Guid UserId)
        {
            throw new NotImplementedException();
        }

        public UserDataModel GetUserById()
        {
            throw new NotImplementedException();
        }

        public void UpdateUserAdess(AdressDataModel newAdress)
        {
            throw new NotImplementedException();
        }

        public UserDataModel ValidateLogin(string userName, string passWord)
        {
            throw new NotImplementedException();
        }
    }
}
