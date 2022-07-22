namespace Teacher_Toolkit
{
    partial class Timers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimersPanel = new System.Windows.Forms.Panel();
            this.add10mins = new System.Windows.Forms.Button();
            this.add3mins = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.add1min = new System.Windows.Forms.Button();
            this.TimersTitle = new System.Windows.Forms.Label();
            this.AddTimeLabel = new System.Windows.Forms.Label();
            this.switchMode = new System.Windows.Forms.Button();
            this.add5mins = new System.Windows.Forms.Button();
            this.add30secs = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerBox = new System.Windows.Forms.TextBox();
            this.StartStop = new System.Windows.Forms.Button();
            this.TimersTimer = new System.Windows.Forms.Timer(this.components);
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimersPanel
            // 
            this.TimersPanel.Controls.Add(this.minimizeButton);
            this.TimersPanel.Controls.Add(this.closeButton);
            this.TimersPanel.Controls.Add(this.add10mins);
            this.TimersPanel.Controls.Add(this.add3mins);
            this.TimersPanel.Controls.Add(this.resetButton);
            this.TimersPanel.Controls.Add(this.add1min);
            this.TimersPanel.Controls.Add(this.TimersTitle);
            this.TimersPanel.Controls.Add(this.AddTimeLabel);
            this.TimersPanel.Controls.Add(this.switchMode);
            this.TimersPanel.Controls.Add(this.add5mins);
            this.TimersPanel.Controls.Add(this.add30secs);
            this.TimersPanel.Controls.Add(this.panel1);
            this.TimersPanel.Controls.Add(this.timerBox);
            this.TimersPanel.Controls.Add(this.StartStop);
            this.TimersPanel.Controls.Add(this.pictureBox1);
            this.TimersPanel.Location = new System.Drawing.Point(0, 0);
            this.TimersPanel.Name = "TimersPanel";
            this.TimersPanel.Size = new System.Drawing.Size(763, 552);
            this.TimersPanel.TabIndex = 15;
            this.TimersPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timerTB_MouseDown);
            this.TimersPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timerTB_MouseMove);
            this.TimersPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.timerTB_MouseUp);
            // 
            // add10mins
            // 
            this.add10mins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.add10mins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add10mins.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.add10mins.FlatAppearance.BorderSize = 0;
            this.add10mins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add10mins.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add10mins.ForeColor = System.Drawing.Color.White;
            this.add10mins.Location = new System.Drawing.Point(475, 330);
            this.add10mins.Name = "add10mins";
            this.add10mins.Size = new System.Drawing.Size(200, 35);
            this.add10mins.TabIndex = 4;
            this.add10mins.Text = "+10 mins";
            this.add10mins.UseVisualStyleBackColor = false;
            this.add10mins.Click += new System.EventHandler(this.add10mins_Click);
            // 
            // add3mins
            // 
            this.add3mins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.add3mins.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.add3mins.FlatAppearance.BorderSize = 0;
            this.add3mins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add3mins.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add3mins.ForeColor = System.Drawing.Color.White;
            this.add3mins.Location = new System.Drawing.Point(475, 248);
            this.add3mins.Name = "add3mins";
            this.add3mins.Size = new System.Drawing.Size(200, 35);
            this.add3mins.TabIndex = 2;
            this.add3mins.Text = "+3 mins";
            this.add3mins.UseVisualStyleBackColor = false;
            this.add3mins.Click += new System.EventHandler(this.add3mins_Click);
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.resetButton.FlatAppearance.BorderSize = 0;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.White;
            this.resetButton.Location = new System.Drawing.Point(104, 477);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(190, 50);
            this.resetButton.TabIndex = 30;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.reset_Click);
            // 
            // add1min
            // 
            this.add1min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.add1min.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.add1min.FlatAppearance.BorderSize = 0;
            this.add1min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add1min.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add1min.ForeColor = System.Drawing.Color.White;
            this.add1min.Location = new System.Drawing.Point(475, 207);
            this.add1min.Name = "add1min";
            this.add1min.Size = new System.Drawing.Size(200, 35);
            this.add1min.TabIndex = 1;
            this.add1min.Text = "+1 min";
            this.add1min.UseVisualStyleBackColor = false;
            this.add1min.Click += new System.EventHandler(this.add1min_Click);
            // 
            // TimersTitle
            // 
            this.TimersTitle.AutoSize = true;
            this.TimersTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TimersTitle.Font = new System.Drawing.Font("Nirmala UI", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimersTitle.ForeColor = System.Drawing.Color.White;
            this.TimersTitle.Location = new System.Drawing.Point(35, 26);
            this.TimersTitle.Name = "TimersTitle";
            this.TimersTitle.Size = new System.Drawing.Size(330, 52);
            this.TimersTitle.TabIndex = 29;
            this.TimersTitle.Text = "Countdown Timer";
            // 
            // AddTimeLabel
            // 
            this.AddTimeLabel.AutoSize = true;
            this.AddTimeLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTimeLabel.ForeColor = System.Drawing.Color.White;
            this.AddTimeLabel.Location = new System.Drawing.Point(506, 112);
            this.AddTimeLabel.Name = "AddTimeLabel";
            this.AddTimeLabel.Size = new System.Drawing.Size(135, 32);
            this.AddTimeLabel.TabIndex = 0;
            this.AddTimeLabel.Text = "Add Time";
            // 
            // switchMode
            // 
            this.switchMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.switchMode.FlatAppearance.BorderSize = 0;
            this.switchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchMode.Font = new System.Drawing.Font("Nirmala UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchMode.ForeColor = System.Drawing.Color.White;
            this.switchMode.Location = new System.Drawing.Point(456, 427);
            this.switchMode.Name = "switchMode";
            this.switchMode.Size = new System.Drawing.Size(245, 73);
            this.switchMode.TabIndex = 14;
            this.switchMode.Text = "Stopwatch";
            this.switchMode.UseVisualStyleBackColor = false;
            this.switchMode.Click += new System.EventHandler(this.switchMode_Click);
            // 
            // add5mins
            // 
            this.add5mins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.add5mins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add5mins.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.add5mins.FlatAppearance.BorderSize = 0;
            this.add5mins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add5mins.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add5mins.ForeColor = System.Drawing.Color.White;
            this.add5mins.Location = new System.Drawing.Point(475, 289);
            this.add5mins.Name = "add5mins";
            this.add5mins.Size = new System.Drawing.Size(200, 35);
            this.add5mins.TabIndex = 3;
            this.add5mins.Text = "+5 mins";
            this.add5mins.UseVisualStyleBackColor = false;
            this.add5mins.Click += new System.EventHandler(this.add5mins_Click);
            // 
            // add30secs
            // 
            this.add30secs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.add30secs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.add30secs.FlatAppearance.BorderSize = 0;
            this.add30secs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add30secs.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add30secs.ForeColor = System.Drawing.Color.White;
            this.add30secs.Location = new System.Drawing.Point(475, 166);
            this.add30secs.Name = "add30secs";
            this.add30secs.Size = new System.Drawing.Size(200, 35);
            this.add30secs.TabIndex = 0;
            this.add30secs.Text = "+30 secs";
            this.add30secs.UseVisualStyleBackColor = false;
            this.add30secs.Click += new System.EventHandler(this.add30secs_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(401, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 430);
            this.panel1.TabIndex = 15;
            // 
            // timerBox
            // 
            this.timerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.timerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.timerBox.Location = new System.Drawing.Point(104, 230);
            this.timerBox.Multiline = true;
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(176, 40);
            this.timerBox.TabIndex = 12;
            this.timerBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.timerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timerBox_KeyDown);
            // 
            // StartStop
            // 
            this.StartStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.StartStop.FlatAppearance.BorderSize = 0;
            this.StartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStop.Font = new System.Drawing.Font("Nirmala UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStop.ForeColor = System.Drawing.Color.White;
            this.StartStop.Location = new System.Drawing.Point(104, 419);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(190, 50);
            this.StartStop.TabIndex = 11;
            this.StartStop.Text = "Start";
            this.StartStop.UseVisualStyleBackColor = false;
            this.StartStop.Click += new System.EventHandler(this.StartStop_Click);
            // 
            // TimersTimer
            // 
            this.TimersTimer.Tick += new System.EventHandler(this.TimersTimer_Tick);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minimizeButton.Location = new System.Drawing.Point(695, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(38, 31);
            this.minimizeButton.TabIndex = 52;
            this.minimizeButton.Text = "—";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.Location = new System.Drawing.Point(723, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 31);
            this.closeButton.TabIndex = 51;
            this.closeButton.Text = "✖";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // timer1
            // 
            //this.timer1.Tick += new System.EventHandler(this.ColourTimer);
            // 
            // Timers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(763, 552);
            this.Controls.Add(this.TimersPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Timers";
            this.Text = "Timers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Timers_FormClosing);
            this.TimersPanel.ResumeLayout(false);
            this.TimersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TimersPanel;
        private System.Windows.Forms.Button add10mins;
        private System.Windows.Forms.Button add3mins;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button add1min;
        private System.Windows.Forms.Label TimersTitle;
        private System.Windows.Forms.Label AddTimeLabel;
        private System.Windows.Forms.Button switchMode;
        private System.Windows.Forms.Button add5mins;
        private System.Windows.Forms.Button add30secs;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox timerBox;
        private System.Windows.Forms.Button StartStop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer TimersTimer;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Timer timer1;
    }
}