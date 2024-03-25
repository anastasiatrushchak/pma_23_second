using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class Computer
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public string RAM { get; set; }
        public string SSD { get; set; }
        public string OS { get; set; }
        
        public override string ToString()
        {
            return $"CPU: {CPU}, GPU: {GPU}, RAM: {RAM}, SSD: {SSD}, OS: {OS}";
        }
    }
}
