using System.ComponentModel;
using System.Diagnostics;
using AutoItX3Lib;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using RiteQ.PageModels;
using RiteQ.Selenium;

namespace Tests
{
    public class LoginTests
    {
        private FolderPage _folderPage;
        private LandingPage _landingPage;
        private readonly SharingPopUpPage _sharingPopUpPage;
        private HomePage _homePage;
        private FolderToSharePage _folderToSharePagePage;

        IWebDriver _driver = Browser.Driver;

      

        public LoginTests()
        {



             _folderPage = new FolderPage(_driver);
             _landingPage = new LandingPage(_driver);
             _sharingPopUpPage = new SharingPopUpPage(_driver);
             _homePage = new HomePage(_driver);
             _folderToSharePagePage = new FolderToSharePage(_driver);

           

        }
        
      
        [Test]
        public void Test1()
        {

            _landingPage.GoToHomePage();
          _homePage.IsAtHomePage().CreateAndShareNewFolder();
          _folderToSharePagePage.SelectNewFolderAndClickNext();
          _sharingPopUpPage.ShareFolder();
          _folderPage.UploadFiles();
        }
    }
}