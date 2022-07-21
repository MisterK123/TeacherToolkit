using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TeacherToolkitColourChangeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public int theme = 0;


        static public List<string> currentColourScheme = new List<string>();


        List<string> pannelColour = new List<string>() { "FFCB70", "F7B064", "BBBBBB", "CCCCCC", "DDDDDD"}; 
        List<string> backgroundColour = new List<string>() { "3B2F4C", "31909B", "BBBBBB", "CCCCCC", "DDDDDD" }; 
        List<string> buttonBackground = new List<string>() { "4F3E65", "3BADBA", "BBBBBB", "CCCCCC", "DDDDDD" }; 
        List<string> fontColour = new List<string>() { "FFCB70", "F7B064", "BBBBBB", "CCCCCC", "DDDDDD" }; 




        private void button1_Click(object sender, EventArgs e)
        {
            testWindow1 win1 = new testWindow1();
            win1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            testWindow2 win2 = new testWindow2();
            win2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(comboBox1.SelectedIndex == 0)
            {
                theme = 0;
                currentColourScheme.Clear();
            }

            if (comboBox1.SelectedIndex == 1)
            {
                theme = 1;
                currentColourScheme.Clear();
            }

            if (comboBox1.SelectedIndex == 2)
            {
                theme = 2;
                currentColourScheme.Clear();
            }

            if (comboBox1.SelectedIndex == 3)
            {
                theme = 3;
                currentColourScheme.Clear();
            }

            if (comboBox1.SelectedIndex == 4)
            {
                theme = 4;
                currentColourScheme.Clear();
            }
            
            currentColourScheme.Add(pannelColour[theme]);
            currentColourScheme.Add(fontColour[theme]);
            currentColourScheme.Add(buttonBackground[theme]);
            currentColourScheme.Add(backgroundColour[theme]);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
