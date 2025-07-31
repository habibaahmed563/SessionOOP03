using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionOOP03
{
    internal class BasicAuthenticationService : IAuthenticationService
    {
        public string storedUsername = "user";
        public string storedPassword = "password";
        public string storedRole = "admin";

        public bool AuthenticateUser(string username, string password)
        {
            return username == storedUsername && password == storedPassword;
        }

        public bool AuthorizeUser(string username, string role)
        {
            return username == storedUsername && role == storedRole;
        }
    }
}
