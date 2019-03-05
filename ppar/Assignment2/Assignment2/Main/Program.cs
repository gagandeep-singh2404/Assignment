using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Assignment2.Commands;
using Assignment2.Individuals;

namespace Assignment2
{
    class Program
    {
        private Dictionary<string, Command> commands;
        private Command initilizeCommand;
        public Program()
        {
           initilizeCommand = new Command() { SpecificAction = InitialzeCommand, Desc = "Initize All important Command" };
        }
   
        private void InitialzeCommand()
        {

            commands = new Dictionary<string, Command>()
            {
                ["0"] = new Command { SpecificAction = QuietApplication, Desc = "Exit the Applikation" },
                ["1"] = new Command { SpecificAction = AddUserHandler, Desc = "Add a new User" },
                ["2"] = new Command { SpecificAction = ListUser, Desc = "Show Overview of User" },
                ["3"] = new Command { SpecificAction = ShowUser, Desc = "Search User with ID" }
            };

        }

        private void AddUserHandler()
        {
            int index;
            Type type = typeof(Person);
            Type[] types;
            string decision;

            // All specifiy types are chosen
            types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(s => s.GetTypes())
                      .Where(p => type.IsAssignableFrom(p) && !p.IsAbstract).ToArray();


            // get the right type of the user
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

            // create Person and get his properties
            Person person = (Person)Activator.CreateInstance(types[index]);
            PropertyInfo[] properties = types[index].GetProperties().Where(x => Attribute.IsDefined(x, typeof(IndividualProperty))).ToArray();

            for (int i = 0; i < properties.Length; i++)
            {
                PropertyInfo propertyInfo = properties[i];
                Console.Write("Please enter {0}: ", propertyInfo.Name);
                var prop = propertyInfo.GetCustomAttribute<IndividualProperty>();
                string value = Console.ReadLine();
                bool isOk = true;

                if (prop.Regex != null && !prop.Regex.IsMatch(value)) { isOk = false; i--; }
                if (isOk) { propertyInfo.SetValue(person, value); }
            }
        }
        private void QuietApplication() { Console.WriteLine("-----------Thank you for using our System----------"); }
        private void ListUser() { Console.WriteLine("ich bin gerade in ListUser"); }
        private void ShowUser() { Console.WriteLine("ich bin hier in Show User"); }



        public void Run()
        {
            initilizeCommand.Execute();
            string index;

            do
            {
                foreach (KeyValuePair<string, Command> cd in commands) Console.WriteLine("{0}: {1}", cd.Key, cd.Value.Desc);
                index = Console.ReadLine();
                if (commands.ContainsKey(index)) commands[index].Execute();

            } while (index != "0");
        }

        static void Main(string[] args)
        {
            Program MainProgramm = new Program();
            MainProgramm.Run();
        }
    }
}
