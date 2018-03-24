using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Flipkart_Automation
{
    [TestClass]
    public class TestHome
    {
        IWebDriver browseFlipkart;
        string urlFlipkart;
        IWebElement searchInputBox;
        [TestInitialize]
        public void TestInit()
        {
            urlFlipkart = "https://www.flipkart.com";
            browseFlipkart = new ChromeDriver();
        }
        [TestMethod]
        public void CheckHome()
        {
            browseFlipkart.Navigate().GoToUrl(urlFlipkart);
            searchInputBox = browseFlipkart.FindElement(By.XPath("//*[@id=\"container\"]/div/header/div[1]/div[2]/div/div/div[2]/form/div/div[1]/div/input"));
            searchInputBox.SendKeys("Saree"+Keys.Enter);
        }
        [TestCleanup]
        public void CloseTest()
        {

        }
    }
}