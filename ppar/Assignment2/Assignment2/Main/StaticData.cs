using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Assignment2.Main
{
    public static class StaticData
    {
        public const string FILE = "/Users/gagandeepsingh/Documents/GitHub/Assignment/func/Assignment2";
        public const string EMAILREGEX = @"^([\w\.-]+)@fontys.nl\b";  // muss das noch machen
        public const string DATEREGEX  = @"^([\w\.-]+)@(\bstudent|lecture)\b.fontys.nl\b"; // noch verbesserst
        public const string ONLYNUMBER = @"^\d{1, 20}+$";
        public const string ONLYCHARS  = @"^[a-zA-Z]+$";
    }
}
