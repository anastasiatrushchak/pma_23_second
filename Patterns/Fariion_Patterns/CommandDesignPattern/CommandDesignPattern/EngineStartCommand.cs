using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDesignPattern_
{
    class EngineStartCommand : ICommand
    {
        private Car _car;

        public EngineStartCommand(Car car)
        {
            _car = car;
        }

        public void Execute()
        {
            _car.StartEngine();
        }
    }
}
