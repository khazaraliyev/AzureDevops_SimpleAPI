using Microsoft.Extensions.Logging;
using SimpleAPI.Controllers;
using System;
using System.Collections;
using Xunit;


namespace SimpleAPI.Test
{
    public class UnitTest1
    {


        WeatherForecastController controller = new WeatherForecastController();

        [Fact]
        public void ReturnedValue()
        {
            var value = controller.Get();

            int count = 0;

            foreach (var item in value)
            {
                count++;
            }

            Assert.Equal(5, count);
        }
    }
}
