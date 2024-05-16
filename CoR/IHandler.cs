using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR.CoR
{
    public interface IHandler
    {
        public void setNextFloor(IHandler nextFloor);
        public void handleCriticalvalue(CriticalValue criticalValue);
    }
}
