using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{ 
    class CaloricDemand
    {
        private DataManager dataManager;

        public CaloricDemand()
        {
            dataManager = new DataManager();
        }

        public double calculateCaloricDemand()
        {
            return Math.Round(dataManager.getActualMeasurement("WEIGHT") * 13.7 + 5 * dataManager.getActualMeasurement("HEIGHT"), 1);
        }
    }
}
