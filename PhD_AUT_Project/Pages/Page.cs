using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhD_AUT_Project
{
    public enum PageIndex
    {
        LoginPage = 1,
        MainPage = 2
    }

    public class Page
    {
        public PageIndex currentPage { get; set; }
        public string pageTitle { get; set; }
        public string loginUserName { get; set; }
    }
}
