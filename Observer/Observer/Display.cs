using System;
using Observer.Weather;

namespace Observer.Observer
{
    public class Display : IObserver<WeatherInfo>
    {
        public void Update(WeatherInfo data)
        {
            Console.WriteLine("Current Temp " + data.Temperature);
            Console.WriteLine("Current Hum " + data.Humidity);
            Console.WriteLine("Current Pressure " + data.Pressure);
            Console.WriteLine("----------------");
        }
    }
}