using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNGTuber.Model
{
    public class ConfigurationModel
    {
        public string IdleImagePath { get; set; }
        public string TalkingImagePath { get; set; }
        public bool isApng { get; set; }
        public int Volume { get; set; }
        public int Amplifier { get; set; }

    }
}
