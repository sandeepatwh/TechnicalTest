using System.Diagnostics;
using System.IO;
using System.Reflection;
using NUnit.Framework;
using OpenQA.Selenium;
using RiteQ.PageModels;
using RiteQ.Selenium;

namespace RiteQ.Tests
{
    public class LoginTests
    {
        private readonly FolderPage _folderPage;
        private readonly LandingPage _landingPage;
        private readonly SharingPopUpPage _sharingPopUpPage;
        private readonly HomePage _homePage;
        private readonly FolderToSharePage _folderToSharePagePage;
        readonly IWebDriver _driver = Browser.Driver;

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