using System;
using System.IO;

namespace OpcUaServer
{
    public class FolderCreationExample
    {
        public static void CreateAppDataFolder()
        {
            // Get the local application data folder
            string localAppData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            
            // Create a folder for your application
            string appFolder = Path.Combine(localAppData, "OpcUaServer");
            
            try
            {
                // Create the directory if it doesn't exist
                if (!Directory.Exists(appFolder))
                {
                    Directory.CreateDirectory(appFolder);
                    Console.WriteLine($"Created folder: {appFolder}");
                }
                else
                {
                    Console.WriteLine($"Folder already exists: {appFolder}");
                }
                
                // Create subfolders for certificate stores
                string[] subfolders = { "CertificateStores", "Logs", "Config" };
                foreach (string subfolder in subfolders)
                {
                    string subfolderPath = Path.Combine(appFolder, subfolder);
                    if (!Directory.Exists(subfolderPath))
                    {
                        Directory.CreateDirectory(subfolderPath);
                        Console.WriteLine($"Created subfolder: {subfolderPath}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating folder: {ex.Message}");
            }
        }
        
        public static string GetAppDataPath()
        {
            return Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), 
                "OpcUaServer"
            );
        }
    }
}