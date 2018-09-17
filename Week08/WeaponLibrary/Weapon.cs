using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponLibrary
{
    public abstract class Weapon
    {
        public int BaseDamage { get; set; }
        public int BaseRange { get; set; }
        public int CriticalChance { get; set; }
        public int ActionPoints { get; set; }

        public Weapon(int baseDamage, int baseRange, int criticalChance, int actionPoints)
        {
            this.BaseDamage = baseDamage;
            this.BaseRange = baseRange;
            this.CriticalChance = criticalChance;
            this.ActionPoints = actionPoints;
        }

        public virtual AttackResult Attack()
        {
            AttackResult attack = new AttackResult();
            return attack;
        }

        public virtual AttackResult Poke()
        {
            AttackResult attack = new AttackResult
            {
                Damage = 1,
                IsCriticalHit = false,
                ActionPointsUsed = 0
            };

            return attack;
        }
    }
}
