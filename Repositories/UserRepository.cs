
using System.Collections.Generic;
using System.Linq;
using WebApiPeople.Models;

namespace WebApiPeople.Repositories
{
    public static class UserRepository
    {
        public static UserViewModel Get(string email, string password)
        {
            var users = new List<UserViewModel>();
            users.Add(new UserViewModel { Id = 1, Email = "flavio@flavio.com", Password = "123456"});

            return users.Where(x => x.Email.ToLower() == email.ToLower() && x.Password == password).FirstOrDefault();
        }
    }
}