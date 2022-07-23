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
        static public string penCol;
        Pen arcPen = new Pen(Color.FromArgb(255, 203, 112), 5);

        static public List<string> currentColourScheme = new List<string>();
        static public int theme = 2;
        int currentTheme = 10;

        List<string> OtherPannelColour = new List<string>() { "FFCB70", "F7B064", "0E0E0E", "999999", "3E5638" };
        List<string> pannelColour = new List<string>() { "3B2F4C", "31909B", "151515", "D6D6D6", "243120" };
        List<string> backgroundColour = new List<string>() { "3B2F4C", "31909B", "151515", "D6D6D6", "243120" };
        List<string> buttonBackground = new List<string>() { "4F3E65", "3BADBA", "1b1b1b", "999999", "80A677" };
        List<string> fontColour = new List<string>() { "FFCB70", "F7B064", "FFFFFF", "333333", "DDDDDD" };

        //declare here
        public TeacherToolkit()
        {
            InitializeComponent();
            //Size formsize = new Size(951, 577);
            //Size FormSize = new Size(951, 577);
            //Form1.Size = FormSize;

            //init here! 

            g = WhiteBoardPanel.CreateGraphics();
            p.SetLineCap(LineCap.Round, LineCap.Round, DashCap.Round);
            this.AllowDrop = true;
            this.DragEnter += new DragEventHandler(Form1_DragEnter);
            this.DragDrop += new DragEventHandler(Form1_DragDrop);
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
            load();
            ColourThemeComboBox.SelectedIndex = 2;
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
            //button.BackColor = HighLightedButton;
            panel.Location = new Point(188, 25);
            panel.Show();
            //Console.WriteLine("Panel Indication Ran");
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
        /*
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
        */
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
        /*
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
                //LightDarkModeToggleButton.BackColor = Color.FromArgb(255, 255, 255);
                //LightDarkModeToggleButton.ForeColor = Color.FromArgb(0, 0, 0);
                //LightDarkModeToggleButton.Text = "Dark Mode";
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
                //LightDarkModeToggleButton.BackColor = Color.FromArgb(21, 21, 21);
                //LightDarkModeToggleButton.ForeColor = Color.FromArgb(255, 255, 255);
                //LightDarkModeToggleButton.Text = "Light Mode";
                DarkMode = true;
                Logo.Image = Properties.Resources.Logo;
            }
        Skip:;
        }
        */

        //
        // Timers
        //
        int countdown = 0;
        int original = 1;
        bool countdownEnabled = true;
        private void TimersTimer_Tick(object sender, EventArgs e)
        {
            updateTimer();
        }

        private void add30secs_Click(object sender, EventArgs e)
        {
            addTime(add30secs);
        }

        private void add1min_Click(object sender, EventArgs e)
        {
            addTime(add1min);
        }

        private void add5mins_Click(object sender, EventArgs e)
        {
            addTime(add5mins);
        }
        private void add10mins_Click(object sender, EventArgs e)
        {
            addTime(add10mins);
        }

        private void StartStop_Click(object sender, EventArgs e)
        {
            startStopFunc();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            resetTimer();
        }

        private void add3mins_Click(object sender, EventArgs e)
        {
            addTime(add3mins);
        }

        private void startStopFunc()
        {
            if (countdown > 0 && countdownEnabled)
            {
                if (TimersTimer.Enabled)
                {
                    TimersTimer.Enabled = false;
                    StartStop.Text = "▶ Start";
                }
                else
                {
                    TimersTimer.Enabled = true;
                    StartStop.Text = "■ Stop";
                    original = countdown;
                }
            }
            else
            {
                if (TimersTimer.Enabled)
                {
                    TimersTimer.Enabled = false;
                    StartStop.Text = "▶ Start";
                }
                else
                {
                    TimersTimer.Enabled = true;
                    StartStop.Text = "■ Stop";
                }
            }
        }

        private void updateTimer()
        {
            if (countdownEnabled) countdown -= 1;
            else countdown += 1;

            if (countdownEnabled) timerBox.Text = (countdown / 10 / 60).ToString("00") + ":" + (countdown / 10 % 60).ToString("00");
            else timerBox.Text = (countdown / 10 / 60).ToString("00") + ":" + (countdown / 10 % 60).ToString("00") + "." + (countdown % 10);
            if (countdown <= 0f)
            {
                TimersTimer.Enabled = false;
                StartStop.Text = "▶ Start";
            }
            //Console.WriteLine((countdown / 60).ToString("00") + ":" + (countdown % 60).ToString("00"));
            Refresh();
        }


        private void addTime(Button sender)
        {
            int amount;
            if (sender == add30secs) amount = 30;
            else amount = Convert.ToInt32(sender.Text.Replace(" secs", "").Replace(" mins", "").Replace(" min", "").Replace("+", "")) * 60;
            countdown += amount * 10;
            timerBox.Text = (countdown / 600).ToString("00") + ":" + (countdown / 10 % 60).ToString("00");
            original += amount * 10;
            if (countdown < 0)
            {
                countdown = 0;
            }
        }

        private void resetTimer()
        {
            TimersTimer.Enabled = false;
            countdown = 0;
            timerBox.Text = "00:00";
            StartStop.Text = "▶ Start";
            Refresh();
        }

        private void timerBox_KeyDown(object sender, KeyEventArgs e)
        {
            enterValue(e);
        }

        private void enterValue(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try { countdown = Convert.ToInt32(timerBox.Text) * 6000; startStopFunc(); }
                catch { }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            drawCircle(e);
        }

        private void drawCircle(PaintEventArgs e)
        {
            
            if (countdown == 0) e.Graphics.DrawArc(arcPen, new Rectangle(25, 25, 250, 250), 0, 360);
            e.Graphics.DrawArc(arcPen, new Rectangle(25, 25, 250, 250), -90, 360 * ((float)countdown / (float)original));
        }

        private void switchMode_Click(object sender, EventArgs e)
        {
            if (countdownEnabled)
            {
                switchMode.Text = "Countdown";
                TimersTitle.Text = "Stopwatch";
                countdownEnabled = false;
                add1min.Enabled = false;
                add30secs.Enabled = false;
                add3mins.Enabled = false;
                add5mins.Enabled = false;
                add10mins.Enabled = false;
                pictureBox1.Hide();
            }
            else
            {
                switchMode.Text = "Stopwatch";
                TimersTitle.Text = "Countdown Timer";
                countdownEnabled = true;
                add1min.Enabled = true;
                add30secs.Enabled = true;
                add3mins.Enabled = true;
                add5mins.Enabled = true;
                add10mins.Enabled = true;
                pictureBox1.Show();
            }
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
        // Rewards Points
        //
        /*
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
        }*/

        //
        // Seating Plan Generator
        //
        /*
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
        */
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
                //LightDarkModeToggleButton.Hide();
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
                //LightDarkModeToggleButton.Show();
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
        int rCol;
        int gCol;
        int bCol;
        int schemeInd;
        bool isBorL = false; // button or label

        private void changeControlCols(Control cont)
        {
            isBorL = false;
            if (cont.GetType() == typeof(Button) || cont.GetType() == typeof(TextBox) || cont.GetType() == typeof(ListBox) || cont.GetType() == typeof(ComboBox))
            {
                schemeInd = 2;
                isBorL = true;
            }
            else if (cont.GetType() == typeof(Label))
            {
                schemeInd = 3;
                isBorL = true;
            }



            if (isBorL)
            {
                rCol = Convert.ToInt32(currentColourScheme[schemeInd].Substring(0, 2), 16);
                gCol = Convert.ToInt32(currentColourScheme[schemeInd].Substring(2, 2), 16);
                bCol = Convert.ToInt32(currentColourScheme[schemeInd].Substring(4, 2), 16);
                cont.BackColor = Color.FromArgb(rCol, gCol, bCol);
                rCol = Convert.ToInt32(currentColourScheme[1].Substring(0, 2), 16);
                gCol = Convert.ToInt32(currentColourScheme[1].Substring(2, 2), 16);
                bCol = Convert.ToInt32(currentColourScheme[1].Substring(4, 2), 16);
                cont.ForeColor = Color.FromArgb(rCol, gCol, bCol);
            }

            else if (cont.GetType() == typeof(Panel))
            {
                if (cont.Name == "ClockPanel" || cont.Name == "Navigation")
                {
                    schemeInd = 4;
                }
                else
                {
                    schemeInd = 0;
                }
                rCol = Convert.ToInt32(currentColourScheme[schemeInd].Substring(0, 2), 16);
                gCol = Convert.ToInt32(currentColourScheme[schemeInd].Substring(2, 2), 16);
                bCol = Convert.ToInt32(currentColourScheme[schemeInd].Substring(4, 2), 16);
                cont.BackColor = Color.FromArgb(rCol, gCol, bCol);
            }


            //pen colour change
            int penRCol;
            int penGCol;
            int penBCol;
            penRCol = Convert.ToInt32(currentColourScheme[4].Substring(0, 2), 16);
            penGCol = Convert.ToInt32(currentColourScheme[4].Substring(2, 2), 16);
            penBCol = Convert.ToInt32(currentColourScheme[4].Substring(4, 2), 16);
            
            arcPen.Color = Color.FromArgb(penRCol, penGCol, penBCol);
        }
        /*
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
        */
        bool timersShown = false;
        bool rsgShown = false;
        bool rngShown = false;
        public void changeColours()
        {
            //Console.WriteLine("called");
            foreach (Control cont in Controls)
            {
                changeControlCols(cont);
            }

            this.BackColor = Color.FromArgb(Convert.ToInt32(TeacherToolkit.currentColourScheme[3].Substring(0, 2), 16), Convert.ToInt32(TeacherToolkit.currentColourScheme[3].Substring(2, 2), 16), Convert.ToInt32(TeacherToolkit.currentColourScheme[3].Substring(4, 2), 16));
            foreach (var panel in this.Controls.OfType<Panel>()) //No idea what this was meant to do, add it back in if it had some functionality I missed -Ja
            {
                foreach (Control cont in panel.Controls)
                {
                    changeControlCols(cont);


                }

            }
            if(timersShown == true)
            {
                foreach (Control cont in timers.Controls)
                {
                    changeControlCols(cont);
                }
                foreach (var panel in timers.Controls.OfType<Panel>())
                {
                    foreach(Control cont in panel.Controls)
                    {
                        changeControlCols(cont);
                    } 
                }
            }
            if(rsgShown == true)
            {
                foreach (Control cont in rsg.Controls)
                {
                    changeControlCols(cont);
                }
                foreach (var panel in rsg.Controls.OfType<Panel>())
                {
                    foreach (Control cont in panel.Controls)
                    {
                        changeControlCols(cont);
                    }
                }
                
            }
            if(rngShown == true)
            {
                foreach (Control cont in rng.Controls)
                {
                    changeControlCols(cont);
                }
                foreach (var panel in rng.Controls.OfType<Panel>())
                {
                    foreach (Control cont in panel.Controls)
                    {
                        changeControlCols(cont);
                    }
                }
            }
            
            

        }

        public static bool TimersPanelShow = true;
        Timers timers;
        public static bool RandomPanelShow = true;
        RandomNumberGenerator rng;
        public static bool RandomStudentPanelShow = true;
        RandomStudentForm rsg;
        

        private void TimersPopOutButton_Click(object sender, EventArgs e)
        {
            TimersPanel.Hide();
            timers = new Timers();
            timers.Show();
            timersShown = true;
            changeColours();
            TimersPanelShow = false;
        }
        private void RandomNumberGeneratorPopOutButton_Click(object sender, EventArgs e)
        {
            RandomNumberGeneratorPanel.Hide();
            rng = new RandomNumberGenerator();
            rng.Show();
            rngShown = true;
            changeColours();
            RandomPanelShow = false;
        }


        private void popOutRandomStudent_Click(object sender, EventArgs e)
        {
            RandomStudentPanel.Hide();
            rsg = new RandomStudentForm();
            rsg.Show();
            rsgShown = true;
            changeColours();
            RandomStudentPanelShow = false;
        }

        private void CheckPop_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Check pOP");
            if (TimersPanelShow == true)
            {
                try
                {
                    timers.Hide();
                    TimersPanel.Show();
                    timersShown = false;
                    //Console.WriteLine("Shown");
                }
                catch { }
            }
            if (RandomPanelShow)
            {
                try
                {
                    rng.Hide();
                    RandomNumberGeneratorPanel.Show();
                    rngShown = false;
                    PanelIndication(RandomNumberGeneratorButton, RandomNumberGeneratorPanel);
                }
                catch (Exception ex)
                { //Console.WriteLine(ex); }
                }
            }
            if (RandomStudentPanelShow)
            {
                try
                {
                    rsg.Hide();
                    RandomStudentPanel.Show();
                    rsgShown = false;
                    PanelIndication(RandomStudentButton, RandomStudentPanel);
                }
                catch (Exception ex)
                { //Console.WriteLine(ex); }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ColourThemeComboBox.SelectedIndex == 0)
            {
                theme = 0;
                currentColourScheme.Clear();
            }

            if (ColourThemeComboBox.SelectedIndex == 1)
            {
                theme = 1;
                currentColourScheme.Clear();
            }

            if (ColourThemeComboBox.SelectedIndex == 2)
            {
                theme = 2;
                currentColourScheme.Clear();
            }

            if (ColourThemeComboBox.SelectedIndex == 3)
            {
                theme = 3;
                currentColourScheme.Clear();
            }

            if (ColourThemeComboBox.SelectedIndex == 4)
            {
                theme = 4;
                currentColourScheme.Clear();
            }

            currentColourScheme.Add(pannelColour[theme]);
            currentColourScheme.Add(fontColour[theme]);
            currentColourScheme.Add(buttonBackground[theme]);
            currentColourScheme.Add(backgroundColour[theme]);
            currentColourScheme.Add(OtherPannelColour[theme]);

            colourChangeTImer.Enabled = true;
        }

        private void colourChangeTImer_Tick(object sender, EventArgs e)
        {
            if (TeacherToolkit.theme == 0)
            {
                if (currentTheme != TeacherToolkit.theme)
                {
                    currentTheme = TeacherToolkit.theme;
                    //Console.WriteLine("Theme 1 selected");
                    changeColours();
                }

            }
            if (TeacherToolkit.theme == 1)
            {
                if (currentTheme != TeacherToolkit.theme)
                {
                    currentTheme = TeacherToolkit.theme;
                    //Console.WriteLine("Theme 2 selected");
                    changeColours();
                }

            }
            if (TeacherToolkit.theme == 2)
            {
                if (currentTheme != TeacherToolkit.theme)
                {
                    currentTheme = TeacherToolkit.theme;
                    //Console.WriteLine("Theme 3 selected");
                    changeColours();
                }

            }
            if (TeacherToolkit.theme == 3)
            {
                if (currentTheme != TeacherToolkit.theme)
                {
                    currentTheme = TeacherToolkit.theme;
                    //Console.WriteLine("Theme 4 selected");
                    changeColours();
                }

            }
            if (TeacherToolkit.theme == 4)
            {
                if (currentTheme != TeacherToolkit.theme)
                {
                    currentTheme = TeacherToolkit.theme;
                    //Console.WriteLine("Theme 5 selected");
                    changeColours();
                }
            }
        }

        private void openEmailButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://outlook.office.com/mail/deeplink/compose?to=e88c63f3.utcsheffield.org.uk@emea.teams.ms&subject=Teacher%20Toolkit%20-%20" + Environment.UserName);
        }

        // Random Student

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

        private void resultsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}