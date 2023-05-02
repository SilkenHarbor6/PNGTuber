using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PNGTuber.Model;

namespace PNGTuber.Services
{
    public class Singleton
    {
        private static Singleton _instance;
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                    _instance.settings = new ConfigurationModel();
                }
                return _instance;
            }
        }
        public ConfigurationModel settings { get; set; }
    }
}
