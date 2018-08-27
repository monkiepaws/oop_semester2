using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AdminSystem.Tests
{
    [TestFixture]
    public class TeacherTests
    {
        public Teacher teacher;

        [SetUp]
        public void Setup()
        {
            // Arrange

            teacher = new Teacher("Gabe", "Kotter", 1975, "GrouchoMarx", "Remedial Education");
        }

        [Test]
        public void GetName_ValidInput_CorrectOutput()
        {
            // Act
            string test = teacher.GetName();

            // Assert
            Assert.That(test.Equals("Gabe Kotter"));
        }

        [Test]
        public void GetAge_ValidInput_CorrectOutput()
        {
            // Act
            int test = teacher.GetAge();

            // Assert
            Assert.That(test.Equals(DateTime.Now.Year - 1975));
        }

        [Test]
        public void GetInfo_ValidInput_CorrectOutput()
        {
            // Act
            string test = teacher.GetInfo();

            // Assert
            Assert.That(test.Equals("FName: Gabe, SName: Kotter, YearOfBirth: 1975, Username: GrouchoMarx, Expertise: Remedial Education"));
        }
    }
}
