using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    public class CriticalValue
    {
        private string _screeningColor;
        private string _criticalResult;

        public CriticalValue(string screening, string description)
        {
            _screeningColor = screening;
            _criticalResult = description;
        }

        public string screeningColor() => _screeningColor;

        public string criticalResult() => _criticalResult;
    }
}
