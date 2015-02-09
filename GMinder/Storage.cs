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

using System.IO;
using System.IO.IsolatedStorage;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ReflectiveCode.GMinder
{
    /// <summary>
    /// Provides methods to serialize and deserialize objects
    /// </summary>
    public static class Storage
    {
        public static void AppendText(string path, string text)
        {
            using (var stream = new IsolatedStorageFileStream(path, FileMode.Append))
            {
                using (var writer = new StreamWriter(stream))
                {
                    writer.WriteLine(text);
                    writer.Flush();
                }
            }
        }

        public static string LoadText(string path, string text)
        {
            using (var stream = new IsolatedStorageFileStream(path, FileMode.OpenOrCreate))
            using (var reader = new StreamReader(stream))
                return reader.ReadToEnd();
        }

        public static void SaveObject(string path, object value)
        {
            var serializer = new XmlSerializer(value.GetType());
            using (var stream = new IsolatedStorageFileStream(path, FileMode.Create))
            {
                serializer.Serialize(new XmlTextWriter(stream, Encoding.Unicode), value);
                stream.Flush();
            }
        }

        public static T LoadObject<T>(string path)
        {
            var serializer = new XmlSerializer(typeof(T));
            try
            {
                using (var stream = new IsolatedStorageFileStream(path, FileMode.Open))
                    return (T)serializer.Deserialize(new XmlTextReader(stream));
            }
            catch (FileNotFoundException)
            {
                return default(T);
            }
        }
    }
}
