using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpPracticeProject
{
    public class Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            driver = new ChromeDriver();

        }

        [Test]
        public void Test1()
        {
            Console.WriteLine("Test1");
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            Assert.Pass();
        }
    }
}