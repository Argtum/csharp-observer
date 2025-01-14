﻿using Observer.Observer;
using Observer.Weather;

namespace Observer
{
    public class Program
    {
        static int Main()
        {
            WeatherData wd = new WeatherData();
            
            Display display = new Display();
            wd.Register( display );

            StatsDisplay statsDisplay = new StatsDisplay();
            wd.Register( statsDisplay );

            wd.SetMeasurements( 3, 0.7, 760 );
            wd.SetMeasurements( 5, 0.8, 761 );
            wd.SetMeasurements( 4, 0.8, 761 );

            wd.Remove( statsDisplay );

            wd.SetMeasurements( 10, 0.8, 761 );
            wd.SetMeasurements( -10, 0.8, 761 );

            return 0;
        }
    }
}