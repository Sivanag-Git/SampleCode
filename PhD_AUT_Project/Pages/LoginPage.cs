using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PhD_AUT_Project
{
    public class LoginPage:Page
    {
        public LoginPage()
        {
            currentPage = PageIndex.LoginPage;
            pageTitle = "Login";
            loginUserName = "";
        }

        public string loginName { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }
        public Page Submit()
        {
            if(loginName.Contains("User") && password.Contains("pwd"))
            {
                if (password == confirmPassword)
                {
                    return new MainPage(loginName);
                }
            }
            return this;
        }

        public PageIndex Cancel()
        {
            loginName = "";
            password = "";
            return currentPage;
        }
    }
}
