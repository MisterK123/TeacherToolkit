namespace randomStudentFormMain
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
            this.addStudent = new System.Windows.Forms.Button();
            this.loadClass = new System.Windows.Forms.Button();
            this.saveClass = new System.Windows.Forms.Button();
            this.pickStudent = new System.Windows.Forms.Button();
            this.clearStudents = new System.Windows.Forms.Button();
            this.resetStudents = new System.Windows.Forms.Button();
            this.studentsBox = new System.Windows.Forms.ListBox();
            this.resultsLabel = new System.Windows.Forms.Label();
            this.addStudentsBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addStudent
            // 
            this.addStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.addStudent.FlatAppearance.BorderSize = 0;
            this.addStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold);
            this.addStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.addStudent.Location = new System.Drawing.Point(41, 321);
            this.addStudent.Name = "addStudent";
            this.addStudent.Size = new System.Drawing.Size(249, 33);
            this.addStudent.TabIndex = 0;
            this.addStudent.Text = "Add Student";
            this.addStudent.UseVisualStyleBackColor = false;
            this.addStudent.Click += new System.EventHandler(this.addStudent_Click);
            // 
            // loadClass
            // 
            this.loadClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.loadClass.FlatAppearance.BorderSize = 0;
            this.loadClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadClass.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.loadClass.Location = new System.Drawing.Point(433, 225);
            this.loadClass.Name = "loadClass";
            this.loadClass.Size = new System.Drawing.Size(210, 33);
            this.loadClass.TabIndex = 1;
            this.loadClass.Text = "Load Class";
            this.loadClass.UseVisualStyleBackColor = false;
            this.loadClass.Click += new System.EventHandler(this.loadClass_Click);
            // 
            // saveClass
            // 
            this.saveClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.saveClass.FlatAppearance.BorderSize = 0;
            this.saveClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveClass.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.saveClass.Location = new System.Drawing.Point(433, 186);
            this.saveClass.Name = "saveClass";
            this.saveClass.Size = new System.Drawing.Size(210, 33);
            this.saveClass.TabIndex = 2;
            this.saveClass.Text = "Save Class";
            this.saveClass.UseVisualStyleBackColor = false;
            this.saveClass.Click += new System.EventHandler(this.saveClass_Click);
            // 
            // pickStudent
            // 
            this.pickStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.pickStudent.FlatAppearance.BorderSize = 0;
            this.pickStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pickStudent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickStudent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.pickStudent.Location = new System.Drawing.Point(433, 264);
            this.pickStudent.Name = "pickStudent";
            this.pickStudent.Size = new System.Drawing.Size(210, 33);
            this.pickStudent.TabIndex = 3;
            this.pickStudent.Text = "Pick Student";
            this.pickStudent.UseVisualStyleBackColor = false;
            this.pickStudent.Click += new System.EventHandler(this.pickStudent_Click);
            // 
            // clearStudents
            // 
            this.clearStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.clearStudents.Cursor = System.Windows.Forms.Cursors.Default;
            this.clearStudents.FlatAppearance.BorderSize = 0;
            this.clearStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearStudents.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.clearStudents.Location = new System.Drawing.Point(433, 342);
            this.clearStudents.Name = "clearStudents";
            this.clearStudents.Size = new System.Drawing.Size(210, 33);
            this.clearStudents.TabIndex = 4;
            this.clearStudents.Text = "Clear All";
            this.clearStudents.UseVisualStyleBackColor = false;
            this.clearStudents.Click += new System.EventHandler(this.clearStudents_Click);
            // 
            // resetStudents
            // 
            this.resetStudents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.resetStudents.FlatAppearance.BorderSize = 0;
            this.resetStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetStudents.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetStudents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.resetStudents.Location = new System.Drawing.Point(433, 303);
            this.resetStudents.Name = "resetStudents";
            this.resetStudents.Size = new System.Drawing.Size(210, 33);
            this.resetStudents.TabIndex = 5;
            this.resetStudents.Text = "Reset Students";
            this.resetStudents.UseVisualStyleBackColor = false;
            this.resetStudents.Click += new System.EventHandler(this.resetStudents_Click);
            // 
            // studentsBox
            // 
            this.studentsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.studentsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.studentsBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsBox.FormattingEnabled = true;
            this.studentsBox.ItemHeight = 19;
            this.studentsBox.Location = new System.Drawing.Point(41, 75);
            this.studentsBox.Name = "studentsBox";
            this.studentsBox.Size = new System.Drawing.Size(249, 209);
            this.studentsBox.TabIndex = 6;
            this.studentsBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.studentsBox_MouseDoubleClick);
            // 
            // resultsLabel
            // 
            this.resultsLabel.AutoSize = true;
            this.resultsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.resultsLabel.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.resultsLabel.Location = new System.Drawing.Point(433, 125);
            this.resultsLabel.Name = "resultsLabel";
            this.resultsLabel.Size = new System.Drawing.Size(210, 32);
            this.resultsLabel.TabIndex = 7;
            this.resultsLabel.Text = "             ";
            this.resultsLabel.Click += new System.EventHandler(this.resultsLabel_Click);
            // 
            // addStudentsBox
            // 
            this.addStudentsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(62)))), ((int)(((byte)(101)))));
            this.addStudentsBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addStudentsBox.Location = new System.Drawing.Point(41, 360);
            this.addStudentsBox.Multiline = true;
            this.addStudentsBox.Name = "addStudentsBox";
            this.addStudentsBox.Size = new System.Drawing.Size(249, 89);
            this.addStudentsBox.TabIndex = 8;
            this.addStudentsBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.addStudentsBox_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.label1.Location = new System.Drawing.Point(427, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Chosen Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label2.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(203)))), ((int)(((byte)(112)))));
            this.label2.Location = new System.Drawing.Point(98, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Students";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(47)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(774, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addStudentsBox);
            this.Controls.Add(this.resultsLabel);
            this.Controls.Add(this.studentsBox);
            this.Controls.Add(this.resetStudents);
            this.Controls.Add(this.clearStudents);
            this.Controls.Add(this.pickStudent);
            this.Controls.Add(this.saveClass);
            this.Controls.Add(this.loadClass);
            this.Controls.Add(this.addStudent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addStudent;
        private System.Windows.Forms.Button loadClass;
        private System.Windows.Forms.Button saveClass;
        private System.Windows.Forms.Button pickStudent;
        private System.Windows.Forms.Button clearStudents;
        private System.Windows.Forms.Button resetStudents;
        private System.Windows.Forms.ListBox studentsBox;
        private System.Windows.Forms.Label resultsLabel;
        private System.Windows.Forms.TextBox addStudentsBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

