using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace RiteQ.Selenium
{
   public class WebDriverExtensions
    {
        public static IWebElement WaitForElementToBeClickable(IWebDriver driver, IWebElement element)
        {
            return new WebDriverWait(driver, TimeSpan.FromMilliseconds(20000))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                .ElementToBeClickable(element));
        }

        public static IWebElement WaitForElementToBeVisible(IWebDriver driver, By element)
        {
            return new WebDriverWait(driver, TimeSpan.FromMilliseconds(20000))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                    .ElementIsVisible(element));
        }


        public static IWebElement WaitForElementToExist(IWebDriver driver, By element)
        {
            return new WebDriverWait(driver, TimeSpan.FromMilliseconds(20000))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                    .ElementExists(element));
        }

        public static IWebElement WaitForElementToBeClickable(IWebDriver driver, By element)
        {
            return new WebDriverWait(driver, TimeSpan.FromMilliseconds(20000))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                    .ElementToBeClickable(element));
        }






    }
}
