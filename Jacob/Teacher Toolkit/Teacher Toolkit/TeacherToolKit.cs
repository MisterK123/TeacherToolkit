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
using System.Threading;
using System.Net.Mail;
using System.Drawing.Drawing2D;

namespace Teacher_Toolkit
{
    public partial class TeacherToolkit : Form
    {
        Random rnd = new Random();

        //declare here
        public TeacherToolkit()
        {
            InitializeComponent();
            //Size formsize = new Size(951, 577);
            //Size FormSize = new Size(951, 577);
            //Form1.Size = FormSize;

            //init here! 

            g = WhiteBoardPanel.CreateGraphics();
            p.SetLineCap(System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.LineCap.Round, System.Drawing.Drawing2D.DashCap.Round);
        }
        public void Form1_Load(object sender, EventArgs e)
        {
            ClockTimer.Enabled = true;
            PeriodCalculatorTimer.Enabled = true;
            this.Size = new Size(951, 577);
            HideAllTabs();
            SetPeriodTimes();
            SelectStudentWarning.Hide();
            PaintTimer.Enabled = true;
            CheckColourModeFunction();
            MakeFiles();
        }
        private void Clock_Tick(object sender, EventArgs e)
        {
            Clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }
        public void HideAllTabs()
        {
            foreach (var panel in this.Controls.OfType<Panel>())
            {
                if (panel == Navigation || panel == ClockPanel) continue;
                panel.Hide();
            }
        }
        string CheckLastStudentFile = @"CheckLastStudentFile.txt";
        private void MakeFiles()
        {
            if (File.Exists(CheckColourMode)) goto Skip;
            if (File.Exists(CheckColourMode) == false)
            {
                FileStream fs = File.Create(CheckColourMode);
                fs.Close();
            }
        Skip:;
            if (File.Exists(CheckLastStudentFile)) goto Skip1;
            if (File.Exists(CheckLastStudentFile) == false)
            {
                FileStream fs = File.Create(CheckLastStudentFile);
                fs.Close();
                StreamWriter writer = new StreamWriter(CheckColourMode);
                writer.WriteLine("dark");
                writer.Close();
            }
        Skip1:;
        }

        //
        // Window functions
        //
        private void MinimizeWindowButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        //
        // Navigation Functions
        //

        // Button Click Functions
        public void PanelIndication(Button button, Panel panel)
        {
            button.BackColor = HighLightedButton;
            panel.Location = new Point(188, 25);
            panel.Show();
            Console.WriteLine("Panel Indication Ran");
        }
        private void TimerButton_Click(object sender, EventArgs e)
        {
            HideAllTabs();
            PanelIndication(TimerButton, TimersPanel);
        }
        private void RandomNumberGeneratorButton_Click(object sender, EventArgs e)
        {
            HideAllTabs();
            PanelIndication(RandomNumberGeneratorButton, RandomNumberGeneratorPanel);
        }
        private void RandomStudent_Click(object sender, EventArgs e)
        {
            HideAllTabs();
            PanelIndication(RandomStudentButton, RandomStudentPanel);
        }
        private void RewardPointsButton_Click(object sender, EventArgs e)
        {
            HideAllTabs();
            PanelIndication(RewardPointsButton, RewardPointsPanel);
        }
        private void SeatingPlanGeneratorButton_Click(object sender, EventArgs e)
        {
            HideAllTabs();
            PanelIndication(SeatingPlanGeneratorButton, SeatingPlanGeneratorPanel);
        }
        private void WhiteBoardButton_Click(object sender, EventArgs e)
        {
            HideAllTabs();
            PanelIndication(WhiteBoardButton, WhiteBoardContainerPanel);
        }
        private void ExamTimerButton_Click(object sender, EventArgs e)
        {
            HideAllTabs();
            PanelIndication(ExamTimerButton, ExamTimerPanel);
        }
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            HideAllTabs();
            PanelIndication(SettingsButton, SettingsPanel);
        }

