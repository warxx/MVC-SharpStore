using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.BindingModels;
using SharpStore.Data;
using SharpStore.Models;

namespace SharpStore.Services
{
    public class LoginService : Service
    {
        public LoginService(SharpStoreContext context) : base(context)
        {
        }

        public User GetCorrespondingUser(LoginUserBindingModel model)
        {
            var user = Data.Data.Context.Users
                .FirstOrDefault(x => x.Username == model.Username
                                     && x.Password == model.Password);
            return user;
        }

        public void LoginUser(string sessionId, User user)
        {
            var login = new Login()
            {
                SessionId = sessionId,
                User = user,
                IsActive = true
            };

            context.Logins.Add(login);
            context.SaveChanges();
        }
    }
}
