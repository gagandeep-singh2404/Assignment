using System;
using System.Xml.Serialization;
using NewAssignment2.Main;

namespace NewAssignment2.Individuals
{
    [Serializable]
    public class Lecturer : Person
    {
        [IndividualProperty(RegexString = StaticData.ONLYNUMBER)] public string Phonenumber { get; set; }
        [IndividualProperty(RegexString = StaticData.ONLYCHARS)] public string LecturersAbbreviation { get; set; }
        [IndividualProperty(RegexString = StaticData.DATEREGEX)] public string DateStarted { get; set; }



        public override string ToString()
        {
            return base.ToString() + "Phonenumber: " + Phonenumber + ", Lecture Abbreviation: " + LecturersAbbreviation +
                                    "\nDate Started: " + DateStarted + "\n---------------------------------------------\n";
        }
    }
}
