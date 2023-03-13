using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class TreatmentPlan
    {
        public int TreatmentCode { get; set; }

        public TreatmentPlan(int treatmentCode)
        {
            TreatmentCode = treatmentCode;
        }
    }
}
