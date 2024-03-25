using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternAdapter
{
    public interface ITarget
    {
        void ProcessStudents(string[,] students);
    }
}
