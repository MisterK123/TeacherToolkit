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
    public partial class testWindow2 : Form
    {
        public testWindow2()
        {
            InitializeComponent();
        }
        int currentTheme = 10;
        private void testWindow2_Load(object sender, EventArgs e)
        {
            foreach (string item in Form1.currentColourScheme) Console.WriteLine(item);
                
        }

        private void ColourTimer_Tick(object sender, EventArgs e)
        {
            if (Form1.theme == 0)
            {
                if(currentTheme != Form1.theme)
                {
                    currentTheme = Form1.theme;
                    Console.WriteLine("Theme 1 selected");
                    changeColours();
                }
                
            }
            if (Form1.theme == 1)
            {
                if (currentTheme != Form1.theme)
                {
                    currentTheme = Form1.theme;
                    Console.WriteLine("Theme 2 selected");
                    changeColours();
                }
                
            }
            if (Form1.theme == 2)
            {
                if (currentTheme != Form1.theme)
                {
                    currentTheme = Form1.theme;
                    Console.WriteLine("Theme 3 selected");
                    changeColours();
                }
                
            }
            if (Form1.theme == 3)
            {
                if (currentTheme != Form1.theme)
                {
                    currentTheme = Form1.theme;
                    Console.WriteLine("Theme 4 selected");
                    changeColours();
                }
                
            }
            if (Form1.theme == 4)
            {
                if (currentTheme != Form1.theme)
                {
                    currentTheme = Form1.theme;
                    Console.WriteLine("Theme 5 selected");
                    changeColours();
                }
                
            }
        }

        public void changeColours()
        {
            Console.WriteLine("called");
            Console.WriteLine(Form1.currentColourScheme[2].Substring(0, 2), 16);
            foreach (Control cont in Controls) if (cont.GetType() == typeof(Button)) { cont.BackColor = Color.FromArgb(Convert.ToInt32(Form1.currentColourScheme[2].Substring(0, 2), 16), Convert.ToInt32(Form1.currentColourScheme[2].Substring(2, 2), 16), Convert.ToInt32(Form1.currentColourScheme[2].Substring(4, 2), 16)); }
            foreach(Control cont in Controls) if (cont.GetType() == typeof(Button)) { cont.ForeColor = Color.FromArgb(Convert.ToInt32(Form1.currentColourScheme[3].Substring(0, 2), 16), Convert.ToInt32(Form1.currentColourScheme[3].Substring(2, 2), 16), Convert.ToInt32(Form1.currentColourScheme[3].Substring(4, 2), 16)); }
            foreach(Control cont in Controls) if (cont.GetType() == typeof(Label)) { cont.BackColor = Color.FromArgb(Convert.ToInt32(Form1.currentColourScheme[1].Substring(0, 2), 16), Convert.ToInt32(Form1.currentColourScheme[1].Substring(2, 2), 16), Convert.ToInt32(Form1.currentColourScheme[1].Substring(4, 2), 16)); }
            foreach (Control cont in Controls) if (cont.GetType() == typeof(Label)) { cont.ForeColor = Color.FromArgb(Convert.ToInt32(Form1.currentColourScheme[3].Substring(0, 2), 16), Convert.ToInt32(Form1.currentColourScheme[3].Substring(2, 2), 16), Convert.ToInt32(Form1.currentColourScheme[3].Substring(4, 2), 16)); }
            foreach (Control cont in Controls) if (cont.GetType() == typeof(Panel)) { cont.BackColor = Color.FromArgb(Convert.ToInt32(Form1.currentColourScheme[3].Substring(0, 2), 16), Convert.ToInt32(Form1.currentColourScheme[3].Substring(2, 2), 16), Convert.ToInt32(Form1.currentColourScheme[3].Substring(4, 2), 16)); }
            this.BackColor = Color.FromArgb(Convert.ToInt32(Form1.currentColourScheme[1].Substring(0, 2), 16), Convert.ToInt32(Form1.currentColourScheme[1].Substring(2, 2), 16), Convert.ToInt32(Form1.currentColourScheme[1].Substring(4, 2), 16));
            
        }

    }
    
}
