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

/// Adapted from an example
/// http://pluralsight.com/wiki/default.aspx/Keith.GuideBook.HowToStoreSecretsOnAMachine

using System;
using System.Security.Cryptography;
using System.Text;

namespace ReflectiveCode.GMinder
{
    /// <summary>
    /// Provides simple cryptographic methods
    /// </summary>
    static class Encryption
    {
        /// <summary>
        /// The salt used with encoding and decoding
        /// </summary>
        private const string applicationEntropy = "b6M95WKKLu7hdVYI";

        /// <summary>
        /// Encrypt a string for the current user
        /// </summary>
        /// <param name="plaintext">text to encrypt</param>
        /// <returns>encrypted text encoded in base64</returns>
        internal static string Encrypt(string plaintext)
        {
            byte[] encodedPlaintext = Encoding.UTF8.GetBytes(plaintext);
            byte[] encodedEntropy = Encoding.UTF8.GetBytes(applicationEntropy);

            byte[] ciphertext = ProtectedData.Protect(
                encodedPlaintext,
                encodedEntropy,
                DataProtectionScope.CurrentUser
            );

            return Convert.ToBase64String(ciphertext);
        }

        /// <summary>
        /// Decrypt a string for the current user
        /// </summary>
        /// <param name="base64Ciphertext">encrypted text encoded in base64</param>
        /// <returns>original decrypted text</returns>
        internal static string Decrypt(string base64Ciphertext)
        {
            byte[] ciphertext = Convert.FromBase64String(base64Ciphertext);
            byte[] encodedEntropy = Encoding.UTF8.GetBytes(applicationEntropy);

            byte[] encodedPlaintext = ProtectedData.Unprotect(
                ciphertext,
                encodedEntropy,
                DataProtectionScope.CurrentUser
            );

            return Encoding.UTF8.GetString(encodedPlaintext);
        }
    }
}