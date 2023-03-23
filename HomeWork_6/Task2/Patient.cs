using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_6.Task2
{
    internal class Patient
    {

        public TreatmentPlan Plan { get; set; }
        public Doctor AttendingDoctor { get; set; }

        public Patient(int code) => Plan = new(code);

        public void AppointDoctor()
        {
            if (Plan.TreatmentCode == 1)
                AttendingDoctor = new Surgeon();
            else if (Plan.TreatmentCode == 2)
                AttendingDoctor = new Dentist();
            else
                AttendingDoctor = new Therapist();
            AttendingDoctor.Heal();
        }
    }
}
