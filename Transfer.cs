using System;
using System.Collections.Generic;
using System.Text;

namespace Modul9_103022400003
{
    public class Transfer
    {
        public double treshold { get; set; }
        public double low_fee { get; set; }
        public double high_fee { get; set; }

        public Transfer() { }

        public Transfer(double treshold, double low_fee, double high_fee)
        {
            this.treshold = treshold;
            this.low_fee = low_fee;
            this.high_fee = high_fee;
        }
    }
}
