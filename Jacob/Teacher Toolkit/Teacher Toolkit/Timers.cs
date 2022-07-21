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
    public partial class Timers : Form
    {
        public Timers()
        {
            InitializeComponent();
        }

        private void Timers_FormClosing(object sender, FormClosingEventArgs e)
        {
            TeacherToolkit.TimersPanelShow = true;
        }
    }
}
