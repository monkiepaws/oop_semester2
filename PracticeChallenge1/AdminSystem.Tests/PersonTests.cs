using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AdminSystem.Tests
{
    [TestFixture]
    public class PersonTests
    {
        public Person person;

        [SetUp]
        public void Setup()
        {
            // Arrange

            person = new Person("Richard", "Sims", 1983);
        }

        [Test]
        public void GetName_ValidInput_CorrectOutput()
        {
            // Act
            string test = person.GetName();

            // Assert
            Assert.That(test.Equals("Richard Sims"));
        }

        [Test]
        public void GetAge_ValidInput_CorrectOutput()
        {
            // Act
            int test = person.GetAge();

            // Assert
            Assert.That(test.Equals(DateTime.Now.Year - person.YearOfBirth));
        }
    }
}
