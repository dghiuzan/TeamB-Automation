using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Team_B.Pages
{
    class Login
    {
        private IWebDriver driver;
        private IWebElement BtnSubmit { get; set; }
        private IWebElement TxtPassword { get; set; }
        private IWebElement TxtUserName { get; set; }

        public Login(IWebDriver driver)
        {
            this.driver = driver;

            TxtUserName = this.driver.FindElement(By.CssSelector("#formInputUsername"));
            TxtPassword = this.driver.FindElement(By.Name("password"));
            BtnSubmit = this.driver.FindElement(By.ClassName("btn btn-action-custom inverted"));
        }
    }
}
