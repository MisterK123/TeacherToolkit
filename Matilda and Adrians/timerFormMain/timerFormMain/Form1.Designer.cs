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
            this.stopStart = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.timerBox = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // add30secs
            // 
            this.add30secs.Location = new System.Drawing.Point(81, 152);
            this.add30secs.Name = "add30secs";
            this.add30secs.Size = new System.Drawing.Size(75, 23);
            this.add30secs.TabIndex = 0;
            this.add30secs.Text = "+30 secs";
            this.add30secs.UseVisualStyleBackColor = true;
            this.add30secs.Click += new System.EventHandler(this.add30secs_Click);
            // 
            // add1min
            // 
            this.add1min.Location = new System.Drawing.Point(132, 95);
            this.add1min.Name = "add1min";
            this.add1min.Size = new System.Drawing.Size(75, 23);
            this.add1min.TabIndex = 1;
            this.add1min.Text = "+1 min";
            this.add1min.UseVisualStyleBackColor = true;
            this.add1min.Click += new System.EventHandler(this.add1min_Click);
            // 
            // add3mins
            // 
            this.add3mins.Location = new System.Drawing.Point(294, 56);
            this.add3mins.Name = "add3mins";
            this.add3mins.Size = new System.Drawing.Size(75, 23);
            this.add3mins.TabIndex = 2;
            this.add3mins.Text = "+3 mins";
            this.add3mins.UseVisualStyleBackColor = true;
            this.add3mins.Click += new System.EventHandler(this.add3mins_Click);
            // 
            // add5mins
            // 
            this.add5mins.Location = new System.Drawing.Point(283, 152);
            this.add5mins.Name = "add5mins";
            this.add5mins.Size = new System.Drawing.Size(75, 23);
            this.add5mins.TabIndex = 3;
            this.add5mins.Text = "+5 mins";
            this.add5mins.UseVisualStyleBackColor = true;
            this.add5mins.Click += new System.EventHandler(this.add5mins_Click);
            // 
            // stopStart
            // 
            this.stopStart.Location = new System.Drawing.Point(132, 223);
            this.stopStart.Name = "stopStart";
            this.stopStart.Size = new System.Drawing.Size(75, 23);
            this.stopStart.TabIndex = 4;
            this.stopStart.Text = "stopStart";
            this.stopStart.UseVisualStyleBackColor = true;
            this.stopStart.Click += new System.EventHandler(this.stopStart_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(539, 258);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 5;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // timerBox
            // 
            this.timerBox.Location = new System.Drawing.Point(406, 47);
            this.timerBox.Name = "timerBox";
            this.timerBox.Size = new System.Drawing.Size(100, 20);
            this.timerBox.TabIndex = 6;
            this.timerBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.timerBox_KeyDown);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(283, 203);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.timerBox);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.stopStart);
            this.Controls.Add(this.add5mins);
            this.Controls.Add(this.add3mins);
            this.Controls.Add(this.add1min);
            this.Controls.Add(this.add30secs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add30secs;
        private System.Windows.Forms.Button add1min;
        private System.Windows.Forms.Button add3mins;
        private System.Windows.Forms.Button add5mins;
        private System.Windows.Forms.Button stopStart;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.TextBox timerBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

