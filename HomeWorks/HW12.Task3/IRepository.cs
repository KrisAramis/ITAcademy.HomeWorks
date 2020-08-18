using System;
using System.Collections.Generic;
using System.Text;

namespace HW12.Task3
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> GetMotorcycles();
        T GetMotorcycle(int id);
        void Create(T item);
        void Update(T item);
        void Delete(int id);
        void Save();
    }
}
