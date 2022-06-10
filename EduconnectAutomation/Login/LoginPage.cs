using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using SeleniumSetups.Admin;
using SeleniumSetups.Threading;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EduconnectAutomation.Login
{
    public class LoginPage
    {
        public static void LoginAsAdmin(IWebDriver driver)
        {
            SleepInterval.ShortTime();

            //Login Button
            driver.FindElement(By.ClassName("btn-outline-sm")).Click();
            SleepInterval.AverageTime();

            //Checking Validation
            driver.FindElement(By.CssSelector("[class='btn btn-block edu-btn-primary']")).Click();
            SleepInterval.AverageTime();

            //Adding data into Email and password field
            driver.FindElement(By.Id("Email")).SendKeys(AdminCredentials.Email);
            driver.FindElement(By.Id("Password")).SendKeys(AdminCredentials.Password);
            driver.FindElement(By.Id("RememberMe")).Click();
            SleepInterval.ShortTime();

            driver.FindElement(By.CssSelector("[class='btn btn-block edu-btn-primary']")).Click();
        }
    }
}
