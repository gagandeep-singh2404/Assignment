using AdministrationAssignment.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdministrationAssignment.User
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