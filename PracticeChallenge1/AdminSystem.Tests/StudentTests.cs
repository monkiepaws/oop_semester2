using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AdminSystem.Tests
{
    [TestFixture]
    public class StudentTests
    {
        public Student student;

        [SetUp]
        public void Setup()
        {
            // Arrange

            student = new Student("Richard", "Sims", 1983, 9633324);
        }

        [Test]
        public void GetName_ValidInput_CorrectOutput()
        {
            // Act
            string test = student.GetName();

            // Assert
            Assert.That(test.Equals("Richard Sims"));
        }

        [Test]
        public void GetAge_ValidInput_CorrectOutput()
        {
            // Act
            int test = student.GetAge();

            // Assert
            Assert.That(test.Equals(DateTime.Now.Year - 1983));
        }

        [Test]
        public void GetInfo_ValidInput_CorrectOutput()
        {
            // Act
            string test = student.GetInfo();

            // Assert
            Assert.That(test.Equals("FName: Richard, SName: Sims, YearOfBirth: 1983, Id: 9633324"));
        }
    }
}
