using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherToolkitColourChangeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static public string theme = "0";

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
                theme = "1";
            }

            if (comboBox1.SelectedIndex == 1)
            {
                theme = "2";
            }

            if (comboBox1.SelectedIndex == 2)
            {
                theme = "3";
            }

            if (comboBox1.SelectedIndex == 3)
            {
                theme = "4";
            }

            if (comboBox1.SelectedIndex == 4)
            {
                theme = "5";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
