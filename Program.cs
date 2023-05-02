using PNGTuber.Services;

namespace PNGTuber
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "PNGTuberSettings.json");
            if (File.Exists(path))
            {
                if (LocalStorageManager.LoadConfig())
                {
                    Application.Run(new Form1());
                }
                else
                {
                    Application.Run(new Configuration());
                }
            }
            else
            {
                Application.Run(new Configuration());
            }
        }
    }
}