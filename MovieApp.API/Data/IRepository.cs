using MovieApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieApp.API.Data
{
    public interface IRepository<T> where T : class
    {
        void Add(T obj);
        void Delete(T obj);
    }
}
