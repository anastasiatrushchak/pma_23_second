using Lab_6.Strategy.StrategyClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6.Strategy
{
    internal class Animal
    {
        private IDoing _doStep;

        public Animal() { }
        public Animal(IDoing doing)
        {
            _doStep = doing;
        }

        public void ChangeStrategy(IDoing doSomethingOther)
        {
            _doStep = doSomethingOther;
        }

        public void DoStep()
        {
            if (_doStep == null)
            {
                throw new ArgumentException("I don't now what to do!");
            }
            _doStep.DoSomething();
        }
    }
}
