using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB0_ED1_G.Models
{
    public sealed class Singleton
    {
        private readonly static Singleton _instance = new Singleton();
        public List<Cliente> listaclientes;
        private readonly static Singleton _instanceorde = new Singleton();
        public Cliente Sort;

        private Singleton()
        {
            listaclientes = new List<Cliente>(); //sean crea los objetos
            Sort = new Cliente();
        }

        public static Singleton Instance
        {
            get
            {
                return  _instance;
            }
        }

        public static Singleton Instance2
        {
            get
            {
                return _instanceorde;
            }
        }
    }
}
