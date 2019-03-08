using System;
using System.Collections.Generic;
using NewAssignment2.Individuals;
using NewAssignment2.Main;
using System.Linq;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace NewAssignment2.Factorys
{
    public class XMLMapper : IDBMapper
    {
        private ICollection<Person> userList;
        public XMLMapper()
        {

            try
            {
                XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
                using (Stream s = File.OpenRead(StaticData.FILE))
                {
                    userList = (List<Person>)xml.Deserialize(s);
                }
            }
            catch (System.InvalidOperationException) { Console.WriteLine("Problem is da"); userList = new List<Person>(); }
        }
        public void CreateUser(Person person)
        {
            userList.Add(person);
            XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
            using (Stream s = File.OpenWrite(StaticData.FILE))xml.Serialize(s, userList);
        }


        public Person GetPerson(int id)
        {
            return userList.FirstOrDefault(x => x.ID == id);
        }

        public ICollection<Person> ShowOverview()
        {
            return userList;
        }

    }
}
