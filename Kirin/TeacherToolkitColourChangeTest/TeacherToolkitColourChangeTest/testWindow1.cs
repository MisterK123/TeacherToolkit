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
    public partial class testWindow1 : Form
    {
        public testWindow1()
        {
            InitializeComponent();
        }
        
        private void testWindow1_Load(object sender, EventArgs e)
        {
            
        }

        private void ColourTimer_Tick(object sender, EventArgs e)
        {
            if (Form1.theme == "1") Console.WriteLine("Theme 1 selected");
            if (Form1.theme == "2") Console.WriteLine("Theme 2 selected");
            if (Form1.theme == "3") Console.WriteLine("Theme 3 selected");
            if (Form1.theme == "4") Console.WriteLine("Theme 4 selected");
            if (Form1.theme == "5") Console.WriteLine("Theme 5 selected");
        }
    }
}
