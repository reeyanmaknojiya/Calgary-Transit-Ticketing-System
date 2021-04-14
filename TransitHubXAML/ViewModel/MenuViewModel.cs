using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitHubXAML.ViewModel
{
    class MenuViewModel
    {
        // Reference: https://www.youtube.com/watch?v=EedNnnzyQLw
        // list for menu items
        public List<MenuItemsData> MenuList
        {
            get
            {
                return new List<MenuItemsData>
                {
                    new MenuItemsData() { MenuText="Which mobile devices can run this app?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="The application is available for iOS and Andriod \r\ndevices." }}
                    },

                    new MenuItemsData() { MenuText="What type of fares are available for purchase?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="The tickets (Adult, Youth), montlhy pass (Adult, \r\nYouth), special pass (Seniors, Low-Income for \r\nAdult, Senior, and Youth)" }}
                    },

                    new MenuItemsData() { MenuText="How do I update my user information?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Select Account on the navigation bar at the \r\nbottom then select Account. Select the information \r\nyou want to edit and select Save Changes." }}
                    },

                    new MenuItemsData() { MenuText="How do I update my password?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Select Account on the navigation bar at the \r\nbottom then select Account. Once in Account, \r\nselect Password. Enter your new password and \r\nselect Update." }}
                    },

                    new MenuItemsData() { MenuText="How do I vertify my account to purchase special passes?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Select Account on the navigation bar at the \r\nbottom then select Vertification. Enter your given \r\nregisteration number from Calgary Transit. Either \r\ntake a picture of your identification card or upload \r\na picture of your identification card from your \r\nmobile phone's gallery. Select Save Changes." }}
                    },

                    new MenuItemsData() { MenuText="What forms of payment can I use?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="TransitHub accepts credit cards (MasterCard and \r\nVisa), pre-paid credit cards, Apple Pay, and PayPal." }}
                    },

                    new MenuItemsData() { MenuText="How do I update my payment information?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Select Account on the navigation bar at the \r\nbottom then select Payment Information. To \r\nremove your current payment method(s), select \r\nSaved Cards then the payment method you would \r\nlike to remove by selecting 'Yes'. To add a card to \r\nyour account, select Add Card." }}
                    },

                    new MenuItemsData() { MenuText="Are receipts avaliable for my purchases?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Yes. You will automatically recieve an email for \r\nyour purchase. But you can also view your recepits \r\non the app. Select Account on the navigation bar \r\nat the bottom then select Purchase History." }}
                    },

                    new MenuItemsData() { MenuText="Can I refund a purchased ticket or pass?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="The refund policy follows the Calgary Transit \r\nguidelines. The refund policy states that the \r\nCalgary Transit do not offer refunds on any fare \r\nproducts." }}
                    },

                    //Reference: https://www.calgarytransit.com/content/transit/en/home/fares---passes/my-fare.html 
                    new MenuItemsData() { MenuText="Do my tickets or passes expire?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Each single ticket is valid for seven days from date \r\nof activation. Monthly passes are only valid for the \r\nmonth purchased." }}
                    },

                    new MenuItemsData() { MenuText="How do I activate my ticket or pass?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Your ticket or pass will automatically activate when \r\nscanned." }}
                    },

                    new MenuItemsData() { MenuText="How do I display my ticket?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Select My Tickets at the bottom of the navigation \r\nbar and tap on the fare you would like to use." }}
                    },
                };
            }
        }
    }
    public class MenuItemsData
    {
        public string MenuText { get; set; }

        public List<SubMenuItemsData> SubMenuList { get; set; }
    }

    public class SubMenuItemsData
    {
        public string SubMenuText { get; set; }
    }
}
