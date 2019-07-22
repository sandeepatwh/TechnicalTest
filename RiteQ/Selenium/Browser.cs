using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace RiteQ.Selenium
{
   public class Browser
    {

        public static IWebDriver Driver => GetDriver();

   
        public static IWebDriver GetDriver()
        {
            return new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

        }


    }
}