        // Leave Functions
        private void TimerButton_Leave(object sender, EventArgs e)
        {
            TimerButton.BackColor = HighLightedLeaveButton;
        }
        private void RandomNumberGeneratorButton_Leave(object sender, EventArgs e)
        {
            RandomNumberGeneratorButton.BackColor = HighLightedLeaveButton;
        }
        private void RandomStudent_Leave(object sender, EventArgs e)
        {
            RandomStudentButton.BackColor = HighLightedLeaveButton;
        }
        private void RewardPointsButton_Leave(object sender, EventArgs e)
        {
            RewardPointsButton.BackColor = HighLightedLeaveButton;
        }
        private void SeatingPlanGeneratorButton_Leave(object sender, EventArgs e)
        {
            SeatingPlanGeneratorButton.BackColor = HighLightedLeaveButton;
        }
        private void WhiteBoardButton_Leave(object sender, EventArgs e)
        {
            WhiteBoardButton.BackColor = HighLightedLeaveButton;
        }
        private void SettingsButton_Leave(object sender, EventArgs e)
        {
            SettingsButton.BackColor = HighLightedLeaveButton;
        }

        // Drag Bar
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

        //
        // Period Calculator
        //
        string CurrentPeriod = "";
        DateTime ClassFinishTime = new DateTime();
        DateTime BeforeSchool;
        DateTime p1;
        DateTime p2;
        DateTime BreakOrTutor;
        DateTime p3;
        DateTime p4a;
        DateTime p4b;
        DateTime p4c;
        DateTime p5;
        DateTime p6;
        DateTime Enrichment;
        DateTime AfterSchool;
        void SetPeriodTimes()
        {
            DateTime CurrentTime = DateTime.Now;

            BeforeSchool = new DateTime(CurrentTime.Year, CurrentTime.Month, CurrentTime.Day, 00, 00, 00);
            p1 = new DateTime(CurrentTime.Year, CurrentTime.Month, CurrentTime.Day, 09, 30, 00);
            p2 = new DateTime(CurrentTime.Year, CurrentTime.Month, CurrentTime.Day, 10, 35, 00);
            BreakOrTutor = new DateTime(CurrentTime.Year, CurrentTime.Month, CurrentTime.Day, 11, 15, 00);
            p3 = new DateTime(CurrentTime.Year, CurrentTime.Month, CurrentTime.Day, 12, 10, 00);
            p4a = new DateTime(CurrentTime.Year, CurrentTime.Month, CurrentTime.Day, 12, 40, 00);
            p4b = new DateTime(CurrentTime.Year, CurrentTime.Month, CurrentTime.Day, 13, 10, 00);
            p4c = new DateTime(CurrentTime.Year, CurrentTime.Month, CurrentTime.Day, 13, 40, 00);
            p5 = new DateTime(CurrentTime.Year, CurrentTime.Month, CurrentTime.Day, 14, 35, 00);
            p6 = new DateTime(CurrentTime.Year, CurrentTime.Month, CurrentTime.Day, 15, 30, 00);
            Enrichment = new DateTime(CurrentTime.Year, CurrentTime.Month, CurrentTime.Day, 16, 30, 00);
            AfterSchool = new DateTime(CurrentTime.Year, CurrentTime.Month, CurrentTime.Day, 23, 59, 59);
        }
        void CheckPeriod()
        {
            DateTime ct = DateTime.Now;

            if (ct < BeforeSchool) { ClassFinishTime = BeforeSchool; CurrentPeriod = "Before School"; PeriodDisplay.Location = new Point(39, 111); }
            if (ct > BeforeSchool && ct < p1) { ClassFinishTime = p1; CurrentPeriod = "Period 1"; PeriodDisplay.Location = new Point(60, 111); }
            if (ct > p1 && ct < p2) { ClassFinishTime = p2; CurrentPeriod = "Period 2"; PeriodDisplay.Location = new Point(60, 111); }
            if (ct > p2 && ct < BreakOrTutor) { ClassFinishTime = p3; CurrentPeriod = "Break or Tutor"; PeriodDisplay.Location = new Point(39, 111); }
            if (ct > BreakOrTutor && ct < p3) { ClassFinishTime = BreakOrTutor; CurrentPeriod = "Period 3"; PeriodDisplay.Location = new Point(60, 111); }
            if (ct > p3 && ct < p4a) { ClassFinishTime = p4a; CurrentPeriod = "Period 4a"; PeriodDisplay.Location = new Point(55, 111); }
            if (ct > p4a && ct < p4b) { ClassFinishTime = p4b; CurrentPeriod = "Period 4b"; PeriodDisplay.Location = new Point(55, 111); }
            if (ct > p4b && ct < p4c) { ClassFinishTime = p4c; CurrentPeriod = "Period 4c"; PeriodDisplay.Location = new Point(55, 111); }
            if (ct > p4c && ct < p5) { ClassFinishTime = p5; CurrentPeriod = "Period 5"; PeriodDisplay.Location = new Point(60, 111); }
            if (ct > p5 && ct < p6) { ClassFinishTime = p6; CurrentPeriod = "Period 6"; PeriodDisplay.Location = new Point(60, 111); }
            if (ct > p6 && ct < Enrichment) { ClassFinishTime = Enrichment; CurrentPeriod = "Enrichment"; PeriodDisplay.Location = new Point(39, 111); }
            if (ct > Enrichment && ct < AfterSchool) { ClassFinishTime = BeforeSchool; CurrentPeriod = "After School"; PeriodDisplay.Location = new Point(48, 111); }

            PeriodDisplay.Text = CurrentPeriod;
        }
        private void PeriodCalculatorTimer_Tick(object sender, EventArgs e)
        {
            CheckPeriod();
        }

