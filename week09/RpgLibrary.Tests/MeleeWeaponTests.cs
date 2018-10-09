using System;
using NUnit.Framework;
using RpgLibrary;


namespace RpgLibrary.Tests
{
    [TestFixture]
    public class MeleeWeaponTests
    {
        [Test]
        public void MeleeWeapon_ValidInput_CorrectInstatiation()
        {
            // Arrange
            MeleeWeapon test = new MeleeWeapon(10, 5);

            // Act

            // Assert
            Assert.That(test.BaseDamage == 10);
        }
    }
}
