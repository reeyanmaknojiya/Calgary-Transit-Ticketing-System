using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitHubXAML.Models
{
    public class creditCard
    {
        string cardHolderName { get; set; }

        long cardNumber { get; set; }

        short exprDay { get; set; }

        int exprYear { get; set; }

        int cvv { get; set; }

        string zipcode { get; set; }


    }
}
