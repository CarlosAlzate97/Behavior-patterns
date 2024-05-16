using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaviour_patterns.Command
{
    public class Gun
    {
        public int numberOfBullets;

        public void ChargedWeapon()
        {
            numberOfBullets = 30;
            Console.WriteLine($"Se ha recargado el arma {numberOfBullets}");
        }
        public void ShootGun()
        {
            numberOfBullets = 0;
            Console.WriteLine($"Se ha disparado el arma, número de balas {numberOfBullets}");

        }

    }
}
