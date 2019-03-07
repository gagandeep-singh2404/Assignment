using System;
using System.Collections.Generic;
using NewAssignment2.Individuals;
using NewAssignment2.Main;
using System.Linq;
using System.Xml.Serialization;
using System.IO;

namespace NewAssignment2.Factorys
{
    public class XMLMapper : IDBMapper
    {
        private ICollection<Person> userList;
        public XMLMapper()
        {

            userList = ShowOverview();

        }

        public void AddListToXML()
        {
            XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
            using (Stream s = File.OpenWrite(StaticData.FILE))
                xml.Serialize(s, userList);
        }

        public void CreateUser(Person person)
        {
            userList.Add(person);
        }

        public Person GetPerson(int id)
        {
            return userList.FirstOrDefault(x => x.ID == id); ;
         }

        public ICollection<Person> ShowOverview()
        {
            Console.WriteLine("ich bin hier: ShowOverview");
            XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
            List<Person> users;
            using (Stream s = File.OpenRead(StaticData.FILE))
            
            {
                users =  (List<Person>)xml.Deserialize(s);
            }

            return users;
        }
    }
}
