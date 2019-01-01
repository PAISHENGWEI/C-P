using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Honeycomb
{
    class Workers:Bee
    {
        private string[] jobICanDo;
        private int shiftsToWork;//蜂后指定的工班次數
        private int shiftsWorked;
        const double honeyUnitsPerShiftWorrked = 0.65;
        public override double HeneyConsumptionRate()
        {
          double consumption= base.HeneyConsumptionRate();
            consumption += shiftsWorked * honeyUnitsPerShiftWorrked;
            return consumption;
        }
        public Workers(string[] jobICanDo,double weightMg):base(weightMg)
        {
            this.jobICanDo = jobICanDo;
        }


        public int ShiftsLeft
        {
            get
            {
                return shiftsToWork - shiftsWorked;
            }
        }

        public string CurrentJob { get; private set; } = "";
        public bool DoThisJob(string job ,int numberOfShifts)
        {
            if (!String.IsNullOrEmpty(CurrentJob))
                return false;
            for(int i=0;i<jobICanDo.Length;i++)
            
                if (jobICanDo[i] == job)
                {
                    CurrentJob = job;
                    this.shiftsToWork = numberOfShifts;
                    shiftsWorked = 0;
                    return true;
                }
            
            return false;
        }
        public bool DidYouFinish()
        {
            if (String.IsNullOrEmpty(CurrentJob))
                return false;
            shiftsWorked++;
            if (shiftsWorked > shiftsToWork)
            {
                shiftsWorked = 0;
                shiftsToWork = 0;
                CurrentJob = "";
                return true;
            }
            else
                return false;
        }

    }
}
