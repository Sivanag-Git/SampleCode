using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhD_AUT_Project
{
    public class MainPage:Page
    {
        public bool mainMenu { get; set; }
        public string searchText { get; set; }
        public bool searchButton { get; set; }
        public bool cartButton { get; set; }
        public bool todaysDealsDashboard { get; set; }
        public bool ordersLink { get; set; }
        public bool customerServiceLink { get; set; }
        public bool rewardsLink { get; set; }
        public bool electronicsProductsDashboard { get; set; }
        public bool homeProductsDashboard { get; set; }
        public bool computerProductsDashboard { get; set; }
        public bool mensProductsDashboard { get; set; }
        public bool womensProductsDashboard { get; set; }

        public MainPage(string userName)
        {
            currentPage = PageIndex.MainPage;
            loginUserName = userName;
            pageTitle = "Main";
        }

        public void NavigateToProductPage(string category)
        {
            switch(category)
            {
                case "Electronics":
                    electronicsProductsDashboard = true;
                    break;
                case "Home":
                    homeProductsDashboard = true;
                    break;
                case "Computer":
                    computerProductsDashboard = true;
                    break;
                case "Men":
                    mensProductsDashboard = true;
                    break;
                case "Women":
                    womensProductsDashboard = true;
                    break;
            }
        }
    }
}
