using System;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using RiteQ.Selenium;
using SeleniumExtras.PageObjects;

namespace RiteQ.PageModels
{
    public class SharingPopUpPage
    {
        private readonly IWebDriver _driver;
        private IWebElement SharingPopUpWindowElement => WebDriverExtensions.WaitForElementToBeVisible(_driver, By.ClassName("unified-share-modal"));


        private IWebElement FolderName => WebDriverExtensions.WaitForElementToBeVisible(_driver, By.ClassName("scl-input"));
        private IWebElement EmailId => WebDriverExtensions.WaitForElementToBeVisible(_driver, By.ClassName("mc-tokenized-input-input"));
        private IWebElement ShareButton => SharingPopUpWindowElement.FindElement(By.ClassName("scl-sharing-modal-footer-inband")).FindElement(By.ClassName("mc-button-content"));

        //private IWebElement FolderName => WebDriverExtensions.WaitForElementToBeClickable(_driver, SharingPopUpWindowElement.FindElement(By.ClassName("scl-input")));
        //private IWebElement EmailId => WebDriverExtensions.WaitForElementToBeClickable(_driver, SharingPopUpWindowElement.FindElement(By.ClassName("mc-tokenized-input-input")));
        //private IWebElement ShareButton => SharingPopUpWindowElement.FindElement(By.ClassName("scl-sharing-modal-footer-inband")).FindElement(By.ClassName("mc-button-content"));



        public SharingPopUpPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }


        public void ShareFolder()
        {
            FolderName.SendKeys(GetRandomFolderName(6));
            EmailId.SendKeys("sandysomu@yahoo.com");
            ShareButton.Click();
        }


        private Random random = new Random();
        public string GetRandomFolderName(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return "Test" + new string(Enumerable.Repeat(chars, length)
                        .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
