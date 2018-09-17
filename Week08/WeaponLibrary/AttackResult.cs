using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeaponLibrary
{
    public struct AttackResult
    {
        public int Damage { get; set; }
        public int ActionPointsUsed { get; set; }
        public bool IsCriticalHit { get; set; }
    }
}
