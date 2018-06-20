using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp
{
    public partial class Form1 : Form
    {
        private DataManager dataManager;
        private BMI bmi;
        private FatTissue fatTissue;
        public Form1()
        {
            InitializeComponent();
            dataManager = new DataManager();
            initializeBMI();
            initializeFatTissue();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            dataManager.saveData(weightBox.Text, heightBox.Text, wristBox.Text, ankleBox.Text, waistBox.Text, neckBox.Text);
            initializeBMI();
            initializeFatTissue();
        }

        private void initializeBMI()
        {
            bmi = new BMI();
            bmiData.Text = bmi.calculateBMI();
        }

        private void initializeFatTissue()
        {
            fatTissue = new FatTissue();
            fatData.Text = fatTissue.calculateFatTissue() + "%";
        }

    }
}
