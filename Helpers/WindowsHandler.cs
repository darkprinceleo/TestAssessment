using OpenDialogWindowHandler;

namespace TestAssessment.Helpers
{
    /// <summary>
    ///  Members to handle Windows 
    /// </summary>
    public static class WindowsHandler
    {
        /// <summary>
        /// Open file from the windows based dialogue and popups
        /// </summary>
        /// <param name="filePath">directory of the file</param>
        /// <param name="fileName">file name with extension</param>
        public static void SearchFile(string filePath, string fileName)
        {
            var openWindowsHandle = new HandleOpenDialog();
            openWindowsHandle.fileOpenDialog(filePath, fileName);
        }
    }
}
