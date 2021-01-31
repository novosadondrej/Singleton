using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonClass
    {
        //static List<string> database = new List<string>();
        //private static readonly SingletonClass _instace = new SingletonClass();

        static List<string> database;
        private SingletonClass()
        {
            database = new List<string>();
        }

        static SingletonClass _instance = null;
        private static readonly object locker = new object();

        public static SingletonClass Instance
        {
            get 
            {
                lock (locker)
                {
                    if (_instance == null)
                        _instance = new SingletonClass();
                }
                return _instance;
            }
        }

        public void Pridat(string a, string b, string c, string d)
        {
            database.Add(a);
            database.Add(b);
            database.Add(c);
            database.Add(d);
        }

        public string Ukaz()
        {
            return database.Count().ToString();
        }
    }
}
