using System;
using NewAssignment2.Individuals;

namespace NewAssignment2.Factorys
{
    public interface IDBMapper
    {

        void CreateUser();
        void ShowOverview();
        Person GetPerson(int id);
    }
}