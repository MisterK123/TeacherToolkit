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
    public partial class RandomStudentForm : Form
    {
        public RandomStudentForm()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        private bool mouseDown;
        private Point lastLocation;
        private void timerTB_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void timerTB_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void timerTB_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Hide();
            TeacherToolkit.RandomStudentPanelShow = true;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public Point MouseDownLocation;
        List<string> names = new List<string>();


        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            studentsBox.Items.Clear();
            names.Clear();
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            //gets the filename            
            //foreach (string file in files) textBox2.AppendText(file);

            using (StreamReader reader = new StreamReader(files[0]))
            {
                while (true)
                {
                    string line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    studentsBox.Items.Add(line); // Use line.
                    names.Add(line);
                }
            }
            WriteClass(names);
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }

        private void pickStudent_Click(object sender, EventArgs e)
        {
            chooseStudent();
        }

        private void chooseStudent()
        {
            int num = studentsBox.Items.Count;
            if (num > 0)
            {
                int studentInd = rnd.Next(0, num);
                string result = studentsBox.Items[studentInd].ToString();
                resultsLabel.Text = result;
                studentsBox.Items.RemoveAt(studentInd);
            }
        }

        private void reset()
        {
            studentsBox.Items.Clear();
            foreach (string name in names)
            {
                studentsBox.Items.Add(name);
            }
            resultsLabel.Text = "";
        }
        void getStudents()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                getStudentsFile();
            }
        }

        void getStudentsFile()
        {
            names.Clear();
            studentsBox.Items.Clear();
            try
            {
                using (StreamReader sReader = new StreamReader(openFileDialog1.FileName))
                {
                    string line;
                    while (true)
                    {
                        line = sReader.ReadLine();
                        if (line != null)
                        {
                            studentsBox.Items.Add(line);
                            names.Add(line);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                WriteClass(names);
            }
            catch (Exception) { }
        }
        private void AddStudent()
        {
            string student = addStudentsBox.Text;
            names.Add(student);
            studentsBox.Items.Add(student);
            addStudentsBox.Text = "";
        }


        private List<List<List<string>>> GetAllData()
        {
            List<List<List<string>>> classData = new List<List<List<string>>>(); // A 3D list, the first list inside is the days, the lists inside that are the periods
            using (StreamReader f = new StreamReader(@"classes.utc"))  // Opens the file where the data is stored
            {
                foreach (string day in f.ReadToEnd().Split(new string[] { Environment.NewLine }, StringSplitOptions.None)) // Splits the data at the newline - each day
                {
                    List<List<string>> tempDay = new List<List<string>>(); // Creates temporary 2D list to store one day at a time, with lists of the students in the periods inside it. This will get writen to every iteration through the days
                    foreach (string period in day.Split('@')) // Splits the day up into periods
                    {
                        tempDay.Add(period.Split(',').ToList()); // Splits the periods up into the students in the period
                    }
                    classData.Add(tempDay); // Adds the day to the main list of days
                }
            }
            return classData;
        }

        private List<string> LoadClass()
        {
            int[] times = { 510, 575, 630, 675, 730, 820, 875, 930, 990, 1440 }; // A list of the times when different periods start, calculated by 60*hours + minuites
            int timeNum = int.Parse(DateTime.Now.ToString("HH")) * 60 + int.Parse(DateTime.Now.ToString("mm")); // A calculation of the current time num, calculated by 60*hours + minuites
            int ind = 0;  // Index of the lesson in the array

            List<List<List<string>>> classData = GetAllData(); // Gets all the student data

            foreach (int item in times) // Iterating through the times when lessons start
            {
                if (timeNum < item) // If the current time value is less than the one in the time list, then it must be in that lesson
                {
                    ind = Array.IndexOf(times, item); // Gets the index of the number that the current time value is smaller than
                    break;
                }
            }
            try
            {
                if (ind != 0 & ind != 13 & (int)(DateTime.Now.DayOfWeek + 6) % 7 < 5)  // Checks if it is not before school hours (ind != 0), if it is not after school hours (ind != 13), and if it isn't the weekend ((int)(DateTime.Now.DayOfWeek+6)%7 <5)
                {
                    return classData[(int)(DateTime.Now.DayOfWeek + 6) % 7][ind - 1]; // Returns the current class list, takes one away from the index because index 0 in the times list is before school, index 0 in the students list is 1st period, therefore if you take one away, it will get the current period
                }
                else
                {
                    return new List<string>(); // If it is the weekend, before, or after school it will return an empty list
                }
            }
            catch
            {
                return new List<string>(); // If an error occurs, such as no file saved at that time, it will return an empty list
            }
        }

        private void WriteClass(List<string> names)
        {
            List<List<List<string>>> classData = GetAllData(); // Gets all the student data

            int[] times = { 510, 575, 630, 675, 730, 820, 875, 930, 990, 1440 }; // A list of the times when different periods start, calculated by 60*hours + minuites
            int timeNum = int.Parse(DateTime.Now.ToString("HH")) * 60 + int.Parse(DateTime.Now.ToString("mm")); // A calculation of the current time num, calculated by 60*hours + minuites
            int ind = 0;  // Index of the lesson in the array
            string result = ""; // Final result of the changed values

            foreach (int item in times) // Iterating through the times when lessons start
            {
                if (timeNum < item) // If the current time value is less than the one in the time list, then it must be in that lesson
                {
                    ind = Array.IndexOf(times, item); // Gets the index of the number that the current time value is smaller than
                    break;
                }
            }

            if (ind != 0 & ind != 9 & (int)(DateTime.Now.DayOfWeek + 6) % 7 < 5) // Checks if it is not before school hours (ind != 0), if it is not after school hours (ind != 13), and if it isn't the weekend ((int)(DateTime.Now.DayOfWeek+6)%7 <5)
            {
                classData[(int)(DateTime.Now.DayOfWeek + 6) % 7][ind - 1] = names; // Changes the relavent value of the list to the new lsit 
            }

            foreach (List<List<string>> day in classData) // Iterates through the days
            {
                foreach (List<string> period in day) // Iterates through the periods
                {
                    foreach (string student in period) // Iterates throught the students
                    {
                        if (student != period.Last()) // If the student is not the last student in the class
                        {
                            result += student + ","; // Add the student's name and a comma to the final result
                        }
                        else // If the student is the last student in the class
                        {
                            result += student; // Add just the student's name to the final result
                        }
                    }
                    if (period != day.Last()) // If the period isn't the last one of the day
                    {
                        result += "@"; // Write a '@' to the end to signify the end of that period
                    }
                }
                if (day != classData.Last()) // If the day isn't the last day of the school week
                {
                    result += Environment.NewLine; // Write a newline to the end to signify the end of the day
                }
            }
            File.WriteAllText("classes.utc", result); // Write the result to the file
        }

        private void load()
        {
            if (!File.Exists("classes.utc"))
            {
                var file = File.Create("classes.utc");
                file.Close();
                File.WriteAllText("classes.utc", "@@@@@@@\r\n@@@@@@@\r\n@@@@@@@\r\n@@@@@@@\r\n@@@@@@@");

            }
            foreach (string student in LoadClass())
            {
                studentsBox.Items.Add(student);
                names.Add(student);
            }
        }

        private void addStudent_Click(object sender, EventArgs e)
        {
            AddStudent();
        }

        private void loadClass_Click(object sender, EventArgs e)
        {
            getStudents();
        }

        private void saveClass_Click(object sender, EventArgs e)
        {
            WriteClass(names);
        }

        private void clearStudents_Click(object sender, EventArgs e)
        {
            names.Clear();
            studentsBox.Items.Clear();
            resultsLabel.Text = "";
        }

        private void resetStudents_Click(object sender, EventArgs e)
        {
            studentsBox.Items.Clear();
            foreach (string name in names)
            {
                studentsBox.Items.Add(name);
            }
            resultsLabel.Text = "";
        }

        private void studentsBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = studentsBox.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                studentsBox.Items.RemoveAt(index);
            }
        }

        private void addStudentsBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddStudent();
            }
        }
    }
}
