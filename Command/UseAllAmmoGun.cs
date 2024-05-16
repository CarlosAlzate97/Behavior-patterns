using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaviour_patterns.Command
{
    public class UseAllAmmoGun : ICommand
    {

        private Gun _gun;
        public UseAllAmmoGun(Gun gun)
        {
            _gun = gun;
        }
        public void execute()
        {
            _gun.ShootGun();
        }
    }
}
