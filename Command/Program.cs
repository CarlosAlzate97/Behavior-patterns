using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaviour_patterns.Command
{
    public class Program1
    {
        public static void Main(string[] args) 
        { 
            Gun gun = new Gun();

            ICommand reload = new ReloadGun(gun);
            ICommand shootFullMagazine = new UseAllAmmoGun(gun);

            Dualsense dualsense = new Dualsense();

            dualsense.buttonXAction(reload);
            dualsense.buttonSquareAction(shootFullMagazine);
            dualsense.pressButtonTriangle();

        }

    }
}
