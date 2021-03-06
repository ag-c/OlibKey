﻿using OlibKey.Structures;
using System.IO;
using System.Xml.Serialization;

namespace OlibKey.Core
{
    public class SaveAndLoadAccount
    {
        public static Database LoadFiles(string directoryLocation, string masterPassword) => (Database)new XmlSerializer(typeof(Database)).Deserialize(new StringReader(Encryptor.DecryptString(File.ReadAllText(directoryLocation), masterPassword)));

        public static void SaveFiles(Database database, string directoryLocation, string masterPassword)
        {
            var writer = new StringWriter();
            new XmlSerializer(typeof(Database)).Serialize(writer, database);

			File.WriteAllText(directoryLocation, Encryptor.EncryptString(writer.ToString(), masterPassword));
        }
    }
}
