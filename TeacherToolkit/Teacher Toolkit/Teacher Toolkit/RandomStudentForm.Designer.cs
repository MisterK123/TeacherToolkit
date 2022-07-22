namespace Teacher_Toolkit
{
    partial class RandomStudentForm
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
            this.minimizeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.loadClassButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addStudentsBox = new System.Windows.Forms.TextBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.studentsBox = new System.Windows.Forms.ListBox();
            this.resetStudents = new System.Windows.Forms.Button();
            this.clearStudents = new System.Windows.Forms.Button();
            this.pickStudent = new System.Windows.Forms.Button();
            this.saveClass = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minimizeButton.Location = new System.Drawing.Point(698, 1);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(38, 31);
            this.minimizeButton.TabIndex = 67;
            this.minimizeButton.Text = "—";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeButton.Location = new System.Drawing.Point(726, 1);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(38, 31);
            this.closeButton.TabIndex = 66;
            this.closeButton.Text = "✖";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.addStudentButton.FlatAppearance.BorderSize = 0;
            this.addStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStudentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.addStudentButton.Location = new System.Drawing.Point(469, 414);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(210, 33);
            this.addStudentButton.TabIndex = 65;
            this.addStudentButton.Text = "Add Student";
            this.addStudentButton.UseVisualStyleBackColor = false;
            this.addStudentButton.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // loadClassButton
            // 
            this.loadClassButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.loadClassButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.loadClassButton.FlatAppearance.BorderSize = 0;
            this.loadClassButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadClassButton.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadClassButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.loadClassButton.Location = new System.Drawing.Point(469, 453);
            this.loadClassButton.Name = "loadClassButton";
            this.loadClassButton.Size = new System.Drawing.Size(210, 33);
            this.loadClassButton.TabIndex = 64;
            this.loadClassButton.Text = "Load Class";
            this.loadClassButton.UseVisualStyleBackColor = false;
            this.loadClassButton.Click += new System.EventHandler(this.loadClass_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label3.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.label3.Location = new System.Drawing.Point(134, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 32);
            this.label3.TabIndex = 63;
            this.label3.Text = "Students";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label4.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.label4.Location = new System.Drawing.Point(463, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 32);
            this.label4.TabIndex = 62;
            this.label4.Text = "Chosen Student";
            // 
            // addStudentsBox
            // 
            this.addStudentsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.addStudentsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addStudentsBox.Location = new System.Drawing.Point(77, 393);
            this.addStudentsBox.Multiline = true;
            this.addStudentsBox.Name = "addStudentsBox";
            this.addStudentsBox.Size = new System.Drawing.Size(249, 89);
            this.addStudentsBox.TabIndex = 61;
            this.addStudentsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addStudentsBox_KeyDown);
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.resultsLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.resultsLabel.Location = new System.Drawing.Point(469, 158);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(210, 32);
            this.resultsLabel.TabIndex = 60;
            this.resultsLabel.Text = "             ";
            // 
            // studentsBox
            // 
            this.studentsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.studentsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentsBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.studentsBox.FormattingEnabled = true;
            this.studentsBox.ItemHeight = 19;
            this.studentsBox.Location = new System.Drawing.Point(77, 108);
            this.studentsBox.Name = "studentsBox";
            this.studentsBox.Size = new System.Drawing.Size(249, 209);
            this.studentsBox.TabIndex = 59;
            this.studentsBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.studentsBox_MouseDoubleClick);
            // 
            // resetStudents
            // 
            this.resetStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.resetStudents.FlatAppearance.BorderSize = 0;
            this.resetStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetStudents.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.resetStudents.Location = new System.Drawing.Point(469, 336);
            this.resetStudents.Name = "resetStudents";
            this.resetStudents.Size = new System.Drawing.Size(210, 33);
            this.resetStudents.TabIndex = 58;
            this.resetStudents.Text = "Reset Students";
            this.resetStudents.UseVisualStyleBackColor = false;
            this.resetStudents.Click += new System.EventHandler(this.resetStudents_Click);
            // 
            // clearStudents
            // 
            this.clearStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.clearStudents.Cursor = System.Windows.Forms.Cursors.Default;
            this.clearStudents.FlatAppearance.BorderSize = 0;
            this.clearStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearStudents.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.clearStudents.Location = new System.Drawing.Point(469, 375);
            this.clearStudents.Name = "clearStudents";
            this.clearStudents.Size = new System.Drawing.Size(210, 33);
            this.clearStudents.TabIndex = 57;
            this.clearStudents.Text = "Clear All";
            this.clearStudents.UseVisualStyleBackColor = false;
            this.clearStudents.Click += new System.EventHandler(this.clearStudents_Click);
            // 
            // pickStudent
            // 
            this.pickStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.pickStudent.FlatAppearance.BorderSize = 0;
            this.pickStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickStudent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.pickStudent.Location = new System.Drawing.Point(469, 297);
            this.pickStudent.Name = "pickStudent";
            this.pickStudent.Size = new System.Drawing.Size(210, 33);
            this.pickStudent.TabIndex = 56;
            this.pickStudent.Text = "Pick Student";
            this.pickStudent.UseVisualStyleBackColor = false;
            this.pickStudent.Click += new System.EventHandler(this.pickStudent_Click);
            // 
            // saveClass
            // 
            this.saveClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.saveClass.FlatAppearance.BorderSize = 0;
            this.saveClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveClass.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.saveClass.Location = new System.Drawing.Point(469, 219);
            this.saveClass.Name = "saveClass";
            this.saveClass.Size = new System.Drawing.Size(210, 33);
            this.saveClass.TabIndex = 55;
            this.saveClass.Text = "Save Class";
            this.saveClass.UseVisualStyleBackColor = false;
            this.saveClass.Click += new System.EventHandler(this.saveClass_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // RandomStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(763, 552);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.loadClassButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addStudentsBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.studentsBox);
            this.Controls.Add(this.resetStudents);
            this.Controls.Add(this.clearStudents);
            this.Controls.Add(this.pickStudent);
            this.Controls.Add(this.saveClass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RandomStudentForm";
            this.Text = "RandomStudentForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.timerTB_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.timerTB_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.timerTB_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button loadClassButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addStudentsBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.ListBox studentsBox;
        private System.Windows.Forms.Button resetStudents;
        private System.Windows.Forms.Button clearStudents;
        private System.Windows.Forms.Button pickStudent;
        private System.Windows.Forms.Button saveClass;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}