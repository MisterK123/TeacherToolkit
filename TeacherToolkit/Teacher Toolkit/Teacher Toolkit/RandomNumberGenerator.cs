using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Toolkit
{
    public partial class RandomNumberGenerator : Form
    {
        Random rnd = new Random();
        public RandomNumberGenerator()
        {
            InitializeComponent();
        }
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int UpperLimit = int.Parse(UpperLimitBox.Text);
                int Quantity = int.Parse(QuantityBox.Text);
                int GeneratedNumber = 0;
                string tempString = "";
                for (int i = 0; i < Quantity; i++)
                {
                    GeneratedNumber = rnd.Next(0, UpperLimit + 1);
                    tempString += GeneratedNumber.ToString() + ", ";
                }
                RandomNumberDisplay.Text = tempString;
            }
            catch
            {
                RandomNumberDisplay.Text = "Error";
            }
        }
        public void RandomPreset(String UpperLimit, String Quantity)
        {
            UpperLimitBox.Text = UpperLimit;
            QuantityBox.Text = Quantity;
            GenerateButton.PerformClick();
        }
        private void RandomFour_Click(object sender, EventArgs e)
        {
            RandomPreset("4", "1");
        }
        private void RandomSix_Click(object sender, EventArgs e)
        {
            RandomPreset("6", "1");

        }
        private void RandomEight_Click(object sender, EventArgs e)
        {
            RandomPreset("8", "1");

        }
        private void RandomTen_Click(object sender, EventArgs e)
        {
            RandomPreset("10", "1");

        }
        private void RandomTwelve_Click(object sender, EventArgs e)
        {
            RandomPreset("12", "1");

        }
        private void RandomTwenty_Click(object sender, EventArgs e)
        {
            RandomPreset("20", "1");

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
            TeacherToolkit.RandomPanelShow = true;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
