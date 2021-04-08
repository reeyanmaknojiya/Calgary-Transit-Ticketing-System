using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitHubXAML
{
    // static file with user variables
    public static class User
    {
        public static Boolean loggedIn { get; set; }
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static string bMonth { get; set; }
        public static string bDay { get; set; }
        public static string bYear { get; set; }
        public static string email { get; set; }
        public static string phone { get; set; }
        public static string password { get; set; }
    }
}
