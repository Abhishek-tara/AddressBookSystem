using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class JSONOperation
    {
        string filePath = @"D:\c#\257\AddressBookSystem\AddressBookSystem\JsonFile.json";
        public void WriteToFile(Dictionary<string, ContactManager> addressBookDictionary)
        {
            string json = "";
            foreach (ContactManager obj in addressBookDictionary.Values)
            {
                foreach (Contact contact in obj.contacts.Values)
                {
                    json = JsonConvert.SerializeObject(contact);
                    File.WriteAllText(filePath, json);
                }
            }
            Console.WriteLine("\nSuccessfully added to JSON file.");
        }
        public void ReadFromFile()
        {
            Console.WriteLine("Below are Contents of JSON File");
            var json = File.ReadAllText(filePath);
            Contact contact = JsonConvert.DeserializeObject<Contact>(json);
            Console.WriteLine(contact.ToString());
        }
    }
}
