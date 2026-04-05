using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.creational.singleton
{
    public class StoreManager
    {
        private static volatile StoreManager instance = null;
        private static readonly object lockObj = new object();

        private StoreManager() { }

        public static StoreManager GetInstance()
        {
            if (instance == null)
            {
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new StoreManager();
                    }
                }
            }
            return instance;
        }

        public string GetStoreInfo()
        {
            return "Online Book Store Manager";
        }
    }
}
