using CrossPlatformApp.Controllers;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace CrossPlatformApp.Test
{
    public class WeatherForecastControllerTest
    {
        [Test]
        public void GetTest()
        {
            var controller = new WeatherForecastController(null);

            Assert.That(controller.Get(), Is.Not.Empty);
        }


        [Test]
        public void CalcTest()
        {
            var controller = new WeatherForecastController(null);
            Assert.That(controller.Calc(2, 3), Is.EqualTo(5));
        }
    }
}