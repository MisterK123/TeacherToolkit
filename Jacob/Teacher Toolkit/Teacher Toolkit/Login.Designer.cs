﻿namespace Teacher_Toolkit
{
    partial class LoginPage
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
            this.UsernameTitle = new System.Windows.Forms.Label();
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.Label();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.PasswordTitle = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.RemeberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.LoadTimer = new System.Windows.Forms.Timer(this.components);
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.Warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsernameTitle
            // 
            this.UsernameTitle.AutoSize = true;
            this.UsernameTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsernameTitle.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameTitle.ForeColor = System.Drawing.Color.White;
            this.UsernameTitle.Location = new System.Drawing.Point(41, 134);
            this.UsernameTitle.Name = "UsernameTitle";
            this.UsernameTitle.Size = new System.Drawing.Size(111, 30);
            this.UsernameTitle.TabIndex = 30;
            this.UsernameTitle.Text = "Username:";
            // 
            // UsernameInput
            // 
            this.UsernameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.UsernameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UsernameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameInput.ForeColor = System.Drawing.Color.White;
            this.UsernameInput.Location = new System.Drawing.Point(46, 168);
            this.UsernameInput.Multiline = true;
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(253, 22);
            this.UsernameInput.TabIndex = 31;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Nirmala UI", 29.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(37, 23);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(276, 52);
            this.Title.TabIndex = 29;
            this.Title.Text = "Teacher Toolkit";
            // 
            // PasswordInput
            // 
            this.PasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.PasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordInput.ForeColor = System.Drawing.Color.White;
            this.PasswordInput.Location = new System.Drawing.Point(46, 225);
            this.PasswordInput.Multiline = true;
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(253, 22);
            this.PasswordInput.TabIndex = 33;
            // 
            // PasswordTitle
            // 
            this.PasswordTitle.AutoSize = true;
            this.PasswordTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordTitle.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTitle.ForeColor = System.Drawing.Color.White;
            this.PasswordTitle.Location = new System.Drawing.Point(41, 191);
            this.PasswordTitle.Name = "PasswordTitle";
            this.PasswordTitle.Size = new System.Drawing.Size(104, 30);
            this.PasswordTitle.TabIndex = 32;
            this.PasswordTitle.Text = "Password:";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LoginButton.Location = new System.Drawing.Point(46, 253);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LoginButton.Size = new System.Drawing.Size(253, 56);
            this.LoginButton.TabIndex = 34;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // RemeberMeCheckBox
            // 
            this.RemeberMeCheckBox.AutoSize = true;
            this.RemeberMeCheckBox.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemeberMeCheckBox.ForeColor = System.Drawing.Color.White;
            this.RemeberMeCheckBox.Location = new System.Drawing.Point(46, 315);
            this.RemeberMeCheckBox.Name = "RemeberMeCheckBox";
            this.RemeberMeCheckBox.Size = new System.Drawing.Size(99, 17);
            this.RemeberMeCheckBox.TabIndex = 35;
            this.RemeberMeCheckBox.Text = "Remember Me";
            this.RemeberMeCheckBox.UseVisualStyleBackColor = true;
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CreateAccountButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CreateAccountButton.FlatAppearance.BorderSize = 0;
            this.CreateAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateAccountButton.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateAccountButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CreateAccountButton.Location = new System.Drawing.Point(46, 419);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CreateAccountButton.Size = new System.Drawing.Size(253, 56);
            this.CreateAccountButton.TabIndex = 36;
            this.CreateAccountButton.Text = "Create Account";
            this.CreateAccountButton.UseVisualStyleBackColor = false;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // Warning
            // 
            this.Warning.AutoSize = true;
            this.Warning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Warning.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Warning.ForeColor = System.Drawing.Color.DarkRed;
            this.Warning.Location = new System.Drawing.Point(41, 357);
            this.Warning.Name = "Warning";
            this.Warning.Size = new System.Drawing.Size(208, 30);
            this.Warning.TabIndex = 46;
            this.Warning.Text = "Please input all fields";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(350, 500);
            this.Controls.Add(this.Warning);
            this.Controls.Add(this.CreateAccountButton);
            this.Controls.Add(this.RemeberMeCheckBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.PasswordTitle);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.UsernameInput);
            this.Controls.Add(this.UsernameTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label UsernameTitle;
        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label PasswordTitle;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.CheckBox RemeberMeCheckBox;
        private System.Windows.Forms.Timer LoadTimer;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.Label Warning;
    }
}