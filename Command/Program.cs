using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Behaviour_patterns.Command
{
    public class Program
    {
        public static void Main(string[] args) 
        { 
            Gun gun = new Gun();

            ICommand reload = new ReloadGun(gun);
            ICommand shootFullMagazine = new UseAllAmmoGun(gun);

            Dualsense dualsense = new Dualsense();

            dualsense.buttonSquareAction(shootFullMagazine);
            dualsense.pressButtonSquare();

            dualsense.buttonXAction(reload);
            dualsense.pressButtonX();

            dualsense.pressButtonTriangle();

        }

    }
}
