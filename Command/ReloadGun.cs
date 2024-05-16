using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behaviour_patterns.Command
{
    public class ReloadGun : ICommand
    {
        private Gun _gun;

        public ReloadGun(Gun gun)
        {
            _gun = gun;
        }
        public void execute()
        {
            _gun.ChargedWeapon();
        }
    }
}
