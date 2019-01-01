using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Party
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }

        private decimal CalculateCostOfDections()
        {
            decimal costofDections;
            if (FancyDecorations)
            {
                costofDections = (NumberOfPeople * 15M) + 50M;
            }
            else
            {
                costofDections = (NumberOfPeople * 7.5M) + 30M;
            }
            return costofDections;
        }

       virtual public decimal cost
        {
            get
            {
                decimal totalcost = CalculateCostOfDections() ;
                totalcost += CostOfFoodPerPerson * NumberOfPeople;
                if (NumberOfPeople > 12)
                    totalcost += 100;
                return totalcost;
            }
        }
    }
}
