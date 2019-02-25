using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Assignment2.Individuals;
using Assignment2.Main;

namespace Assignment2.Commands
{
    public class AddCommand : ICommand
    {
        private string decision;
        int index;

        Type type = typeof(Person);
        Type[] types;
        Person person;

        public void Execute()
        {
            person = ChoosePersonType();

            PropertyInfo[] properties = types[index].GetProperties().Where(x => Attribute.IsDefined(x, typeof(IndividualProperty))).ToArray();

            for (int i = 0; i < properties.Length;i++)
            {
                PropertyInfo propertyInfo = properties[i];
                Console.Write("Please enter {0}: ", propertyInfo.Name);
                var prop = propertyInfo.GetCustomAttribute<IndividualProperty>();
                string value = Console.ReadLine();
                bool isOk = true;
           
                if (prop.Regex != null && !prop.Regex.IsMatch(value)) { isOk = false; i--; }
                if (isOk) { propertyInfo.SetValue(person, value);};
            }
        }

        private Person ChoosePersonType()
        {
            // All specifiy types are chosen
            types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes())
                      .Where(p => type.IsAssignableFrom(p) && !p.IsAbstract).ToArray();

            while (true)
            {
                Console.WriteLine("What kind of User do you want to create: ");

                for (int i = 0; i < types.Length; i++)
                {
                    Console.Write("[{0} {1}]", i.ToString(), types[i].Name);
                }
                Console.WriteLine("");
                decision = Console.ReadLine();

                if (!int.TryParse(decision, out index)) continue;
                if (index < 0 || index > types.Length) continue;

                break;
            }

            return (Person)Activator.CreateInstance(types[index]);
        }
    }
}