using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sim.model
{
    public interface IOperatable
    {
        void Operate(RichTextBox logger);
    }
}
