using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    class Weather
    {
        public int weatherTemperature;
        public string weatherCondition;
        public List<int> possibleWeatherTemperatures;
        public List<string> possibleWeatherConditions;
        public Random random;

        public int DetermineTemperature()
        {
            return weatherTemperature; 
        }

        public string DetermineWeatherCondition()
        {
            return weatherCondition;
        }

    }
}