        //
        // Color Mode
        //
        Color HighLightedButton = new Color();
        Color HighLightedLeaveButton = new Color();
        //Light Mode
        Color LightTextColor = new Color();
        Color LightBackColor = new Color();
        Color LightNavigationColor = new Color();
        Color LightPanelColour = new Color();
        //DarkMode
        Color DarkForeColor = new Color();
        Color DarkBackColor = new Color();
        Color DarkNavigationBackColor = new Color();
        Color DarkPanelColor = new Color();

        string CheckColourMode = @"CheckColourMode.txt";
        bool DarkMode = true;
        private void CheckColourModeFunction()
        {
            StreamReader reader = new StreamReader(CheckColourMode);
            if (reader != null)
            {
                string Mode;
                Mode = reader.ReadLine();
                if (Mode == "dark")
                {
                    DarkMode = true;
                }
                if (Mode == "light")
                {
                    DarkMode = false;
                }
                reader.Close();
            }
        }
        private void LightDarkModeToggleButton_Click(object sender, EventArgs e)
        {
            //Light mode colours
            LightTextColor = Color.FromArgb(0, 0, 0);
            LightBackColor = Color.FromArgb(255, 255, 255);
            LightNavigationColor = Color.FromArgb(255, 255, 255);
            LightPanelColour = Color.FromArgb(253, 253, 253);
            //Dark mode Colours
            DarkForeColor = Color.FromArgb(255, 255, 255);
            DarkBackColor = Color.FromArgb(21, 21, 21);
            DarkNavigationBackColor = Color.FromArgb(14, 14, 14);
            DarkPanelColor = Color.FromArgb(21, 21, 21);

            if (DarkMode == true)
            {
                StreamWriter writer = new StreamWriter(CheckColourMode);
                writer.WriteLine("dark");
                writer.Close();
                this.BackColor = DarkForeColor;
                foreach (var panel in this.Controls.OfType<Panel>())
                {
                    panel.BackColor = DarkForeColor;
                    foreach (var button in panel.Controls.OfType<Button>())
                    {
                        button.BackColor = Color.FromArgb(251, 251, 251);
                        button.ForeColor = LightTextColor;
                    }
                    foreach (var label in panel.Controls.OfType<Label>())
                    {
                        label.BackColor = LightBackColor;
                        label.ForeColor = LightTextColor;
                    }
                    foreach (var textBox in panel.Controls.OfType<TextBox>())
                    {
                        textBox.BackColor = LightPanelColour;
                        textBox.ForeColor = LightTextColor;
                    }
                    foreach (var listBox in panel.Controls.OfType<ListBox>())
                    {
                        listBox.BackColor = LightBackColor;
                        listBox.ForeColor = LightTextColor;
                    }
                }
                Navigation.BackColor = LightNavigationColor;
                foreach (var label in ClockPanel.Controls.OfType<Label>())
                {
                    label.ForeColor = ForeColor;
                }
                foreach (var NavButton in Navigation.Controls.OfType<Button>())
                {
                    NavButton.BackColor = Color.FromArgb(255, 255, 255);
                }
                HighLightedButton = Color.FromArgb(251, 251, 251);
                HighLightedLeaveButton = Color.FromArgb(255, 255, 255);
                LightDarkModeToggleButton.BackColor = Color.FromArgb(255, 255, 255);
                LightDarkModeToggleButton.ForeColor = Color.FromArgb(0, 0, 0);
                LightDarkModeToggleButton.Text = "Dark Mode";
                DarkMode = false;
                Logo.Image = Properties.Resources.UTC_Sheffield_Olympic_Legacy_Park;
                goto Skip;
            }

            if (DarkMode == false)
            {
                StreamWriter writer = new StreamWriter(CheckColourMode);
                writer.WriteLine("light");
                writer.Close();
                this.BackColor = DarkBackColor;
                foreach (var panel in this.Controls.OfType<Panel>())
                {
                    panel.BackColor = DarkPanelColor;
                    foreach (var button in panel.Controls.OfType<Button>())
                    {
                        button.BackColor = Color.FromArgb(24, 24, 24);
                        button.ForeColor = DarkForeColor;
                    }
                    foreach (var label in panel.Controls.OfType<Label>())
                    {
                        label.BackColor = DarkBackColor;
                        label.ForeColor = DarkForeColor;
                    }
                    foreach (var textBox in panel.Controls.OfType<TextBox>())
                    {
                        textBox.BackColor = Color.FromArgb(27, 27, 27);
                        textBox.ForeColor = DarkForeColor;
                    }
                    foreach (var listBox in panel.Controls.OfType<ListBox>())
                    {
                        listBox.BackColor = Color.FromArgb(27, 27, 27);
                        listBox.ForeColor = DarkForeColor;
                    }
                }
                Navigation.BackColor = DarkNavigationBackColor;
                foreach (var label in ClockPanel.Controls.OfType<Label>())
                {
                    label.ForeColor = DarkForeColor;
                }
                foreach (var NavButton in Navigation.Controls.OfType<Button>())
                {
                    NavButton.BackColor = Color.FromArgb(14, 14, 14);
                }
                HighLightedButton = Color.FromArgb(21, 21, 21);
                HighLightedLeaveButton = Color.FromArgb(14, 14, 14);
                LightDarkModeToggleButton.BackColor = Color.FromArgb(21, 21, 21);
                LightDarkModeToggleButton.ForeColor = Color.FromArgb(255, 255, 255);
                LightDarkModeToggleButton.Text = "Light Mode";
                DarkMode = true;
                Logo.Image = Properties.Resources.Logo;
            }
        Skip:;
        }

