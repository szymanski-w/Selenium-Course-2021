using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section_Exam
{
    class Trip
    {
        public string Destination { get; set; }
        public double DistanceTravelled { get; set; }
        public double TotalCostOfGasoline { get; set; }
        public double ConsumedVolumeOfGas { get; set; }

        public Trip(string destination, double distance, double totalCost, double gasConsumed)
        {
            this.Destination = destination;
            this.DistanceTravelled = distance;
            this.TotalCostOfGasoline = totalCost;
            this.ConsumedVolumeOfGas = gasConsumed;
        }

        public double Consumption()
        {
            double consumption = ((ConsumedVolumeOfGas * 100) / DistanceTravelled);
            return consumption;
        }

        public double CostPerKm()
        {
            double cost = TotalCostOfGasoline / DistanceTravelled;
            return cost;
        }

        public override string ToString()
        {
            return "Destination: " + Destination + "\n"
                + "Distance travelled: " + DistanceTravelled + " km\n"
                + "Total cost of gasoline: " + TotalCostOfGasoline + " pln\n"
                + "Consumed volume of gasoline: " + ConsumedVolumeOfGas + " l\n\n"
                + "Consumption of gasoline per 100 km: " + Consumption().ToString("0.00") + " l/100 km\n"
                + "Cost of 1 km: " + CostPerKm().ToString("0.00") + "pln / 1 km";
        }
    }
}
