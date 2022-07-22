namespace timerFormMain
{
    partial class Form1
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
            this.add30secs = new System.Windows.Forms.Button();
            this.add1min = new System.Windows.Forms.Button();
            this.add3mins = new System.Windows.Forms.Button();
            this.add5mins = new System.Windows.Forms.Button();
            this.StartStop = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.timerBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.switchMode = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // add30secs
            // 
            this.add30secs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.add30secs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.add30secs.FlatAppearance.BorderSize = 2;
            this.add30secs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add30secs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add30secs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.add30secs.Location = new System.Drawing.Point(25, 76);
            this.add30secs.Name = "add30secs";
            this.add30secs.Size = new System.Drawing.Size(200, 35);
            this.add30secs.TabIndex = 0;
            this.add30secs.Text = "+30 secs";
            this.add30secs.UseVisualStyleBackColor = false;
            this.add30secs.Click += new System.EventHandler(this.add30secs_Click);
            // 
            // add1min
            // 
            this.add1min.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.add1min.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.add1min.FlatAppearance.BorderSize = 2;
            this.add1min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add1min.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add1min.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.add1min.Location = new System.Drawing.Point(25, 117);
            this.add1min.Name = "add1min";
            this.add1min.Size = new System.Drawing.Size(200, 35);
            this.add1min.TabIndex = 1;
            this.add1min.Text = "+1 min";
            this.add1min.UseVisualStyleBackColor = false;
            this.add1min.Click += new System.EventHandler(this.add1min_Click);
            // 
            // add3mins
            // 
            this.add3mins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.add3mins.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.add3mins.FlatAppearance.BorderSize = 2;
            this.add3mins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add3mins.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add3mins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.add3mins.Location = new System.Drawing.Point(25, 158);
            this.add3mins.Name = "add3mins";
            this.add3mins.Size = new System.Drawing.Size(200, 35);
            this.add3mins.TabIndex = 2;
            this.add3mins.Text = "+3 mins";
            this.add3mins.UseVisualStyleBackColor = false;
            this.add3mins.Click += new System.EventHandler(this.add3mins_Click);
            // 
            // add5mins
            // 
            this.add5mins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.add5mins.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.add5mins.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.add5mins.FlatAppearance.BorderSize = 2;
            this.add5mins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add5mins.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add5mins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.add5mins.Location = new System.Drawing.Point(25, 199);
            this.add5mins.Name = "add5mins";
            this.add5mins.Size = new System.Drawing.Size(200, 35);
            this.add5mins.TabIndex = 3;
            this.add5mins.Text = "+5 mins";
            this.add5mins.UseVisualStyleBackColor = false;
            this.add5mins.Click += new System.EventHandler(this.add5mins_Click);
            // 
            // StartStop
            // 
            this.StartStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.StartStop.FlatAppearance.BorderSize = 0;
            this.StartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStop.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartStop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.StartStop.Location = new System.Drawing.Point(89, 427);
            this.StartStop.Name = "StartStop";
            this.StartStop.Size = new System.Drawing.Size(222, 50);
            this.StartStop.TabIndex = 4;
            this.StartStop.Text = "Start";
            this.StartStop.UseVisualStyleBackColor = false;
            this.StartStop.Click += new System.EventHandler(this.stopStart_Click);
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.reset.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.reset.FlatAppearance.BorderSize = 0;
            this.reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.reset.Location = new System.Drawing.Point(89, 65);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(222, 50);
            this.reset.TabIndex = 5;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // timerBox
            // 
            this.timerBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.timerBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timerBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.timerBox.Location = new System.Drawing.Point(161, 248);
            this.timerBox.Multiline = true;
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(140, 40);
            this.timerBox.TabIndex = 6;
            this.timerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timerBox_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(51, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 300);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // switchMode
            // 
            this.switchMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.switchMode.FlatAppearance.BorderSize = 0;
            this.switchMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchMode.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.switchMode.Location = new System.Drawing.Point(463, 414);
            this.switchMode.Name = "switchMode";
            this.switchMode.Size = new System.Drawing.Size(245, 73);
            this.switchMode.TabIndex = 8;
            this.switchMode.Text = "Stopwatch";
            this.switchMode.UseVisualStyleBackColor = false;
            this.switchMode.Click += new System.EventHandler(this.switchMode_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.panel1.Location = new System.Drawing.Point(413, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 450);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.add3mins);
            this.panel2.Controls.Add(this.add1min);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.add5mins);
            this.panel2.Controls.Add(this.add30secs);
            this.panel2.Location = new System.Drawing.Point(463, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(245, 300);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(56, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Time";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.button1.Location = new System.Drawing.Point(25, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "+10 mins";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(763, 552);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.switchMode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.StartStop);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add30secs;
        private System.Windows.Forms.Button add1min;
        private System.Windows.Forms.Button add3mins;
        private System.Windows.Forms.Button add5mins;
        private System.Windows.Forms.Button StartStop;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox timerBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button switchMode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

