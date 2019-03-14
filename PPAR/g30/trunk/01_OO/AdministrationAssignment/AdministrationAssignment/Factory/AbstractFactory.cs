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
            string name = "AdministrationAssignment.Factory." + ConfigurationManager.AppSettings["XML"];
            Console.WriteLine(name);
            Type t = Type.GetType(name);
            return (AbstractFactory)Activator.CreateInstance(t);
        }
    }
}