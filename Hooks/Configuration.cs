using BoDi;
using Microsoft.Extensions.Configuration;
using TechTalk.SpecFlow;

namespace TestAssessment.Hooks
{
    /// <summary>
    ///  Build and register configuration file appsettings.json
    /// </summary>
    [Binding]
    public class Configuration
    {
        private static IObjectContainer _objectContainer;
        private static IConfigurationRoot _config;

        public Configuration(IObjectContainer objectContainer) => _objectContainer = objectContainer;

        [BeforeTestRun]
        public static void ConfigurationSetup() => _config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        [BeforeScenario(Order = 1)]
        public void Register() => _objectContainer.RegisterInstanceAs<IConfiguration>(_config);
    }
}