using AdministrationAssignment.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationAssignment.Factory
{
    public class XMLDBFactory : AbstractFactory
    {
        private IDBMapper mapper;

        public override void CreateDBMapper()
        {
            mapper = new XMLMapper();
        }

        public override void CreateUser(Person person)
        {
            mapper.CreateUser(person);
        }

        public override Person GetPerson(int id)
        {
            return mapper.GetPerson(id);
        }

        public override ICollection<Person> ShowOverview()
        {
            return mapper.ShowOverview();
        }
    }
}