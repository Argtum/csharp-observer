using Observer.Observable;

namespace Observer.Weather
{
    public struct WeatherInfo
    {
        public double Temperature;
        public double Humidity;
        public double Pressure;
    };
    
    public class WeatherData : Observable<WeatherInfo>
    {
        private double _temperature = 0.0;
        private double _humidity = 0.0;	
        private double _pressure = 760.0;

        private double GetTemperature()
        {
            return _temperature;
        }
        
        private double GetHumidity()
        {
            return _humidity;
        }
        
        private double GetPressure()
        {
            return _pressure;
        }
        
        private void MeasurementsChanged()
        {
            Notify();
        }
        
        public void SetMeasurements(double temp, double humidity, double pressure)
        {
            _humidity = humidity;
            _temperature = temp;
            _pressure = pressure;

            MeasurementsChanged();
        }
        
        protected override WeatherInfo GetChangedData()
        {
            WeatherInfo info;
            info.Temperature = GetTemperature();
            info.Humidity = GetHumidity();
            info.Pressure = GetPressure();
            
            return info;
        }
    }
}