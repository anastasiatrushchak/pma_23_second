using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern_
{
    class EngineStopCommand : ICommand
    {
        private Car _car;

        public EngineStopCommand(Car car)
        {
            _car = car;
        }

        public void Execute()
        {
            _car.StopEngine();
        }
    }
}
