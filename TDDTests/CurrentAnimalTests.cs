using Lection8_New;
using NUnit.Framework;

namespace TDDTests
{
    public class CurrentAnimalTests
    {
        private IAnimal _animal;

        [SetUp]
        public void Initialize()
        {
            _animal = new Rabbit();
        }

        [Test]
        public void SaySound_WhenCalled_ShouldReturnUiii()
        {
            Assert.AreEqual("Uiii", _animal.SaySound());
        }
    }
}