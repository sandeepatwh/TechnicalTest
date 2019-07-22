using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using RiteQ.Selenium;
using SeleniumExtras.PageObjects;

namespace RiteQ.PageModels
{
    public class HomePage
    {
        private readonly IWebDriver _driver;
        IWebElement AppActionsMenu => _driver.FindElement(By.ClassName("appactions-menu--buttons"));
        ReadOnlyCollection<IWebElement> SideBarMenuItems => AppActionsMenu
                         .FindElement(By.ClassName("mc-tertiary-list"))
                         .FindElements(By.ClassName("mc-tertiary-list-element"));
        private IWebElement HomePageHeadingElement => WebDriverExtensions
            .WaitForElementToBeVisible(_driver, By.ClassName("page-header__heading"));



        public HomePage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public HomePage IsAtHomePage()
        {

            Assert.True(HomePageHeadingElement.Text.Equals("Home"));
            return this;
        }
        public void CreateAndShareNewFolder()
        {
            SideBarMenuItems[2].Click();
        }



    }
}
