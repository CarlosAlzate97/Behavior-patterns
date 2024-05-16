using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    public interface IHandler
    {
        public void setNextFloor(IHandler nextFloor);
        void handleCriticalvalue(CriticalValue criticalValue);
    }
}
