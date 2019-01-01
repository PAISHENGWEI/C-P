using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class BirthdayParty:Party
    {
       
        public string CakeWrite { get; set; }

        public BirthdayParty(int numberofpeople, bool fancydecorations,string cakewrite)
        {
            NumberOfPeople = numberofpeople;
            FancyDecorations = fancydecorations;
            CakeWrite = cakewrite;
        }

        private int ActualLength
        {
            get
            {
                if (CakeWrite.Length > MaxWritingLength())
                    return MaxWritingLength();
                else
                    return CakeWrite.Length;
            }
        }

        private  int Cakesize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        } 
        
        private int MaxWritingLength()
        {
            if (Cakesize() == 8)
                return 16;
            else
                return 40;
        }
        public bool CakeWritingTooLong
        {
            get
            {
                if (CakeWrite.Length > MaxWritingLength())
                    return true;
                else
                    return false;
            }
        }

        private decimal CalculateCostOfDections()
        {
            decimal costofDections;
            if (FancyDecorations)           
                costofDections = (NumberOfPeople * 15M) + 50M;            
            else           
                costofDections = (NumberOfPeople * 7.5M) + 30M;
            
            return costofDections;
        }
       override public decimal cost
        {
            get
            {
                decimal totalcost = base.cost;
                decimal cakecost;
                if (Cakesize() == 8)
                    cakecost= 40M + ActualLength * 0.25M;
                else
                    cakecost = 75M + ActualLength * 0.25M;
                return totalcost + cakecost;
            }
        }
    }
}
