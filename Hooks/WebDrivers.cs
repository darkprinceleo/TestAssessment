using OpenQA.Selenium.Edge;
using TechTalk.SpecFlow;

namespace TestAssessment.Hooks
{
    [Binding]
    public static class WebDriver
    {
        public static EdgeDriver driver;   
        
        /// <summary>
        /// Opens an Edge browser
        /// </summary>
        /// <returns></returns>
        [BeforeScenario]
        public static EdgeDriver OpenBrowser()
        {
            driver = new OpenQA.Selenium.Edge.EdgeDriver(@"D:\drivers"); 
            return driver;
        }

        /// <summary>
        /// Quits Edge browser
        /// </summary>
        [AfterScenario]
        public static void QuitBrowser() => driver.Quit();
    }
}
