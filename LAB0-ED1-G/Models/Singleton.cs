using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LAB0_ED1_G.Models
{
    public sealed class Singleton
    {
        private readonly static Singleton _instance = new Singleton();
        public List<Cliente> ClienteList;

        private Singleton()
        {
            ClienteList = new List<Cliente>();
        }

        public static Singleton Instance
        {
            get
            {
                return_ instance;
            }
        }
    }
}
