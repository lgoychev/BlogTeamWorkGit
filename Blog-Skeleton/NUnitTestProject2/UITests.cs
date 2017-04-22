using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using NUnit.Framework;
using TestStack.Seleno.Configuration;

namespace Blog.UI.Tests
{
    [TestFixture]
    public class UITests
    {
        [Test]
        public void CheckSiteLoad()
        {
            IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = BrowserHost.Instance.Application.Browser;
            driver.Navigate().GoToUrl(@"http://localhost:60634/Article/List");

            var logo = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a"));

        }
    }
}