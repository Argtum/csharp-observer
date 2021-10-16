using System;
using Observer.Weather;

namespace Observer.Observer
{
    public class StatsDisplay : IObserver<WeatherInfo>
    {
        private double _minTemperature = Double.MaxValue;
        private double _maxTemperature = Double.MinValue;
        private double _accTemperature = 0;
        private ulong _countAcc = 0;
        
        public void Update(WeatherInfo data)
        {
            if (_minTemperature > data.Temperature)
            {
                _minTemperature = data.Temperature;
            }
            if (_maxTemperature < data.Temperature)
            {
                _maxTemperature = data.Temperature;
            }
            _accTemperature += data.Temperature;
            ++_countAcc;
            
            Console.WriteLine("Current Temp " + data.Temperature);
            Console.WriteLine("Current Hum " + data.Humidity);
            Console.WriteLine("Current Pressure " + data.Pressure);
            Console.WriteLine("----------------");
        }
    }
}