/// Copyright (c) 2009, Greg Todd
/// All rights reserved.
///
/// Redistribution and use in source and binary forms, with or without modification,
/// are permitted provided that the following conditions are met:
/// 
/// * Redistributions of source code must retain the above copyright notice,
///   this list of conditions and the following disclaimer.
///   
/// * Redistributions in binary form must reproduce the above copyright notice,
///   this list of conditions and the following disclaimer in the documentation
///   and/or other materials provided with the distribution.
///   
/// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
/// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
/// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
/// IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT,
/// INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING,
/// BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
/// DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
/// LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE
/// OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED
/// OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Text;
using System.Windows.Forms;

namespace ReflectiveCode.GMinder
{
    /// <summary>
    /// Provides logging services
    /// </summary>
    public static class Logging
    {
        private const string ERROR_LOG = "ErrorLog.txt";

        public static void LogException(bool alert, Exception e, params string[] details)
        {
            // Prepare to write to the error log file
            var logMessage = new StringBuilder();

            // Prepare the timestamp
            string prefix = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss - ");

            // Write each detail
            foreach (string detail in details)
            {
                logMessage.Append(prefix);
                logMessage.AppendLine(detail);
                prefix = "                      ";
            }

            // Write exception message
            logMessage.Append(prefix);
            logMessage.AppendLine(e.Message);

            // Open the log file for writing
            Storage.AppendText(ERROR_LOG, logMessage.ToString());

            // Display a message box if requested
            if (alert) 
                DisplayAlert(e, details);
        }

        private static void DisplayAlert(Exception e, string[] details)
        {
            var errorMessage = new StringBuilder();

            // Write each detail
            foreach (string detail in details)
                errorMessage.AppendLine(detail);

            // Write exception message
            errorMessage.AppendLine();
            errorMessage.AppendLine("Exception:");
            errorMessage.AppendLine(e.Message);

            // Display alert
            MessageBox.Show(
                errorMessage.ToString(),
                "Exception in GMinder",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            );
        }
    }
}