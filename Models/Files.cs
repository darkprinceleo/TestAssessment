namespace TestAssessment.PageObjectModels
{
    /// <summary>
    /// Configuration POCO for file path and file names 
    /// Reads test file from the appsettings.JSON file
    /// </summary>
    public class Files
    {
        public string DefaultPath { get; set; }
        public string DefaultFile { get; set; }
        public string DefaultWidget { get; set; }
    }
}
