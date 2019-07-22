using System;
using System.Collections.Generic;
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
        readonly AutoItX3 _autoIt = new AutoItX3Class();

        private IWebElement AppActionsMenu => WebDriverExtensions.WaitForElementToBeVisible(_driver, By.ClassName("appactions-menu--buttons"));

        private IWebElement HeaderText =>
            WebDriverExtensions.WaitForElementToBeVisible(_driver, By.ClassName("page-header-text"));
        private IWebElement BrowseFile => AppActionsMenu.FindElement(By.ClassName("mc-tertiary-link-button-content")).FindElement(By.ClassName("ue-effect-container"));

        

        public FolderPage(IWebDriver driver)
        {
            this._driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void UploadFiles()
        {
            ((IJavaScriptExecutor)_driver).ExecuteScript("arguments[0].scrollIntoView(true);", BrowseFile);
             HeaderText.Click();
             BrowseFile.Click();
            
             _autoIt.WinWaitActive("Open");
             _autoIt.ControlFocus("Open", "", "Edit1");
             _autoIt.ControlSetText("Open", "", "Edit1", "C:\\Users\\ashuc\\Downloads\\cvpart.txt");
             _autoIt.ControlClick("Open", "", "Button1");
        }
    }}