        //
        // Countdown timer
        //
        float CountdownTimerNumber = 0;
        public void CountdownTimerStartButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (CountdownTimerDisplay.Text != "")
                {
                    CountdownTimerNumber = float.Parse(CountdownTimerDisplay.Text);
                    CountdownTimer.Enabled = true;
                }
                CountdownTimerDisplay.Text = "";
            }
            catch
            {
                CountdownTimerDisplay.Text = "Error";
            }
        }
        float StopwatchTimerNumber = 0;
        private void CountdownTimerStopButton_Click(object sender, EventArgs e)
        {
            CountdownTimer.Enabled = false;
        }
        private void CountdownTimerRestartButton_Click(object sender, EventArgs e)
        {
            CountdownTimer.Enabled = false;
            CountdownTimerNumber = 0f;
            CountdownTimerDisplay.Text = "";
        }
        System.Media.SoundPlayer Alarm = new System.Media.SoundPlayer(@"Alarm.wav");
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            CountdownTimerNumber -= CountdownTimer.Interval * 0.001f;
            CountdownTimerDisplay.Text = CountdownTimerNumber.ToString("0.0");

            if (CountdownTimerNumber < 0)
            {
                CountdownTimer.Enabled = false;
                CountdownTimerNumber = 0f;
                CountdownTimerDisplay.Text = "";
                if (Muted == false)
                {
                    Alarm.Play();
                }
            }
        }
        bool Muted = false;
        private void MuteTimerSoundButton_Click(object sender, EventArgs e)
        {
            if (Muted == false)
            {
                Muted = true;
                MuteTimerSoundButton.Text = "Unmute";
                goto Skip;
            }
            if (Muted == true)
            {
                Muted = false;
                MuteTimerSoundButton.Text = "Mute";
            }
        Skip:;
        }
        private void ThirtySecondsButton_Click(object sender, EventArgs e)
        {
            CountdownTimerNumber = 30f;
            CountdownTimer.Enabled = true;
        }
        private void OneMinuteButton_Click(object sender, EventArgs e)
        {
            CountdownTimerNumber = 60f;
            CountdownTimer.Enabled = true;
        }
        private void TwoMinuteButton_Click(object sender, EventArgs e)
        {
            CountdownTimerNumber = 120f;
            CountdownTimer.Enabled = true;
        }
        private void FiveMinutesButton_Click(object sender, EventArgs e)
        {
            CountdownTimerNumber = 300f;
            CountdownTimer.Enabled = true;
        }

        //
        // Stopwatch
        //
        private void StopwatchStartButton_Click(object sender, EventArgs e)
        {
            StopwatchTimer.Enabled = true;
        }
        private void StopwatchStopButton_Click(object sender, EventArgs e)
        {
            StopwatchTimer.Enabled = false;
        }
        private void StopwatchResetButton_Click(object sender, EventArgs e)
        {
            StopwatchTimer.Enabled = false;
            StopwatchTimerNumber = 0f;
            StopwatchDisplay.Text = "";
        }
        private void StopwatchTimer_Tick(object sender, EventArgs e)
        {
            StopwatchTimerNumber += StopwatchTimer.Interval * 0.001f;
            StopwatchDisplay.Text = StopwatchTimerNumber.ToString("0.0");
        }

        //
        // Random Number Generator
        //
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
        //
        // Random Student Picker
        //
        string StudentsFile;
        string CheckStudentFile = @"CheckLastStudentFile.txt";
        private void RandomStudentButton_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(CheckStudentFile);
            if (reader != null)
            {
                StudentsFile = reader.ReadLine();
            }
            reader.Close();
            try
            {
                string[] Student = System.IO.File.ReadAllLines(StudentsFile);
                int RandomisedStudent = rnd.Next(Student.Length);
                string RandomStudent = $"{Student[RandomisedStudent]}";
                RandomStudentDisplay.Text = RandomStudent;
                int index = Array.IndexOf(Student, RandomisedStudent);
            }
            catch
            {
                RandomStudentDisplay.Text = "Chose File";
            }
        }
        private void OpenStudentsFileButton_Click(object sender, EventArgs e)
        {
            if (StudentListDialog.ShowDialog() == DialogResult.OK)
            {
                StudentsFile = StudentListDialog.FileName;
                StreamWriter writer = new StreamWriter(CheckStudentFile);
                writer.WriteLine(StudentsFile);
                writer.Close();
            }
            if (StudentsFile == "")
            {
                RandomStudentDisplay.Text = "Chose File";
            }
        }

        //
        // Rewards Points
        //
        private void GiveRewardPointButton_Click(object sender, EventArgs e)
        {
            if (StudentsList.SelectedItem != null)
            {
                string StudentName = StudentsList.SelectedItem.ToString();
                string test = StudentsList.SelectedItem.ToString();
                RewardedStudents.AppendText(StudentName + "\r\n");
                SelectStudentWarning.Hide();
            }
            else
            {
                SelectStudentWarning.Show();
            }
        }
        private void LoadStudentsButton_Click(object sender, EventArgs e)
        {
            StreamReader reader1 = new StreamReader(CheckStudentFile);
            if (reader1 != null)
            {
                StudentsFile = reader1.ReadLine();
                reader1.Close();
            }
            try
            {
                RewardedStudents.Text = "";
                StudentsList.Items.Clear();
                using (StreamReader reader = new StreamReader(StudentsFile))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        StudentsList.Items.Add(line);
                    }
                }
            }
            catch
            {

            }
        }
        private void OpenFileLocationRewardsButton_Click(object sender, EventArgs e)
        {
            if (StudentListDialog.ShowDialog() == DialogResult.OK)
            {
                StudentsFile = StudentListDialog.FileName;
                StreamWriter writer = new StreamWriter(CheckStudentFile);
                writer.WriteLine(StudentsFile);
                writer.Close();
                SelectStudentWarning.Hide();
            }
            if (StudentsFile == "")
            {
                SelectStudentWarning.Text = "Chose File";
                SelectStudentWarning.Show();
            }
        }
        private void RewardPointsHelpButton_Click(object sender, EventArgs e)
        {
            RewardsPointHelpPanel.Location = new Point(187, 25);
            HideAllTabs();
            RewardsPointHelpPanel.Show();
        }
        private void RewardPointsHelpBackButton_Click(object sender, EventArgs e)
        {
            RewardPointsPanel.Location = new Point(187, 25);
            HideAllTabs();
            RewardPointsPanel.Show();
        }
        string RewardedStudentPath;
        DateTime now = DateTime.Now;
        private void ExportStudentButton_Click(object sender, EventArgs e)
        {
            if (RewardedStudentsFolderDialog.ShowDialog() == DialogResult.OK)
            {
                RewardedStudentPath = RewardedStudentsFolderDialog.SelectedPath;
                string Now = now.Year + ":" + now.Month + ":" + now.Day;
                RewardedStudentPath = RewardedStudentPath + Now;
                RewardPointsTitle.Text = RewardedStudentPath;
            }
            try
            {
                FileStream fs = File.Create(RewardedStudentPath);
                fs.Close();
                StreamWriter writer = new StreamWriter(RewardedStudentPath);
                writer.Write(RewardedStudents.Text);
                writer.Close();
            }
            catch { }
        }

        //
        // Seating Plan Generator
        //
        Pen WhitePen = new Pen(Color.White);
        Pen WhitePen2 = new Pen(Color.White);
        //Brush WhiteBrush = new Brush(Color.White);
        int Column = 1;
        int Row = 1;
        private void MakeLabels()
        {
            //private System.Windows.Forms.Label label;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int ColumnSeperationWidth = SeatingPlan.Width / Column;
            int ColumnBuffer = SeatingPlan.Width / Column;
            int RowSeperationHeight = SeatingPlan.Height / Row;
            int RowBuffer = SeatingPlan.Height / Row;


            while (ColumnBuffer < SeatingPlan.Width)
            {
                e.Graphics.DrawLine(WhitePen, ColumnBuffer, SeatingPlan.Height, ColumnBuffer, 0);
                ColumnBuffer = ColumnBuffer + ColumnSeperationWidth;
            }

            while (RowBuffer < SeatingPlan.Height)
            {
                e.Graphics.DrawLine(WhitePen2, SeatingPlan.Width, RowBuffer, 0, RowBuffer);
                RowBuffer = RowBuffer + RowSeperationHeight;
            }
            ColumnBuffer = 0;
            RowBuffer = 0;

            

            Label tempLabel = new Label();
            tempLabel.AutoSize = true;
            tempLabel.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tempLabel.ForeColor = System.Drawing.Color.White;
            tempLabel.BackColor = Color.White;
            tempLabel.Location = new System.Drawing.Point(100,100);
            tempLabel.Name = "A";
            tempLabel.Size = new System.Drawing.Size(100, 100);
            tempLabel.TabIndex = 10;
            tempLabel.Text = "A";
            tempLabel.Show();
            this.Controls.Add(tempLabel);

        }
        private void GenerateSeatingPlanButton_Click(object sender, EventArgs e)
        {
            StudentTextBox.Clear();
            Random rnd = new Random();
            try
            {
                int list = 1;
                Column = int.Parse(ColumnsInputBox.Text);
                Row = int.Parse(RowsInputBox.Text);
                int StudentAmount = Column * Row;
                int[] ClassList = new int[StudentAmount];
                for (int i = 0; i < Column * Row; i++)
                {
                    ClassList[i] = i;
                    //StudentTextBox.AppendText(ClassList[i].ToString());
                }
                for (int i = 0; i < StudentAmount; i++)
                {
                    int rnum = rnd.Next(0, StudentAmount);
                    int temp = ClassList[i];
                    ClassList[i] = ClassList[rnum];
                    ClassList[rnum] = temp;
                }
                for (int i = 0; i < StudentAmount; i++)
                {
                    int rnum = rnd.Next(0, StudentAmount);
                    StudentTextBox.AppendText(list.ToString() + ". ");
                    StudentTextBox.AppendText(ClassList[i].ToString() + "\r\n");
                    list++;
                }
            }
            catch
            {

            }
            Refresh();

        }

        //
        // Whiteboard
        //
        public Point current = new Point();
        public Point old = new Point();
        public Pen p = new Pen(Color.Black, 5);
        public Pen HoverPen = new Pen(Color.FromArgb(1,1,1), 5);
        public Graphics g;
        private void WhiteBoardPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                current = e.Location;
                g.DrawLine(p, old, current);
                old = current;
            }
            //g.DrawEllipse(p, current.X, current.Y, 1, );
            //g.Clear(Color.FromArgb(1,1,1));
        }

        private void WhiteBoardPanel_MouseDown(object sender, MouseEventArgs e)
        {
            old = e.Location;
            if (PenSizeTrackBar.Value == 1)
                p.Width = 1;
            else if (PenSizeTrackBar.Value == 2)
                p.Width = 5;
            else if (PenSizeTrackBar.Value == 3)
                p.Width = 10;
            else if (PenSizeTrackBar.Value == 4)
                p.Width = 15;
            else if (PenSizeTrackBar.Value == 5)
                p.Width = 30;
            else if (PenSizeTrackBar.Value == 6)
                p.Width = 45;
            else if (PenSizeTrackBar.Value == 7)
                p.Width = 60;
        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                p.Color = cd.Color;
        }

        private void ResetWhiteboardButton_Click(object sender, EventArgs e)
        {
            WhiteBoardPanel.Invalidate();
        }
        bool WhiteBoardMaximise = false;
        private void MaximiseWhiteboardButton_Click(object sender, EventArgs e)
        {
            if (WhiteBoardMaximise == false)
            {
                Navigation.Hide();
                this.WindowState = FormWindowState.Maximized;
                WhiteBoardContainerPanel.Location = new Point(0, 10);
                WhiteboardPropertiesPanel.Location = new Point(1815, 10);
                WhiteBoardContainerPanel.Size = new Size(2000, 1300);
                WhiteBoardPanel.Size = new Size(1800, 1300);
                LightDarkModeToggleButton.Hide();
                MinimizeWindowButton.Hide();
                ExitButton.Hide();
                WhiteBoardMaximise = true;
                g = WhiteBoardPanel.CreateGraphics();
                goto Skip;
            }
            if (WhiteBoardMaximise == true)
            {
                Navigation.Show();
                this.WindowState = FormWindowState.Normal;
                WhiteBoardContainerPanel.Location = new Point(185, 22);
                WhiteboardPropertiesPanel.Location = new Point(660, 9);
                WhiteBoardContainerPanel.Size = new Size(766, 552);
                WhiteBoardPanel.Size = new Size(645, 534);
                LightDarkModeToggleButton.Show();
                MinimizeWindowButton.Show();
                ExitButton.Show();
                WhiteBoardMaximise = false;
                g = WhiteBoardPanel.CreateGraphics();
            }
        Skip:;
        }
        Color Rubber = new Color();

        private void RubberButton_Click(object sender, EventArgs e)
        {
            Rubber = Color.FromArgb(255,255,255);
            p.Color = Rubber;
        }

        //
        // Exam Timer
        //
        float Hour;
        float Min;
        private void StartExamButton_Click(object sender, EventArgs e)
        {
            try
            {
                Hour = float.Parse(Hours.Text);
                Min = float.Parse(Minutes.Text);
                DateTime CurrentTime = DateTime.Now;
                //StartTime.Text = new DateTime(CurrentTime.Hour);
            }
            catch
            {

            }

        }

        public static bool TimersPanelShow = true;
        Timers timers;
        private void TimersPopOutButton_Click(object sender, EventArgs e)
        {
            TimersPanel.Hide();
            timers = new Timers();
            timers.Show();
            TimersPanelShow = false;
        }

        private void CheckPop_Tick(object sender, EventArgs e)
        {
            if(TimersPanelShow == true)
            {
                try
                {
                    timers.Hide();
                    TimersPanel.Show();
                }
                catch { }
            }
        }
    }
}