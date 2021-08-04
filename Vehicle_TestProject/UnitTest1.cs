using NUnit.Framework;
using Vehicle;

namespace VehicleExercise
{
    public class Tests
    {
        [Test]
        public void WhenADefaultVehicleMovesTwiceItsPositionIs20()
        {
            Vehicle v = new Vehicle();
            var result = v.Move(2);

            Assert.AreEqual(v.Position, 20);
            Assert.AreEqual("Moving along 2 times", result);

        }
        [Test]
        public void WhenAVehicleWithSpeed40IsMovedOnceItsPositionIs40()
        {
            Vehicle v = new Vehicle(5, 40);
            var result = v.Move();

            Assert.AreEqual(40, v.Position);
            Assert.AreEqual("Moving along", result);
        }
    }
}