using System.Reflection;
using Microsoft.Win32;

namespace ReflectiveCode.GMinder
{
    /// <summary>
    /// Enables or disables the autostart (with the OS) of the application.
    /// </summary>
    public static class AutoStarter
    {
        private const string RUN_LOCATION = @"Software\Microsoft\Windows\CurrentVersion\Run";
        private const string APP_NAME = "GMinder";

        /// <summary>
        /// Set the autostart value for the assembly.
        /// </summary>
        private static void SetAutoStart()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RUN_LOCATION);
            key.SetValue(APP_NAME, Assembly.GetExecutingAssembly().Location);
        }

        /// <summary>
        /// Returns whether auto start is enabled.
        /// </summary>
        public static bool IsAutoStartEnabled
        {
            get
            {
                RegistryKey key = Registry.CurrentUser.OpenSubKey(RUN_LOCATION);
                if (key == null)
                    return false;

                string value = (string)key.GetValue(APP_NAME);
                if (value == null)
                    return false;
                return (value == Assembly.GetExecutingAssembly().Location);
            }
            set
            {
                if (value)
                    SetAutoStart();
                else
                    UnSetAutoStart();
            }
        }

        /// <summary>
        /// Unsets the autostart value for the assembly.
        /// </summary>
        private static void UnSetAutoStart()
        {
            RegistryKey key = Registry.CurrentUser.CreateSubKey(RUN_LOCATION);
            key.DeleteValue(APP_NAME);
        }
    }
}
