using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GymApp
{
    public partial class Form1 : Form
    {
        private DataManager dataManager;
        private BMI bmi;
        private FatTissue fatTissue;
        private CaloricDemand caloricDemand;
        public Form1()
        {
            InitializeComponent();
            dataManager = new DataManager();
            initializeData();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (checkConditions())
            {
                dataManager.saveData(weightBox.Text, heightBox.Text, wristBox.Text, ankleBox.Text, waistBox.Text, neckBox.Text);
                initializeData();
            }
            
        }

        private void initializeData()
        {
            initializeBMI();
            initializeFatTissue();
            initializeLatestMeasurements();
            initializeMeasurementsDifference();
            initializeCaloricDemand();
        }

        private void initializeBMI()
        {
            bmi = new BMI();
            bmiData.Text = bmi.calculateBMI().ToString();

            if(bmi.calculateBMI() >= 18.5 && bmi.calculateBMI() <= 24.9)
            {
                bmiData.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                bmiData.ForeColor = System.Drawing.Color.Red;
            }

            initializeRating(bmi.calculateBMI());
        }

        private void initializeCaloricDemand()
        {
            caloricDemand = new CaloricDemand();
            caloricDemandLabel.Text = caloricDemand.calculateCaloricDemand().ToString() + "kcal";
        }

        private void initializeFatTissue()
        {
            fatTissue = new FatTissue();
            fatData.Text = fatTissue.calculateFatTissue().ToString() + "%";
        }

        private void initializeRating(double bmiFactor)
        {
            if(bmiFactor < 18.5)
            {
                bmiRating.Text = "niedowaga";
                bmiRating.ForeColor = System.Drawing.Color.Red;
            }
            else if(bmiFactor >= 18.5 && bmiFactor <= 24.9)
            {
                bmiRating.Text = "w normie";
                bmiRating.ForeColor = System.Drawing.Color.Green;
            }
            else if (bmiFactor >= 25 && bmiFactor <= 29.9)
            {
                bmiRating.Text = "nadwaga";
                bmiRating.ForeColor = System.Drawing.Color.Red;
            }
            else if (bmiFactor >= 30)
            {
                bmiRating.Text = "otyłość";
                bmiRating.ForeColor = System.Drawing.Color.DarkRed;
            }

        }

        private void initializeLatestMeasurements()
        {
            XElement element = dataManager.getMeasurementsAtChosenPlace(0);
            actualWeight.Text = element.Element("WEIGHT").Value.ToString() + "kg";
            actualHeight.Text = element.Element("HEIGHT").Value.ToString() + "cm";
            actualWrist.Text = element.Element("WRIST").Value.ToString() + "cm";
            actualAnkle.Text = element.Element("ANKLE").Value.ToString() + "cm";
            actualNeck.Text = element.Element("NECK").Value.ToString() + "cm";
            actualWaist.Text = element.Element("WAIST").Value.ToString() + "cm";
        }

        private void initializeMeasurementsDifference()
        {
            setDiffLabelText(weightDiff, "WEIGHT");
            setDiffLabelText(heightDiff, "HEIGHT");
            setDiffLabelText(wristDiff, "WRIST");
            setDiffLabelText(ankleDiff, "ANKLE");
            setDiffLabelText(neckDiff, "NECK");
            setDiffLabelText(waistDiff, "WAIST");
        }

        private void setDiffLabelText(Label label, String elementName)
        {
            double diff = 0;
            XElement latestMeasurements = dataManager.getMeasurementsAtChosenPlace(0);
            XElement previousMeasurements = dataManager.getMeasurementsAtChosenPlace(1);

            diff = Math.Round(Convert.ToDouble(latestMeasurements.Element(elementName).Value) - Convert.ToDouble(previousMeasurements.Element(elementName).Value), 1);
            if(elementName == "WEIGHT")
            {
                if(diff > 0)
                {
                    label.Text = "+" + diff + "kg";
                }
                else
                {
                    label.Text = diff + "kg";
                }            
            }
            else
            {
                if (diff > 0)
                {
                    label.Text = "+" + diff + "cm";
                }
                else
                {
                    label.Text = diff + "cm";
                }
            }

            setDiffLabelColor(label, diff);
            
        }

        private void setDiffLabelColor(Label label, double diff)
        {
            if (diff >= 0)
            {
                label.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Green;
            }
        }

        private bool checkCondition(TextBox textBox, double minVal, double maxVal, String message)
        {
            bool isCorrect = true;
            double value;

            if (Double.TryParse(textBox.Text, out value))
            {
                value = Math.Round(Convert.ToDouble(textBox.Text), 1);
                Console.WriteLine(value);
                if (value <= minVal || value >= maxVal)
                {
                    MessageBox.Show(message);
                    textBox.Text = "";
                    isCorrect = false;
                }
            }
            else
            {
                MessageBox.Show("Należy wprowadzić liczbę z ',' jako separatorem dziesiętnym.");
                textBox.Text = "";
                isCorrect = false;
            }

            return isCorrect;
        }

        private bool checkConditions()
        {
            //weightBox.Text, heightBox.Text, wristBox.Text, ankleBox.Text, waistBox.Text, neckBox.Text
            if (checkCondition(weightBox, 0, 500, "Waga musi znajdować się w przedziale 0-500kg")&&
               checkCondition(heightBox, 100, 280, "Wzrost musi znajdować się w przedziale 100-280cm")&&
               checkCondition(wristBox, 10, 30, "Nadgarstek musi znajdować się w przedziale 10-30cm")&&
               checkCondition(ankleBox, 10, 40, "Kostka musi znajdować się w przedziale 10-40cm")&&
               checkCondition(waistBox, 40, 200, "Pas musi znajdować się w przedziale 40-200cm")&&
               checkCondition(neckBox, 15, 60, "Kark musi znajdować się w przedziale 15-60cm"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
