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
    public partial class CreateAccountPage : Form
    {
        public CreateAccountPage()
        {
            InitializeComponent();
        }

        string UserPassFile = @"UserPass.txt";
        string[] RequiredCharacters = { "!", ".", "?", "$", "&", "@"};
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string Username = UsernameInput.Text;
            string Password = PasswordInput.Text;
            string ConfirmPassword = ConfirmPasswordInput.Text;
            
            if (UsernameInput.Text != "" || PasswordInput.Text != "" || ConfirmPasswordInput.Text != "")
            {
                StreamReader reader = new StreamReader(UserPassFile);
                string temp;
                if (((temp = reader.ReadLine()) != null))
                {
                    string[] lines = temp.Split(',');
                    if (Username == lines[0])
                    {
                        Warning.Text = "That Username has already been taken";
                        Warning.Show();
                        reader.Close();
                    }
                }
                reader.Close();
                if (Password.Length != 8)
                {
                    Warning.Text = "Password needs to contain 8+ Characters";
                    Warning.Show();
                }
                if (Password != ConfirmPassword)
                {
                    Warning.Text = "Password does not match";
                    Warning.Show();
                    goto Skip;
                }
                StreamWriter writer = new StreamWriter(UserPassFile, true);
                writer.WriteLine(Username + "," + Password + "\r\n");
                writer.Close();
                TeacherToolkit teacherToolkit = new TeacherToolkit();
                teacherToolkit.Show();
                this.Hide();
            }
            else
            {
                Warning.Text = "Please input all fields";
                Warning.Show();
            }
        Skip:;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Warning.Hide();
        }
    }
}
