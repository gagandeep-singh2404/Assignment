using AdministrationAssignment.User;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationAssignment.Factory
{
    public abstract class AbstractFactory
    {
        public abstract void CreateDBMapper();
        public abstract void CreateUser(Person person);
        public abstract ICollection<Person> ShowOverview();
        public abstract Person GetPerson(int id);


        public static AbstractFactory CreateDB()
        {
            Type t = Type.GetType("AdministrationAssignment.Factory" + "." + ConfigurationManager.AppSettings["XML"]);
            return (AbstractFactory)Activator.CreateInstance(t);
        }
    }
}