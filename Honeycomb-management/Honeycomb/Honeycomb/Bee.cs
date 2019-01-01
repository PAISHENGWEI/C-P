using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honeycomb
{
    class Bee:IStingPatrol
    {
        public const double HoneyUnitsConsumedPerMg = 0.25;
        public double WeightMg { get; private set; }

        public int AlertLevel => throw new NotImplementedException();

        public int StingerLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        virtual public double HeneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }

        public bool LookForEnemies()
        {
            throw new NotImplementedException();
        }

        public int SharpenSting(int length)
        {
            throw new NotImplementedException();
        }
    }
}
