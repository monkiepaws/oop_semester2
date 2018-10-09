using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RpgLibrary;


namespace RpgLibrary.Tests
{
    [TestFixture]
    public class MeleeWeaponTests
    {
        [Test]
        public void MeleeWeapon_ValidInput_CorrectInstantiation()
        {
            // Arrange
            MeleeWeapon tested = new MeleeWeapon(10, 5);

            // Act

            // Assert
            Assert.That(tested.BaseDamage.Equals(10) && tested.CriticalChance.Equals(5));
        }

        [Test]
        public void ActionPointsUsed()
        {
            throw new NotImplementedException();
        }
        [Test]
        public void Attack()
        {
            throw new NotImplementedException();
        }
        [Test]
        public void CriticalHitDamage()
        {
            throw new NotImplementedException();
        }
        [Test]
        public void Damage()
        {
            throw new NotImplementedException();
        }
        [Test]
        public void Poke()
        {
            throw new NotImplementedException();
        }
    }
}
