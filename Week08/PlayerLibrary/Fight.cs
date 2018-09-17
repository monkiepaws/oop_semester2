using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeaponLibrary;

namespace GameLibrary
{
    public class Fight
    {
        public Player Attacker { get; set; }
        public Player Defender { get; set; }
        public Fight(Player attacker, Player defender)
        {
            this.Attacker = attacker;
            this.Defender = defender;
        }

        public string Go()
        {
            AttackResult attack = Attacker.WeaponType.Attack();
            Defender.Health -= attack.Damage;

            return $"{Attacker.Name}: Hits for {attack.Damage} damage! {Defender.Name} now {Defender.Health} health!\n";
        }
    }
}
