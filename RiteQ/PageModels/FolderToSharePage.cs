using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using RiteQ.Selenium;
using SeleniumExtras.PageObjects;

namespace RiteQ.PageModels
{
    public class FolderToSharePage
    {
        private IWebDriver _driver;

        IWebElement NewFolderElement => WebDriverExtensions.WaitForElementToBeVisible(_driver, By.Id("new-folder"));
        IWebElement NextButtonElement => WebDriverExtensions.WaitForElementToBeVisible(_driver, By.ClassName("mc-util-modal-actions-buttons"));

        public FolderToSharePage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void SelectNewFolderAndClickNext()
        {
            NewFolderElement.Click();
            NextButtonElement.Click();
        }

    }
}
