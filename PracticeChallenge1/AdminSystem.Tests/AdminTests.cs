using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AdminSystem.Tests
{
    [TestFixture]
    public class AdminTests
    {
        public Admin admin;

        [SetUp]
        public void Setup()
        {
            // Arrange

            admin = new Admin("Elaine", "Benes", 1962, "Pendant", 203);
        }

        [Test]
        public void GetName_ValidInput_CorrectOutput()
        {
            // Act
            string test = admin.GetName();

            // Assert
            Assert.That(test.Equals("Elaine Benes"));
        }

        [Test]
        public void GetAge_ValidInput_CorrectOutpout()
        {
            // Act
            int test = admin.GetAge();

            // Assert
            Assert.That(test.Equals(DateTime.Now.Year - 1962));
        }

        [Test]
        public void GetInfo_ValidInput_CorrectOutput()
        {
            // Act
            string test = admin.GetInfo();

            // Assert
            Assert.That(test.Equals("FName: Elaine, SName: Benes, YearOfBirth: 1962, Username: Pendant, OfficeNo: 203"));
        }
    }
}
