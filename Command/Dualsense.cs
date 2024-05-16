using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaviour_patterns.Command
{
    public class Dualsense
    {
        private ICommand _buttonX;
        private ICommand _buttonSquare;

        public void buttonXAction(ICommand buttonX)
        {
            _buttonX = buttonX;
        }
        public void buttonSquareAction(ICommand buttonSquare)
        {
            _buttonSquare = buttonSquare;
        }

        public void pressButtonX()
        {
            Console.WriteLine("Se ha presionado el boton X");
            _buttonX.execute();
        }
        public void pressButtonSquare()
        {
            Console.WriteLine("Se ha presionado el boton cuadrado");
            _buttonSquare.execute();
        }
        public void pressButtonTriangle()
        {
            Console.WriteLine("Se ha presionado el boton triangulo");
            Console.WriteLine("No se ha definido comando para este boton");
        }

    }
}
