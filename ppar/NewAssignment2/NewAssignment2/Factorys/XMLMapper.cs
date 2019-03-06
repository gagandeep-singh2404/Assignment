using System;
using System.Collections.Generic;
using NewAssignment2.Individuals;
using System.Xml.Serialization;
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
            XmlSerializer ser = new XmlSerializer(typeof(Person));
            userList.Add(person);
        }

        public Person GetPerson(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Person> ShowOverview()
        {
            throw new NotImplementedException();
        }
    }
}
