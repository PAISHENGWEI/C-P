using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class DinnerParty:Party
    {
       
        public bool HealthyOption { get; set; }
        public DinnerParty(int numberofpeople,bool fancydecorations,bool healthyoption)
        {
            NumberOfPeople = numberofpeople;
            FancyDecorations = fancydecorations;
            HealthyOption = healthyoption;

        }
       override public decimal cost
        {
            get
            {
                decimal totalCost = base.cost + CalculateCostOfBeveragesPerPeople() * NumberOfPeople;             
                if (NumberOfPeople == 0)
                { totalCost = 0; }
                if (HealthyOption)
                {
                    return totalCost *= 0.95M;
                }
                else
                    return totalCost;
            }
        }
        private decimal CalculateCostOfDections()
        {
            decimal costofDections;
            if(FancyDecorations)
            {
                costofDections = (NumberOfPeople * 15M) + 50M;
            }
            else
            {
                costofDections = (NumberOfPeople * 7.5M) + 30M;
            }
            return costofDections;
        }
        private decimal CalculateCostOfBeveragesPerPeople()
        {
            decimal costofBeveragesPerPeople;
            if (HealthyOption)
            {
                costofBeveragesPerPeople = 5M;
            }
            else
            {
                costofBeveragesPerPeople = 20M;
            }
            return costofBeveragesPerPeople;
        }


    }
}
