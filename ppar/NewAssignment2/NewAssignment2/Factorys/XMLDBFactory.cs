using System;
using System.Collections.Generic;
using NewAssignment2.Individuals;

namespace NewAssignment2.Factorys
{
    public class XMLDBFactory:IAbstractFactory
    {
        private IDBMapper mapper;
        public XMLDBFactory()
        {
            CreateDBMapper();
        }


        public void CreateDBMapper()
        {
            mapper = new XMLMapper();
        }

        public void CreateUser(Person person)
        {
            mapper.CreateUser(person);
        }

        public Person GetPerson(int id)
        {
            return mapper.GetPerson(id);
        }

        public ICollection<Person> ShowOverview()
        {
           return mapper.ShowOverview();
        }
    }
}
