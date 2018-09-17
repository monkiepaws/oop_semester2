using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponLibrary
{
    public class RangedWeapon : Weapon
    {
        public int CriticalDamage = 200;
        public Random random;
        public RangedWeapon(int baseDamage, int baseRange = 2, int criticalChance = 5, int actionPoints = 2) : base(baseDamage, baseRange, criticalChance, actionPoints)
        {
            random = new Random();
        }

        public override AttackResult Attack()
        {
            AttackResult attack = new AttackResult();

            int rangedDamage = (100 - random.Next(51)) * BaseDamage / 100;

            if (random.Next(101) >= 100 - CriticalChance)
            {
                attack.Damage = rangedDamage * CriticalDamage / 100;
                attack.IsCriticalHit = true;
                attack.ActionPointsUsed = ActionPoints / 2;
            }
            else
            {
                attack.Damage = rangedDamage;
                attack.IsCriticalHit = false;
                attack.ActionPointsUsed = ActionPoints;
            }

            return attack;
        }
    }
}
