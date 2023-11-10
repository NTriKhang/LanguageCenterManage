using LanguageCenterManage.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageCenterManage.Services.UserService
{
    public class UserService
    {
        AppDbContext _db = new AppDbContext();
        public dynamic Login(string email, string password)
        {
            if (!_db.Users.Any(u => u.Email == email))
                return null;
            var user = _db.Users.SingleOrDefault(u => u.Email == email);
            if(user == null) 
                return null;    

            if(!BCrypt.Net.BCrypt.Verify(password, user.PasswordHash))
                return null;

            return new { UserId = user.Id, FirstName = user.FirstName, LastName = user.LastName, Email = user.Email};
        }
        public void Logout()
        {
            USER.UserId = null;
            USER.FirstName = null;
            USER.LastName = null;
            USER.Email = null;
        }
    }
}
