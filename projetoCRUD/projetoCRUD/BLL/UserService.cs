using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using projetoCRUD.DAL;
using projetoCRUD.Models;

namespace projetoCRUD.BLL
{
    internal class UserService
    {
        private readonly UserDAL _userDAL = new UserDAL();

        public User Login(string login, string senha)
        {
            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(senha))
            {
                throw new ArgumentException("Login and password cannot be empty.");
            }
            var user = _userDAL.Login(login, senha);
            if (user == null)
            {
                throw new UnauthorizedAccessException("Invalid login or password.");
            }
            return user;
        }
    }
}
