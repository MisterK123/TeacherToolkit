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
    }
}
