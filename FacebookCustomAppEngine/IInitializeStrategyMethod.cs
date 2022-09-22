using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookCustomAppEngine
{
    public interface IInitializeStrategyMethod
    {
       bool Execute(object i_Object1, object i_Object2);
    }
}
