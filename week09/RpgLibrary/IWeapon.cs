using System;
using System.Collections.Generic;
using System.Text;

namespace RpgLibrary
{
    public interface IWeapon : IDamage, ICriticalHit, IActionPoints
    {
        AttackResult Poke();
        AttackResult Attack();
    }
}
