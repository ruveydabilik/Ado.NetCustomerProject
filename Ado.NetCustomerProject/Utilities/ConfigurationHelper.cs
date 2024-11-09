using System;
using System.Configuration;

namespace Ado.NetCustomerProject.Utilities
{
    public static class ConfigurationHelper
    {
        // We create a static field to hold the connection string.
        public static readonly string ConnectionString;

        static ConfigurationHelper()
        {
            try
            {
                var configFileMap = new ExeConfigurationFileMap { ExeConfigFilename = "connection.config" };
                var config = ConfigurationManager.OpenMappedExeConfiguration(configFileMap, ConfigurationUserLevel.None);
                ConnectionString = config.ConnectionStrings.ConnectionStrings["MyDatabase"]?.ConnectionString;

                if (ConnectionString == null)
                {
                    throw new Exception("Connection string 'MyDatabase' bulunamadı.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                throw; // If you want to continue throwing the error and see where it occurs
            }
        }
    }
}
