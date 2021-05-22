using FluentAssertions;
using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;
using TestAssessment.Helpers;
using TestAssessment.Hooks;
using TestAssessment.Models;
using TestAssessment.PageObjectModels;

namespace TestAssessment.Steps
{
    [Binding]
    public class FileUploadTestsSteps
    {
        private readonly Files _filePath;
        private readonly Urls _url;
        private IWebElement _onClick;
        private IWebElement _tool;
        private IWebElement _widget;

        public FileUploadTestsSteps(IConfiguration config)
        {
            _filePath = config
                .GetSection("Files")
                .Get<Files>();
            _url = config.GetSection("Urls")
                .Get<Urls>();
            
            WebDriver.driver.Navigate().GoToUrl(_url.FileUploadUrl);
        }

        [Given(@"to choose a file from default filepath")]
        public void GivenToChooseAFileFromDefaultFilepath() => _onClick = new HomePage(WebDriver.driver).Upload;
        
        [When(@"I hover mouse over Tools section to select Upload Widget option")]
        public void WhenIHoverMouseOverToolsSectionToSelectUploadWidgetOption()
        {
            _tool = new HomePage(WebDriver.driver).Tools;
            var action = new Actions(WebDriver.driver);
            action.MoveToElement(_tool);
            _widget = new HomePage(WebDriver.driver).Widget;
            action.MoveToElement(_widget);
            action.Click().Build().Perform();

            _onClick = new WidgetUploadPage(WebDriver.driver).UploadWidget;
        }

        [When(@"I click on Upload button")]
        public void WhenIClickOnUploadButton() => _onClick.Click();

        [Then(@"file should sucessfully upload")]
        public void ThenFileShouldSucessfullyUpload()
        {
            WindowsHandler.SearchFile(_filePath.DefaultPath,_filePath.DefaultFile);
            new HomePage(WebDriver.driver).Success.Should().NotBeNull("file failed to upload.");
        }

        [Then(@"widget should sucessfully upload")]
        public void ThenWidgetShouldSucessfullyUpload()
        {
            WindowsHandler.SearchFile(_filePath.DefaultPath,_filePath.DefaultWidget);
            new WidgetUploadPage(WebDriver.driver).Success.Should().NotBeNull("file failed to upload.");
        }
    }
}