using System;
using Assignment2.Individuals;

namespace Assignment2.Factorys
{
    public interface IDBMapper
    {

        void CreateUser();
        void ShowOverview();
        Person GetPerson(int id);
    }
}
