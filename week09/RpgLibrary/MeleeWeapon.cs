using System;
using System.Collections.Generic;
using System.Text;

namespace RpgLibrary
{
    public class MeleeWeapon : IWeapon
    {
        public int BaseDamage { get; private set; }
        public int CriticalChance { get; private set; }
        public MeleeWeapon(int baseDamage, int criticalChance)
        {
            this.BaseDamage = baseDamage;
            this.CriticalChance = criticalChance;
        }

        public AttackResult Poke()
        {
            throw new NotImplementedException();
        }

        public AttackResult Attack()
        {
            throw new NotImplementedException();
        }

        public int Damage()
        {
            throw new NotImplementedException();
        }

        public int CriticalHitDamage()
        {
            throw new NotImplementedException();
        }

        public int ActionPointsUsed()
        {
            throw new NotImplementedException();
        }
    }
}
