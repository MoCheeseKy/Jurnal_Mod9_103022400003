using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400003
{
    public class Config
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public List<string> methods { get; set; }
        public Confirmation confirmation { get; set; }

        public Config() { }

        public Config(string lang, Transfer transfer, List<string> methods, Confirmation confirmation)
        {
            this.lang = lang;
            this.transfer = transfer;
            this.methods = methods;
            this.confirmation = confirmation;
        }
    }
}
