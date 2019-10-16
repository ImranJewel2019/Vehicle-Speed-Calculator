using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleSpeedCalWindowsFormsApp
{
    class Vehicle
    {
        private string vehicleName;
        private string registrationNumber;
        private List<int> speedList = new List<int>();

        public Vehicle(string vehicleName, string registrationNumber)
        {
            this.vehicleName = vehicleName;
            this.registrationNumber = registrationNumber;
        }

        public void SetSpeed(int speed)
        {
            this.speedList.Add(speed);
        }

        public int GetMaxSpeed()
        {
            return this.speedList.Max();
        }

        public int GetMinSpeed()
        {
            return this.speedList.Min();
        }

        public double GetAverageSpeed()
        {
            return this.speedList.Average();
        }

    }
}
