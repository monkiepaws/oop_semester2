using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RpgLibrary
{
    public interface IWeapon : IDamage, ICriticalHit, IActionPoints
    {
        AttackResult Poke();
        AttackResult Attack();
    }
}
