using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    public class PrimaryCare : IHandler
    {
        private IHandler _nextHandler;
        public void setNextFloor(IHandler nextFloor)
        {
            _nextHandler = nextFloor;
        }
        public void handleCriticalvalue(CriticalValue criticalValue)
        {
            if (criticalValue.screeningColor().ToString().Equals("Yellow"))
            {
                Console.WriteLine($"Caso manejado por atención primaria (AP), el resultado crítico fue: {criticalValue.criticalResult()}");
            }
            else if (_nextHandler is not null)
            {
                _nextHandler.handleCriticalvalue(criticalValue);
            }

        }
    }

}
