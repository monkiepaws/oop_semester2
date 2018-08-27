using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AdminSystem.Tests
{
    [TestFixture]
    public class StaffTests
    {
        public Staff staff;

        [SetUp]
        public void Setup()
        {
            // Arrange

            staff = new Staff("Harry", "Potter", 1980, "QuidditchRulesOK");
        }

        [Test]
        public void GetName_ValidInput_CorrectOuput()
        {
            // Act
            string test = staff.GetName();

            // Assert
            Assert.That(test.Equals("Harry Potter"));
        }

        [Test]
        public void GetAge_ValidInput_CorrectOutput()
        {
            // Act
            int test = staff.GetAge();

            // Assert
            Assert.That(test.Equals(DateTime.Now.Year - 1980));
        }

        [Test]
        public void GetInfo_ValidInput_CorrectOutput()
        {
            // Act
            string test = staff.GetInfo();

            // Assert
            Assert.That(test.Equals("FName: Harry, SName: Potter, YearOfBirth: 1980, Username: QuidditchRulesOK"));
        }
    }
}
