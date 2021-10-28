using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {
        void Create(T t);
        T[] FindAll();
        void Add(T t, ref T[] data);
    }
}
