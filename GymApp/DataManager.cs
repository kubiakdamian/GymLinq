using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GymApp
{
    class DataManager
    {
        private String path;
        private XElement xelement;
        private IEnumerable<XElement> measurements;

        public DataManager()
        {
            this.path = "../../data.xml";
            xelement = XElement.Load(path);
            measurements = xelement.Elements();
        }

        public void saveData(String weight, String height, String wrist, String ankle, String waist, String neck)
        {
            xelement.AddFirst(new XElement("MEASUREMENTS",
            new XElement("WEIGHT", weight),
            new XElement("HEIGHT", height),
            new XElement("WRIST", wrist),
            new XElement("ANKLE", ankle),
            new XElement("WAIST", waist),
            new XElement("NECK", neck)));

            xelement.Save("../../data.xml");

            Console.Write(xelement);

            //printData(measurements);
        }

        public double getActualMeasurement(String measurement)
        {
           return Convert.ToDouble(measurements.First().Element(measurement).Value);
        }

        public XElement getMeasurementsAtChosenPlace(int place)
        {
            return xelement.Descendants("MEASUREMENTS").ElementAt(place);
        }

        private void printData(IEnumerable<XElement> measurements)
        {
            foreach (var measurement in measurements)
            {
                Console.WriteLine("WEIGHT: " + measurement.Element("WEIGHT").Value);
                Console.WriteLine("HEIGHT: " + measurement.Element("HEIGHT").Value);
                Console.WriteLine("WRIST: " + measurement.Element("WRIST").Value);
                Console.WriteLine("ANKLE: " + measurement.Element("ANKLE").Value);
                Console.WriteLine("WAIST: " + measurement.Element("WAIST").Value);
                Console.WriteLine("NECK: " + measurement.Element("NECK").Value + "\n\n");
            }
        }
    }
}
