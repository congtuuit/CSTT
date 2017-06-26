using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication1
{
    class QA
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public override string ToString()
        {
            return Answer;
        }
    }
}
