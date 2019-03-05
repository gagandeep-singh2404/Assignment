﻿using System;
namespace Assignment2.Factorys
{
    public interface IAbstractFactory
    {
        IAbstractFactory CreateDBFactory();
        IDBMapper CreateDBMapper();
    }
}
