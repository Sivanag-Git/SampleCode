using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Xunit;

namespace PhD_AUT_Project.Tests
{
    [TestClass()]
    [TestCategory("Login Tests")]
    public class LoginPageTests
    {
        private TestContext _TestInstance;
        public TestContext TestContext
        {
            get { return _TestInstance; }
            set { _TestInstance = value; }
        }

        //[TestMethod]
        //[DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=|DataDirectory|TestData.xlsx;driverid=1046;maxbuffersize=2048;pagetimeout=5", "Sheet1$", DataAccessMethod.Sequential)]
        //public void VerifyLogin()
        //{
        //    LoginPage loginPage = new LoginPage();
        //    loginPage.loginName = _TestInstance.DataRow["Username"].ToString();
        //    loginPage.password = _TestInstance.DataRow["Password"].ToString();
        //    loginPage.confirmPassword = _TestInstance.DataRow["ConfirmPassword"].ToString();
        //    Assert.AreEqual(Convert.ToInt32(_TestInstance.DataRow["PageIndex"]), (int)loginPage.Submit().currentPage);
        //}

        //[TestMethod()]
        //[DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=|DataDirectory|TestData.xlsx;driverid=1046;maxbuffersize=2048;pagetimeout=5", "Sheet1$", DataAccessMethod.Sequential)]
        //public void VerifyLoginUserName()
        //{
        //    LoginPage loginPage = new LoginPage();
        //    loginPage.loginName = _TestInstance.DataRow["Username"].ToString();
        //    loginPage.password = _TestInstance.DataRow["Password"].ToString();
        //    loginPage.confirmPassword = _TestInstance.DataRow["ConfirmPassword"].ToString();
        //    Assert.AreEqual(_TestInstance.DataRow["CurrentUsername"].ToString(), loginPage.Submit().loginUserName); 
        //}

        //[TestMethod()]
        //[DataSource("System.Data.Odbc", @"Dsn=Excel Files;dbq=|DataDirectory|TestData.xlsx;driverid=1046;maxbuffersize=2048;pagetimeout=5", "Sheet1$", DataAccessMethod.Sequential)]
        //public void VerifyLoginNavigationPageTitle()
        //{
        //    LoginPage loginPage = new LoginPage();
        //    loginPage.loginName = _TestInstance.DataRow["Username"].ToString();
        //    loginPage.password = _TestInstance.DataRow["Password"].ToString();
        //    loginPage.confirmPassword = _TestInstance.DataRow["ConfirmPassword"].ToString();
        //    Assert.AreEqual(_TestInstance.DataRow["PageTitle"].ToString(), loginPage.Submit().pageTitle);
        //}

    }
}