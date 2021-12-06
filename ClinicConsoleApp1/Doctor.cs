using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicConsoleApp1
{
    internal class Doctor: Employee,IComparable
    {


        public int numOfPatients;
        public string yearOfBirth;

       public Doctor(string firstName, string lastName, string job, int numOfPatients, string yearOfBirth ) : base(firstName, lastName, job)
        {
            this.numOfPatients = numOfPatients;
            this.yearOfBirth = yearOfBirth; 
        }

 
        public int CompareTo(object obj)
        {
            Doctor d = (Doctor)obj;
            if (this.numOfPatients > d.numOfPatients)
                return -1;
            if (this.numOfPatients < d.numOfPatients)
                return 1;
            return 0;
        }

    }

    
}
