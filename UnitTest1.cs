using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCsharp1
{
    
    public class Tests
    {
        public IWebDriver Driver;
        

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Console.WriteLine("Set Up");
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            Driver.Manage().Window.Maximize();
            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Rajendra Prasad");

            Driver.Close();
            Console.WriteLine("Test");
            Assert.Pass();
        }
    }
}