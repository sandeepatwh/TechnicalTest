using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.CompilerServices;

namespace RiteQ.Helper
{
    public class AppSettings
    {
        public string Email => InitConfiguration()["email"];
        public string BaseUrl => InitConfiguration()["baseUrl"];
        public string Password => InitConfiguration()["password"];
        public string EmailIdToShareWith => InitConfiguration()["emailIdToShareWith"];

        public IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            Debug.WriteLine(config["email"]);
            return config;
        }

    }
}
