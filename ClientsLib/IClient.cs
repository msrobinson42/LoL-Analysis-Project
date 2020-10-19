using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClientsLib
{
    interface IClient<T> where T : class
    {
        Task<T> GetModel();
    }
}
