
using Xunit;

namespace PhD_AUT_Project.Tests
{
    [Trait("Category", "Login Tests")]
    public class LoginPageTests
    {
        [Theory]
        [ExcelData("TestData.xlsx", "select * from [Sheet1$]")]
        public void VerifyLogin(string username, string password, string confirmPassword, int PageIndex, string pageTitle, string currentUsername)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.loginName = username;
            loginPage.password = password;
            loginPage.confirmPassword = confirmPassword;
            Assert.Equal(PageIndex, (int)loginPage.Submit().currentPage);
        }

        [Theory]
        [ExcelData("TestData.xlsx", "select * from [Sheet1$]")]
        public void VerifyLoginUserName(string username, string password, string confirmPassword, int PageIndex, string pageTitle, string currentUsername)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.loginName = username;
            loginPage.password = password;
            loginPage.confirmPassword = confirmPassword;
            Assert.Equal(currentUsername, loginPage.Submit().loginUserName);
        }

        [Theory]
        [ExcelData("TestData.xlsx", "select * from [Sheet1$]")]
        public void VerifyLoginNavigationPageTitle(string username, string password, string confirmPassword, int PageIndex, string pageTitle, string currentUsername)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.loginName = username;
            loginPage.password = password;
            loginPage.confirmPassword = confirmPassword;
            Assert.Equal(pageTitle, loginPage.Submit().pageTitle);
        }

        public void TestGH()
        {
            Assert.Equal(2, 1);
        }

        public void TestVS()
        {
            Assert.Equal(1, 2);
        }
    }
}
