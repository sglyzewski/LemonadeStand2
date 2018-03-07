using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand2
{
    class Store
    {
        //cups
        public double priceOf25Cups;
        public double priceOf50Cups;
        public double priceOf100Cups;

        //lemons
        public double priceOf10Lemons;
        public double priceOf30Lemons;
        public double priceOf75Lemons;

        //sugar
        public double priceOf8CupsSugar;
        public double priceOf20CupsSugar;
        public double priceOf48CupsSugar;

        //cubes
        public double priceOf100IceCubes;
        public double priceOf250IceCubes;
        public double priceOf500IceCubes;

        public Store()
        {
            priceOf25Cups = .82;
            priceOf50Cups = 1.64;
            priceOf100Cups = 2.89;

            priceOf10Lemons = .86;
            priceOf30Lemons = 2.24;
            priceOf75Lemons = 4.37;

            priceOf8CupsSugar = .64;
            priceOf20CupsSugar = 1.53;
            priceOf48CupsSugar = 3.42;

            priceOf100IceCubes = .84;
            priceOf250IceCubes = 2.15;
            priceOf500IceCubes = 3.94;
            
        }
    }
}
