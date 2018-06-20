using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    class BMI
    {
        private DataManager dataManager;
        public BMI()
        {
            dataManager = new DataManager();
        }
        public String calculateBMI()
        {
            double result = Math.Round(dataManager.getActualMeasurement("WEIGHT") / (dataManager.getActualMeasurement("HEIGHT") * dataManager.getActualMeasurement("HEIGHT") / 10000), 1);

            return result.ToString();
        }
    }
}
