using System;
namespace NewAssignment2.Factorys
{
    public interface IAbstractFactory
    {
        IAbstractFactory CreateDBFactory();
        IDBMapper CreateDBMapper();
    }
}
