using OpenQA.Selenium;
using RiteQ.Helper;
using RiteQ.Selenium;
using SeleniumExtras.PageObjects;

namespace RiteQ.PageModels
{
   public class LandingPage
    {

        private readonly IWebDriver _driver;

        private IWebElement SignInLink => WebDriverExtensions.WaitForElementToBeVisible(_driver, By.Id("sign-up-in"));
        private IWebElement EmailTextBox => WebDriverExtensions.WaitForElementToBeVisible(_driver, By.Name("login_email"));
        private IWebElement PasswordTextBox => WebDriverExtensions.WaitForElementToBeVisible(_driver, By.Name("login_password"));
        private IWebElement SubmitButton => _driver.FindElement(By.ClassName("login-button"));
      

        public LandingPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        

        public void GoToHomePage()
        {
            var config = Utils.InitConfiguration();

            _driver.Navigate().GoToUrl("https://www.dropbox.com/");

            SignInLink.Click();

            EmailTextBox.SendKeys("sandeepatwh@gmail.com");

            PasswordTextBox.SendKeys("Password123");

            SubmitButton.Click();
            
        }

       
    }
}
