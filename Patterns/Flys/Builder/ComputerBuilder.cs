using System;

namespace Patterns.Builder
{
    public class ComputerBuilder
    {
        private Computer computer;
        public ComputerBuilder()
        {
            this.computer = new Computer();
        }
        public ComputerBuilder WithCPU(string cpu)
        {
            if (string.IsNullOrEmpty(cpu))
            {
                throw new ArgumentException("CPU cannot be null or empty");
            }
            this.computer.CPU = cpu;
            return this;
        }
        public ComputerBuilder WithGPU(string gpu)
        {
            if (string.IsNullOrEmpty(gpu))
            {
                throw new ArgumentException("GPU cannot be null or empty");
            }
            this.computer.GPU = gpu;
            return this;
        }
        public ComputerBuilder WithRAM(string ram)
        {
            if (string.IsNullOrEmpty(ram))
            {
                throw new ArgumentException("RAM cannot be null or empty");
            }
            this.computer.RAM = ram;
            return this;
        }
        public ComputerBuilder WithSSD(string ssd)
        {
            if (string.IsNullOrEmpty(ssd))
            {
                throw new ArgumentException("SSD cannot be null or empty");
            }
            this.computer.SSD = ssd;
            return this;
        }
        public ComputerBuilder WithOS(string os)
        {
            if (string.IsNullOrEmpty(os))
            {
                throw new ArgumentException("OS cannot be null or empty");
            }
            this.computer.OS = os;
            return this;
        }
        public Computer BuildComputer()
        {
            return this.computer;
        }
    }
}
