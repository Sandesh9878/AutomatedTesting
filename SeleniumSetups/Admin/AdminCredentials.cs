using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSetups.Admin
{
    public class AdminCredentials
    {
        private static string baseUrl = "http://192.168.1.11:8085/";
        private static string email = "admin@educonnect.com";
        private static string password = "P@ssw0rd";
        public static string Email { get { return email; } set { email = value; } }
        public static string Password { get { return password; } set { password = value; } }
        public static string BaseUrl { get { return baseUrl; } set { baseUrl = value; } }

    }
}
