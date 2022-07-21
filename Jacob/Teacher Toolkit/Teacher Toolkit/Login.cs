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

namespace Teacher_Toolkit
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void LoginPage_Load(object sender, EventArgs e)
        {
            //LoadTimer.Enabled = true;
            if(CheckLastLogin())
            {
                this.Hide();
            }
            Warning.Hide();
        }

        string UserPassFile = @"UserPass.txt";
        string CheckLastLoginFile = @"CheckLastLogin.txt";
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Username = UsernameInput.Text;
            string Password = PasswordInput.Text;

            StreamReader reader = new StreamReader(UserPassFile);
            string temp;
            bool loggedIn = false;
            while ((temp = reader.ReadLine()) != null)
            {
                string[] lines = temp.Split(',');

                if (Username == lines[0] && Password == lines[1])
                {
                    loggedIn = true;
                    TeacherToolkit teacherToolkit = new TeacherToolkit();
                    teacherToolkit.Show();
                    this.Hide();
                }
            }

            if(loggedIn==false)
            {
                Warning.Show();
            }
        }
        bool CheckLastLogin()
        {
            StreamReader reader = new StreamReader(CheckLastLoginFile);
            string temp;
            while ((temp = reader.ReadLine()) != null)
            {
                if (temp == "true")
                {
                    TeacherToolkit teacherToolkit = new TeacherToolkit();
                    teacherToolkit.Show();
                    return true;        
                }
            }
            return false;
        }



        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccountPage createAccountPage = new CreateAccountPage();
            createAccountPage.Show();
            this.Hide();
        }

        float LoadTimer1 = 10f;
        private void LoadTimer_Tick(object sender, EventArgs e)
        {
           LoadTimer1 -= LoadTimer.Interval * 0.001f;
           if (LoadTimer1 < 0)
           {
               CheckLastLogin();
               LoadTimer.Enabled = false;
           }
        }
        
    }
}
