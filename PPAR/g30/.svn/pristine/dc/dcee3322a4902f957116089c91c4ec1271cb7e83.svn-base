using System;
using System.Collections.Generic;
using System.Linq;
using Assignment1.Main;
using Assignment1.Vehicles;
using Assignment1.ColourDecoration;
using Assignment1.Engine;

namespace Assignment1.Command
{
    public class AddVehicleCommand : ICommand
    {
        private Type[] wheelList;
        private Type[] carColourList;
        private Type[] types;
        Type type; 

        private CarDealer carDealer;
        List<Int32> listOfIndex = new List<int>();
        private string input = "";
        private int choice;
        ICommand command;

        public AddVehicleCommand(CarDealer carDealer)
        {
            this.carDealer = carDealer;
        }


        public void Execute()
        {  
            SelectCarType();
            Brand brand = SelectBrand();
            SelectColour();
            IColourDecoration colourDecoration = SelectColourDeco();
            EngineClass engine = SelectEngine();
            SelectWheel();
            IWheelDeco wheelDeco = SelectWheelDeco();
            Numberplate numberplate = AssignNumberplate();


            IWheel  wheel = (IWheel)Activator.CreateInstance(wheelList[listOfIndex.Last()], wheelDeco);
            listOfIndex.RemoveAt(listOfIndex.Count - 1);
            ICarColour carColour = (ICarColour)Activator.CreateInstance(carColourList[listOfIndex.Last()], colourDecoration);
            listOfIndex.RemoveAt(listOfIndex.Count - 1);

            Vehicle vehicle = (Vehicle)Activator.CreateInstance(types[listOfIndex.Last()], new object[]{carColour,wheel,brand,numberplate,engine});
            Console.WriteLine("Congratulation you successfully added a new vehicle");

            carDealer.AddVehicleToList(vehicle);
            command = new PrintVehicleCommand() {List = carDealer.Vehicles };
            command.Execute();
            listOfIndex.Clear();

        }


        private void SelectCarType()
        {
            type = typeof(Vehicle);
                 types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsAbstract).ToArray();


            while (true)
            {
                Console.WriteLine("Please select one of the Vehicle types: ");
                for (int i = 0; i < types.Length; ++i)
                {
                    Console.Write("[{0} {1}]", i.ToString(), types[i].Name);
                }
                Console.WriteLine("");

                input = Console.ReadLine();

                if (!int.TryParse(input, out choice)) continue;
                if (choice < 0 || choice >= types.Length) continue;
                this.listOfIndex.Add(choice);
                break;
            }

        }

        private Brand SelectBrand()
        {
            Type[] brandList = this.carDealer.GetArrayOfBrands();
            while (true)
            {
                Console.WriteLine("Select Brand: ");
                for (int i = 0; i < brandList.Length; ++i)
                {
                    Console.Write("[{0} {1}]", i.ToString(), brandList[i].Name);
                }
                Console.WriteLine("");

                input = Console.ReadLine();

                if (!int.TryParse(input, out choice)) continue;
                if (choice < 0 || choice >= brandList.Length) continue;
                break;
            }
            return (Brand)Activator.CreateInstance(brandList[choice]);
        }

        private void SelectColour()
        {
            carColourList = this.carDealer.GetArrayOfCarColours();

            while (true)
            {
                Console.WriteLine("Select Colour: ");
                for (int i = 0; i < carColourList.Length; ++i)
                {
                    Console.Write("[{0} {1}]", i.ToString(), carColourList[i].Name);
                }
                Console.WriteLine("");

                input = Console.ReadLine();

                if (!int.TryParse(input, out choice)) continue;
                if (choice < 0 || choice >= carColourList.Length) continue;

                listOfIndex.Add(choice);
                break;
            }

        }

        private IColourDecoration SelectColourDeco()
        {
            Type[] colourDecoList = this.carDealer.GetArrayOfColourDecos();

            while (true)
            {
                Console.WriteLine("Select Colour Decoration: ");
                for (int i = 0; i < colourDecoList.Length; ++i)
                {
                    Console.Write("[{0} {1}]", i.ToString(), colourDecoList[i].Name);
                }
                Console.WriteLine("");

                input = Console.ReadLine();

                if (!int.TryParse(input, out choice)) continue;
                if (choice < 0 || choice >= colourDecoList.Length) continue;

                break;
            }
            return (IColourDecoration)Activator.CreateInstance(colourDecoList[choice]);
        }

        private EngineClass SelectEngine()
        {
            Type[] engineList = this.carDealer.GetArrayOfEngines();

            while (true)
            {
                Console.WriteLine("Select Engine: ");
                for (int i = 0; i < engineList.Length; ++i)
                {
                    Console.Write("[{0} {1}]", i.ToString(), engineList[i].Name);
                }
                Console.WriteLine("");

                input = Console.ReadLine();

                if (!int.TryParse(input, out choice)) continue;
                if (choice < 0 || choice >= engineList.Length) continue;
                break;
            }
            return (EngineClass)Activator.CreateInstance(engineList[choice]);
        }

        private void SelectWheel()
        {
            wheelList = this.carDealer.GetArrayOfCarWheels();

            while (true)
            {
                Console.WriteLine("Select Wheels: ");
                for (int i = 0; i < wheelList.Length; ++i)
                {
                    Console.Write("[{0} {1}]", i.ToString(), wheelList[i].Name);
                }
                Console.WriteLine("");

                input = Console.ReadLine();

                if (!int.TryParse(input, out choice)) continue;
                if (choice < 0 || choice >= wheelList.Length) continue;

                listOfIndex.Add(choice);
                break;
            }
        }

        private IWheelDeco SelectWheelDeco()
        {
            Type[] wheelDecoList = this.carDealer.GetArrayOfWheelDecos();

            while (true)
            {
                Console.WriteLine("Select Wheel Decoration: ");
                for (int i = 0; i < wheelDecoList.Length; ++i)
                {
                    Console.Write("[{0} {1}]", i.ToString(), wheelDecoList[i].Name);
                }
                Console.WriteLine("");

                input = Console.ReadLine();

                if (!int.TryParse(input, out choice)) continue;
                if (choice < 0 || choice >= wheelDecoList.Length) continue;

                break;
            }
            return (IWheelDeco)Activator.CreateInstance(wheelDecoList[choice]);

        }

        private Numberplate AssignNumberplate()
        {
            Console.WriteLine("Please enter your Numberplate: ");

            input = Console.ReadLine();

            Numberplate numberplate = new Numberplate(input);

            return numberplate;
        }
    }
}

