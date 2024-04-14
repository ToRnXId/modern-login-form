using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace modern_login_form.Models
{
    public interface IUserRepository
    {
        bool AuthentificateUser(NetworkCredential credential);
        void Add(UserModel userModel);
        void Edit(UserModel userModel);
        void Remove(int id);
        UserModel GetById(int id);
        UserModel GetByUserName(string userName);
        IEnumerable<UserModel> GetAll();
        // ...
    }
}
