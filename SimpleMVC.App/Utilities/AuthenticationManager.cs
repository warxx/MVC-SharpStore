using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStore.Models;
using SimpleHttpServer.Models;
using SimpleHttpServer.Utilities;

namespace SharpStore.Utilities
{
    public class AuthenticationManager
    {
        public static User GetAuthenticatedUser(string sessionId)
        {
            var firstOrDefault = Data.Data.Context.Logins
                .FirstOrDefault(x => x.SessionId == sessionId && x.IsActive);
            if (firstOrDefault != null)
            {
                return firstOrDefault.User;
            }

            return null;
        }

        public static void Logout(string sessionId, HttpResponse response)
        {
            var firstOrDefault = Data.Data.Context.Logins
                .FirstOrDefault(x => x.SessionId == sessionId && x.IsActive);
            firstOrDefault.IsActive = false;
            Data.Data.Context.SaveChanges();
            var session = SessionCreator.Create();
            var sessionCookie = new Cookie("sessionId", session.Id);
            response.Header.AddCookie(sessionCookie);
        }
    }
}
