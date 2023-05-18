using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkTests
{
    [TestFixture]
    public class VehicleTests
    {
        [Test] 
        public void WhenADefaultVehicle_MovesTwice_ItsPositionIs20() 
        { 
            Vehicle v = new Vehicle(); 
            var result = v.Move(2); 
            Assert.AreEqual(20, v.Distance); 
            Assert.AreEqual("Moving along 2 times", result); 
        }
        [Test] 
        public void WhenAVehicleWithSpeed40_IsMovedOnce_ItsPositionIs40() 
        { 
            Vehicle v = new Vehicle(4, 40); 
            var result = v.Move(); 
            Assert.AreEqual(40, v.Distance); 
            Assert.AreEqual("Moving along", result); 
        }
        [Test]
        public void WhenPassengersOverCapacity_NumPassengers_ThrowExpception()
        {
            Vehicle v = new(4);
            Assert.Throws<ArgumentException>(() => v.NumPassengers = 5);
        }
        [Test]
        public void WhenPassengersUnderZero_NumPassengers_ThrowExpception()
        {
            Vehicle v = new(4);
            Assert.Throws<ArgumentException>(() => v.NumPassengers = -5);
        }
    }
}
