using System;
using System.Collections.Generic;
using NewAssignment2.Individuals;

namespace NewAssignment2.Factorys
{
    public interface IAbstractFactory
    {
        void CreateDBMapper();
        void CreateUser(Person person);
        ICollection<Person> ShowOverview();
        Person GetPerson(int id);
        void AddListToXML();
    }
}
