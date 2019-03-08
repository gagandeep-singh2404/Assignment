using AdministrationAssignment.Main;
using AdministrationAssignment.User;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AdministrationAssignment.Factory
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
            catch (InvalidOperationException) { userList = new List<Person>(); }
        }
        public void CreateUser(Person person)
        {
            userList.Add(person);
            XmlSerializer xml = new XmlSerializer(typeof(List<Person>));
            using (Stream s = File.OpenWrite(StaticData.FILE)) xml.Serialize(s, userList);
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