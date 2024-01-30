using System;
using System.Collections.Generic;

namespace Zadatak1
{
    public class Weather
    {
        public double Temperature { get; set; }
        public double Humidity { get; set; }
    }

    public static class WeatherService
    {
        public static Weather GetWeatherForecast()
        {
            return new Weather { Temperature = 20.0, Humidity = 30.0 };
        }
    }

    interface ILiveWeatherForecast
    {
        void Register(IWeatherProcessor processor);
        void Unregister(IWeatherProcessor processor);
        void Notify();
    }

    interface IWeatherProcessor 
    { 
        void OnWeatherChanged(Weather weather); 
    }

    class WeatherForecastProvider : ILiveWeatherForecast
    {
        private DateTime lastUpdate = DateTime.Now;
        private Weather currentWeather = WeatherService.GetWeatherForecast();
        private List<IWeatherProcessor> processors = new List<IWeatherProcessor>();

        public void Register(IWeatherProcessor processor) 
        { 
            processors.Add(processor); 
        }

        public void Unregister(IWeatherProcessor processor) 
        { 
            processors.Remove(processor); 
        }

        public void PeriodicUpdate()
        {
            if (DateTime.Now >= lastUpdate.AddHours(1))
            {
                currentWeather = WeatherService.GetWeatherForecast();
                Notify();
            }
        }

        public void Notify()
        {
            foreach (var processor in processors)
            {
                processor.OnWeatherChanged(currentWeather);
            }
        }
    }

    class WeatherStatistics : IWeatherProcessor
    {
        public void OnWeatherChanged(Weather weather)
        {
            // Track weather statistics. Ignore impl.
        }
    }

    class WeatherDisplay : IWeatherProcessor
    {
        public void OnWeatherChanged(Weather weather)
        {
            // Display weather data. Ignore impl.
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var weatherForecastProvider = new WeatherForecastProvider();
            var weatherStatistics = new WeatherStatistics();
            var weatherDisplay = new WeatherDisplay();

            weatherForecastProvider.Register(weatherStatistics);
            weatherForecastProvider.Register(weatherDisplay);

            weatherForecastProvider.PeriodicUpdate();
        }
    }
}