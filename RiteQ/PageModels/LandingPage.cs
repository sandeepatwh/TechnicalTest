using OpenQA.Selenium;
using RiteQ.Helper;
using RiteQ.Selenium;
using SeleniumExtras.PageObjects;

namespace RiteQ.PageModels
{
    public class LandingPage
    {

        private readonly IWebDriver _driver;
        readonly AppSettings _appSettings = new AppSettings();

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
            _driver.Navigate().GoToUrl(_appSettings.BaseUrl);

            SignInLink.Click();

            EmailTextBox.SendKeys(_appSettings.Email);

            PasswordTextBox.SendKeys(_appSettings.Password);

            SubmitButton.Click();
        }


    }
}
