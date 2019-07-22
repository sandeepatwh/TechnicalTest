using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using RiteQ.Selenium;
using SeleniumExtras.PageObjects;
using AutoItX3Lib;


namespace RiteQ.PageModels
{
    public class FolderPage
    {
        private readonly IWebDriver _driver;
        private readonly AutoItX3 _autoIt = new AutoItX3Class();
        private IWebElement AppActionsMenu => WebDriverExtensions.WaitForElementToBeVisible(_driver, By.ClassName("appactions-menu--buttons"));//c-avatar--circle
        private IWebElement AvatarPhoto => WebDriverExtensions.WaitForElementToExist(_driver, By.ClassName("c-avatar--circle"));
        private IWebElement HeaderText => WebDriverExtensions.WaitForElementToBeVisible(_driver, By.ClassName("page-header-text"));
        private IWebElement BrowseFile => AppActionsMenu.FindElement(By.ClassName("mc-tertiary-link-button-content")).FindElement(By.ClassName("ue-effect-container"));

        public FolderPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void UploadFiles()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", AvatarPhoto);
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", BrowseFile);

            HeaderText.Click();

            for (int i = 1; i <= 2; i++)
            {
                BrowseFile.Click();
                string fileName = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName +
                                  "\\Data\\TestFile" + i + ".txt";
                _autoIt.WinWaitActive("Open");
                _autoIt.ControlFocus("Open", "", "Edit1");
                _autoIt.ControlSetText("Open", "", "Edit1", fileName);
                _autoIt.ControlClick("Open", "", "Button1");
                Thread.Sleep(5000);
                WebDriverExtensions.WaitForElementToBeVisible(_driver, By.ClassName("brws-checkbox"));
                _driver.Navigate().Refresh();
            }


        }
    }
}
