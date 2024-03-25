using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    public class ComputerBuilderDirector
    {
          public Computer BuildGamingComputer()
        {
            return new ComputerBuilder()
                .WithCPU("Intel i7")
                .WithGPU("Nvidia RTX 3080")
                .WithRAM("32GB")
                .WithSSD("1TB")
                .WithOS("Windows 11")
                .BuildComputer();
                
        }
        public Computer BuildOfficeComputer()
        {
            return new ComputerBuilder()
                .WithCPU("Intel i5")
                .WithGPU("Integrated")
                .WithRAM("16GB")
                .WithSSD("512GB")
                .WithOS("Windows 10")
                .BuildComputer();

        }
    }
}
