using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponLibrary
{
    public class MeleeWeapon : Weapon
    {
        public int CriticalDamage = 200;
        public Random CriticalHit;
        public MeleeWeapon(int baseDamage, int baseRange = 1, int criticalChance = 10, int actionPoints = 1) : base(baseDamage, baseRange, criticalChance, actionPoints)
        {
            CriticalHit = new Random();
        }

        public override AttackResult Attack()
        {
            AttackResult attack = new AttackResult();

            if (CriticalHit.Next(101) >= 100 - CriticalChance)
            {
                attack.Damage = BaseDamage * CriticalDamage / 100;
                attack.IsCriticalHit = true;
            }
            else
            {
                attack.Damage = BaseDamage;
                attack.IsCriticalHit = false;
            }

            attack.ActionPointsUsed = ActionPoints;

            return attack;
        }
    }
}
