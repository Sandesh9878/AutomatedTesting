using EduconnectAutomation.Login;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumSetups.Admin;
using System;
using System.IO;

namespace EduconnectAutomation
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver(path + @"\drivers\");
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl(AdminCredentials.BaseUrl);
            driver.Manage().Window.Maximize();
            LoginPage.LoginAsAdmin(driver);
            Assert.Pass();
        }
    }
}