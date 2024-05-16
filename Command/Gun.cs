using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaviour_patterns.Command
{
    public class Gun
    {
        public bool isCharged;
        public int numberOfBullets;

        public void ChargedWeapon()
        {
            isCharged = true;
            numberOfBullets = 30;
            Console.WriteLine("Se ha recargado el arma");
        }
        public void ShootGun()
        {
            numberOfBullets = 0;
            Console.WriteLine($"Se ha disparado el arma, número de balas {numberOfBullets}");

        }
        public void NoAmmo()
        {
            isCharged=false;
        }

        public bool IsCharged()
        {
            return isCharged;
        }


    }
}
