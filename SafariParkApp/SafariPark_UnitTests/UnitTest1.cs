using NUnit.Framework;
using SafariPark;

namespace SafariPark_UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("Cathy", "French", "Cathy French")]
        public void GivenTwoNames_ReturnFullName(string firstName, string lastName, string expectedName)
        {
            var subject = new Person(firstName, lastName);
            Assert.That(subject.GetFullName, Is.EqualTo(expectedName));
        }

        [Test]
        public void AgeTest()
        {
            var subject = new Person("A", "B");
            subject.Age = 35;

            Assert.AreEqual(subject.Age, 35);
        }

        [TestCase(2, 5, 8)]
        public void StructTest(int x, int y, int z)
        {
            var subjectPoint3D = new Point3D(x, y, z);

            Assert.AreEqual(subjectPoint3D.x, x);
            Assert.AreEqual(subjectPoint3D.y, y);
            Assert.AreEqual(subjectPoint3D.z, z);

        }

        [TestCase(2, 5)]
        public void GivenNoZ_StructTest(int x, int y)
        {
            var subjectPoint3D = new Point3D(x, y);

            Assert.AreEqual(subjectPoint3D.x, x);
            Assert.AreEqual(subjectPoint3D.y, y);
            Assert.AreEqual(subjectPoint3D.z, 5);
        }
    }
}