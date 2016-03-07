using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.BLL.GameLogic
{
    public class Weather
    {
        public int Temperature { get; set; }
        public int ChanceOfRain { get; set; }
        public bool IsRaining { get; set; }
        public WeatherType WeatherType { get; set; }

        public void GetChanceOfRain()
        {
            //TODO weight these
            var randomGenerator = new Random();
            ChanceOfRain = randomGenerator.Next(10, 96);
        }

        public void GetTemperature()
        {
            //TODO weight these
            var randomGenerator = new Random();
            Temperature = randomGenerator.Next(50, 106);
        }
    }
}
