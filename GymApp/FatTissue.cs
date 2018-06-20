using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp
{
    class FatTissue
    {
        private DataManager dataManager;
        public FatTissue()
        {
            dataManager = new DataManager();
        }

        public double calculateFatTissue()
        {
            return Math.Round((1.63 * dataManager.getActualMeasurement("WAIST") - 0.18 * dataManager.getActualMeasurement("WEIGHT") - 98.42) /
                            (dataManager.getActualMeasurement("WEIGHT") * 2.2) * 100, 1);

        }
    }
}
