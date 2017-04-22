using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnitTestProject1
{
    [TestFixture]
    public class IntegrationTests
    {
        [Test]
        public void TestLoadTest2()

        {
            {
                IWebDriver driver = new ChromeDriver();
                //IWebDriver driver = BrowserHost.Instance.Application.Browser;
                driver.Navigate().GoToUrl(@"http://localhost:60634/");

                var logo = driver.FindElement(By.XPath("/html/body/div[1]/div/div[1]/a"));

            }

        }
    }
}