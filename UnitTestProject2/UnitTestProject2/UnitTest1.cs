using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        static IWebDriver driver;
        [AssemblyInitialize]
        public static void CallChrome(TestContext context)
        {
            driver = new ChromeDriver(@"D:\old\Епам\chromedriver_win32");
            driver.Manage();
        }
        [TestMethod]
        public void TestMethod1()
        {
            driver.Navigate().GoToUrl("http://github.com");
            driver.FindElement(By.LinkText("Sign in")).Click();
            driver.FindElement(By.Id("login_field")).SendKeys("Latyshkina");
            driver.FindElement(By.Id("password")).SendKeys("Latyshkina");
            driver.FindElement(By.Name("commit")).Click();
        }
    }
}
