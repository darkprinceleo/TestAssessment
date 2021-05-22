using OpenQA.Selenium;

namespace TestAssessment.Models
{
    /// <summary>
    /// Page Object Model Class for HomePage - FileUpload
    /// </summary>
    public class HomePage
    {   
        private readonly IWebDriver driver;
        public HomePage(IWebDriver webdriver) => driver = webdriver;

        public IWebElement Upload => driver.FindElement(By.Id("upload-window"));
        public IWebElement Success => driver.FindElement(By.ClassName("success_message"));

        public IWebElement Tools => driver.FindElement(By.ClassName("dropdown__trigger"));
        public IWebElement Widget => 
            driver.FindElement(
                By.CssSelector("#menu2 > div > div > div.col-md-7.order-lg-1 > div > ul > li.dropdown.dropdown--hover.hidden-sm > div > div > ul > li:nth-child(2) > a > span")
                );
    }
}