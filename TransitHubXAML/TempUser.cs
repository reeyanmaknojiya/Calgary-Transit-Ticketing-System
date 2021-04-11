using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransitHubXAML.Models;
namespace TransitHubXAML
{
    //User for temp accounts
    public static class TempUser
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
        public static List<creditCard> creditCards { get; set; }

        public static List<debitCard> debitCards { get; set; }

        public static List<paypal> Paypal { get; set; }

        public const bool isLowIncome = false;
    }
}
