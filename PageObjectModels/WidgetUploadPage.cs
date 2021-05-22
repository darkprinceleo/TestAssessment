using OpenQA.Selenium;

namespace TestAssessment.Models
{
    /// <summary>
    /// Page Object Model Class for Widget - WidgetUpload
    /// </summary>
    public class WidgetUploadPage
    {   
        private readonly IWebDriver driver;
        public WidgetUploadPage(IWebDriver webdriver) => driver = webdriver;

        public IWebElement UploadWidget => driver.FindElement(By.CssSelector("#uf-dropzone > div > span"));
        public IWebElement Success => driver.FindElement(By.ClassName("dz-success-mark"));
    }
}