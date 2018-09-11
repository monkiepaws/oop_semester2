using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ShapeInterfaceDemo;
using ShapeInterfaceDemo.Tests.Mocks;

namespace ShapeInterfaceDemo.Tests
{
    [TestFixture]
    public class ShapeManagerTests
    {
        [Test]
        public void AddShape_IsCalled_ShapeIsAdded()
        {
            // Arrange
            ShapeManager sm = new ShapeManager();
            MockIShape ishape = new MockIShape();

            // Act
            sm.AddShape(ishape);

            // Assert
            Assert.That(sm.ShapeList[0].Equals(ishape));
        }
    }
}
