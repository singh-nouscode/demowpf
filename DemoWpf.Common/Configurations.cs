using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWpf.Common
{
    public static class Configurations
    {
        private static IConfigurationRoot _config;
        private static IConfigurationRoot Config
        {
            get
            {
                return GetConfig();
            }
        }

        #region Private Methods
        private static void SetConfig()
        {
            var configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddXmlFile("appsettings.xml", optional: true, reloadOnChange: true);

            _config = configurationBuilder.Build();
        }

        private static IConfigurationRoot GetConfig()
        {
            if (_config == null)
            {
                SetConfig();
            }
            return _config;
        }
        #endregion

        #region Public Methods
        public static string GetConnectionString(string name)
        {
            return Config.GetConnectionString(name);
        }

        /// <summary>
        /// Extracts the value with the specified key and converts it to type T.
        /// </summary>
        /// <typeparam name="T">The type to convert the value to.</typeparam>
        /// <param name="key">The key of the configuration section's value to convert.</param>
        /// <returns>The converted value.</returns>
        public static T GetValue<T>(string key)
        {
            return Config.GetValue<T>($"appSettings:{key}");
        }

        /// <summary>
        /// Extracts the value with the specified key and converts it to type T.
        /// </summary>
        /// <typeparam name="T">The type to convert the value to.</typeparam>
        /// <param name="key">The key of the configuration section's value to convert.</param>
        /// <param name="defaultValue">The default value to use if no value is found.</param>
        /// <returns>The converted value.</returns>
        public static T GetValue<T>(string key, T defaultValue)
        {
            return Config.GetValue<T>($"appSettings:{key}", defaultValue);
        }

        /// <summary>
        /// Extracts the value with the specified key and converts it to the specified type.
        /// </summary>
        /// <param name="type">The type to convert the value to.</param>
        /// <param name="key">The key of the configuration section's value to convert.</param>
        /// <returns>The converted value.</returns>
        public static object GetValue(Type type, string key)
        {
            return Config.GetValue(type, $"appSettings:{key}");
        }

        /// <summary>
        /// Extracts the value with the specified key and converts it to the specified type.
        /// </summary>
        /// <param name="type">The type to convert the value to.</param>
        /// <param name="key">The key of the configuration section's value to convert.</param>
        /// <param name="defaultValue">The default value to use if no value is found.</param>
        /// <returns>The converted value.</returns>
        public static object GetValue(Type type, string key, object defaultValue)
        {
            return Config.GetValue(type, $"appSettings:{key}", defaultValue);
        }
        #endregion

    }
}
