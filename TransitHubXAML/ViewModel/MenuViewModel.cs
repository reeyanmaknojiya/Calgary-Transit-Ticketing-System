using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransitHubXAML.ViewModel
{
    class MenuViewModel
    {
        // list for menu items
        public List<MenuItemsData> MenuList
        {
            get
            {
                return new List<MenuItemsData>
                {
                    new MenuItemsData() { MenuText="Which mobile devices can run this app?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="The application is available for iOS and Andriod devices." }}
                    },

                    new MenuItemsData() { MenuText="What type of fares are available for purchase?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="The tickets (Adult, Youth), montlhy pass (Adult, Youth), special \r\n pass (Seniors, Low-Income for Adult, Senior, and Youth)" }}
                    },

                    new MenuItemsData() { MenuText="How do I update my user information?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Select Account on the navigation bar at the bottom then select Account. Select the information you want to edit and select Save Changes." }}
                    },

                    new MenuItemsData() { MenuText="How do I update my password?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Select Account on the navigation bar at the bottom then select Account. Once in Account and select Password. Enter your new password and select Update." }}
                    },

                    new MenuItemsData() { MenuText="How do I vertify my account to purchase special passes?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Select Account on the navigation bar at the bottom then select Vertification. Enter your given registeration number from Calgary Transit. Either take a picture of your identification card or upload a picture of your identification card from your mobile phone's gallery. Select Save Changes." }}
                    },

                    new MenuItemsData() { MenuText="What forms of payment can I use?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="TransitHub accepts credit cards (MasterCard and Visa), pre-paid credit cards, Apple Pay, and PayPal." }}
                    },

                    new MenuItemsData() { MenuText="How do I update my payment information?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Select Account on the navigation bar at the bottom then select Payment Information. To remove your current payment method(s), select Saved Cards then the payment method you would like to remove by selecting Yes. To add a card to your account, select Add Card." }}
                    },

                    new MenuItemsData() { MenuText="Are receipts avaliable for my purchases?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Yes. You will automatically recieve an email for your purchase. But you can also view your recepits on the app. Select Account on the navigation bar at the bottom then select Purchase History." }}
                    },

                    new MenuItemsData() { MenuText="Can I refund a purchased ticket or pass?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="The refund policy follows the Calgary Transit guidelines. The refund policy states that the Calgary Transit do not offer refunds on any fare products." }}
                    },

                    new MenuItemsData() { MenuText="How do I know when my ticket or pass will expire?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="<EMPTY>" }}
                    },

                    new MenuItemsData() { MenuText="How do I activate my ticket or pass?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Your ticket or pass will automatically activate when scanned." }}
                    },

                    new MenuItemsData() { MenuText="How do I display my ticket?",

                        SubMenuList = new List<SubMenuItemsData> {
                            new SubMenuItemsData(){ SubMenuText="Select My Tickets at the bottom of the navigation bar and tap on the fare you would like to use." }}
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
