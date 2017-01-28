using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webb4_DAL.ModelsV2;

namespace Webb4_DAL
{
    public class TestRepo
    {
        public User Login(string Email, string password)
        {
            using (var ctx = new Webb4Context())
            {
                var userToLogin = ctx.Users.Where(x => x.Email == Email && x.Password == password).FirstOrDefault();
                return userToLogin;
            }
            
        }
        public void RegisterUser(User UserToRegister)
        {
            using (var ctx = new Webb4Context())
            {
                ctx.Users.Add(UserToRegister);
                ctx.SaveChanges();
            }
        }
    }
}
