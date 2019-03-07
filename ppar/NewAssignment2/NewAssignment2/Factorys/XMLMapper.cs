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
            userList = ShowOverview();
        }
        public void CreateUser(Person person)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(StaticData.FILE);

            foreach (Person per in userList)
            {
                XmlNode xnode = doc.CreateNode(XmlNodeType.Element, "Hallo", null);
                XmlSerializer xSeriz = new XmlSerializer(typeof(Person));
                XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
                ns.Add("", "");
                XmlWriterSettings writtersetting = new XmlWriterSettings
                {
                    OmitXmlDeclaration = true
                };
                StringWriter stringwriter = new StringWriter();
                using (XmlWriter xmlwriter = System.Xml.XmlWriter.Create(stringwriter, writtersetting))
                {
                    xSeriz.Serialize(xmlwriter, per, ns);
                }
                xnode.InnerXml = stringwriter.ToString();
                XmlNode bindxnode = xnode.SelectSingleNode("Person");
                doc.DocumentElement.AppendChild(bindxnode);
            }
            doc.Save(StaticData.FILE);
            userList.Add(person);
        }

        public Person GetPerson(int id)
        {
            return userList.FirstOrDefault(x => x.ID == id);
         }

        public ICollection<Person> ShowOverview()
        {
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
