using System;
using Xunit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;



namespace firstTest
{
    public class Class1
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void LoadApplicationPage()
        {
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("https://politrip.com/account/sign-up");

                TestHelper.Pause();

                string pageTitle = driver.Title;

                Assert.Equal("Sign up | Politrip", pageTitle);
                Assert.Equal("https://politrip.com/account/sign-up", driver.Url);
            }

        }
    }
}
