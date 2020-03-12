using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        WeatherForecastController arvin = new WeatherForecastController();
        [Fact]
        public void GetReturnedWeatherForecast()
        {
            var returnValue = arvin.Get(1);
            Assert.Equal("Arvin Bonggal", returnValue.Value);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
