using AdministrationAssignment.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AdministrationAssignment.User
{
    [XmlInclude(typeof(Student))]
    [XmlInclude(typeof(Lecturer))]
    [Serializable]
    public abstract class Person
    {

        public static int counter = 0;
        public int ID { get; set; }

        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string Firstname { get; set; }
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string Lastname { get; set; }
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string Nationality { get; set; }
        [IndividualProperty(RegexString = StaticData.EMAILREGEX)] public string Email { get; set; }

        public Person()
        {
            ID = ++counter;
        }



        public string OnlyRelevantData()
        {
            return "\n----------------------------------------------\n" +
                "ID: " + ID + "| Firstname: " + Firstname + "| Lastname: " + Lastname + "\n----------------------------------------------\n";
        }


        public override string ToString()
        {
            return "\n---------------------------------------------\nID: " + ID + "| Firstname: " + Firstname + "| Lastname: " + Lastname +
            "\nNationality: " + Nationality + "| Email: " + Email + "\n";
        }
    }
}