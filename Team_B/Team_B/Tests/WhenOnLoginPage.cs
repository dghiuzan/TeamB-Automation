using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Team_B.Pages;

namespace Team_B.Tests
{
    class WhenOnLoginPage
    {
        [SetUp]
        public void BeforeAll()
        {

            driver.Url = "http://enews/enews-test/#/login";
            driver.Manage().Window.Maximize();
        }

        private Login LoginPage;
        private IWebDriver driver = new ChromeDriver(Path.GetDirectoryName("C:\\Users\\dghiuzan\\Downloads\\"));

        [Test]
        public void ShouldLoginAndDisplayDashboardPage()
        {
            LoginPage = new Login(driver);
        }

        [TearDown]
        public void AfterAll()
        {
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}

