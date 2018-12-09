namespace GradeCalculator
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
            this.fileAccessMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameLabel = new System.Windows.Forms.Label();
            this.classNameLabel = new System.Windows.Forms.Label();
            this.semesterLabel = new System.Windows.Forms.Label();
            this.gradesLabel = new System.Windows.Forms.Label();
            this.nameValueLabel = new System.Windows.Forms.Label();
            this.classNameValueLabel = new System.Windows.Forms.Label();
            this.semesterValueLabel = new System.Windows.Forms.Label();
            this.studentPictureBox = new System.Windows.Forms.PictureBox();
            this.gradesListBox = new System.Windows.Forms.ListBox();
            this.finalGradeLabel = new System.Windows.Forms.Label();
            this.finalGradeValueLabel = new System.Windows.Forms.Label();
            this.calculateGradeButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileAccessMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fileAccessMenuStrip
            // 
            this.fileAccessMenuStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.fileAccessMenuStrip.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fileAccessMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.fileAccessMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.fileAccessMenuStrip.Name = "fileAccessMenuStrip";
            this.fileAccessMenuStrip.Size = new System.Drawing.Size(496, 24);
            this.fileAccessMenuStrip.TabIndex = 0;
            this.fileAccessMenuStrip.Text = "fileAccessMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.nameLabel.Location = new System.Drawing.Point(29, 43);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(107, 18);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Student Name";
            // 
            // classNameLabel
            // 
            this.classNameLabel.AutoSize = true;
            this.classNameLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.classNameLabel.Location = new System.Drawing.Point(29, 110);
            this.classNameLabel.Name = "classNameLabel";
            this.classNameLabel.Size = new System.Drawing.Size(94, 18);
            this.classNameLabel.TabIndex = 2;
            this.classNameLabel.Text = "Class Name";
            // 
            // semesterLabel
            // 
            this.semesterLabel.AutoSize = true;
            this.semesterLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.semesterLabel.Location = new System.Drawing.Point(29, 173);
            this.semesterLabel.Name = "semesterLabel";
            this.semesterLabel.Size = new System.Drawing.Size(76, 18);
            this.semesterLabel.TabIndex = 3;
            this.semesterLabel.Text = "Semester";
            // 
            // gradesLabel
            // 
            this.gradesLabel.AutoSize = true;
            this.gradesLabel.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.gradesLabel.Location = new System.Drawing.Point(29, 238);
            this.gradesLabel.Name = "gradesLabel";
            this.gradesLabel.Size = new System.Drawing.Size(60, 18);
            this.gradesLabel.TabIndex = 4;
            this.gradesLabel.Text = "Grades";
            // 
            // nameValueLabel
            // 
            this.nameValueLabel.AutoSize = true;
            this.nameValueLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.nameValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.nameValueLabel.Location = new System.Drawing.Point(47, 70);
            this.nameValueLabel.Name = "nameValueLabel";
            this.nameValueLabel.Size = new System.Drawing.Size(112, 21);
            this.nameValueLabel.TabIndex = 5;
            this.nameValueLabel.Text = "Lynn Eades";
            // 
            // classNameValueLabel
            // 
            this.classNameValueLabel.AutoSize = true;
            this.classNameValueLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.classNameValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.classNameValueLabel.Location = new System.Drawing.Point(47, 138);
            this.classNameValueLabel.Name = "classNameValueLabel";
            this.classNameValueLabel.Size = new System.Drawing.Size(74, 21);
            this.classNameValueLabel.TabIndex = 6;
            this.classNameValueLabel.Text = "CSharp";
            // 
            // semesterValueLabel
            // 
            this.semesterValueLabel.AutoSize = true;
            this.semesterValueLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.semesterValueLabel.ForeColor = System.Drawing.Color.Navy;
            this.semesterValueLabel.Location = new System.Drawing.Point(47, 201);
            this.semesterValueLabel.Name = "semesterValueLabel";
            this.semesterValueLabel.Size = new System.Drawing.Size(86, 21);
            this.semesterValueLabel.TabIndex = 7;
            this.semesterValueLabel.Text = "Fall 2018";
            // 
            // studentPictureBox
            // 
            this.studentPictureBox.Location = new System.Drawing.Point(265, 43);
            this.studentPictureBox.Name = "studentPictureBox";
            this.studentPictureBox.Size = new System.Drawing.Size(187, 187);
            this.studentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentPictureBox.TabIndex = 8;
            this.studentPictureBox.TabStop = false;
            // 
            // gradesListBox
            // 
            this.gradesListBox.Font = new System.Drawing.Font("Consolas", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gradesListBox.FormattingEnabled = true;
            this.gradesListBox.ItemHeight = 18;
            this.gradesListBox.Location = new System.Drawing.Point(51, 268);
            this.gradesListBox.Name = "gradesListBox";
            this.gradesListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.gradesListBox.Size = new System.Drawing.Size(166, 148);
            this.gradesListBox.TabIndex = 9;
            // 
            // finalGradeLabel
            // 
            this.finalGradeLabel.AutoSize = true;
            this.finalGradeLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.finalGradeLabel.ForeColor = System.Drawing.Color.Navy;
            this.finalGradeLabel.Location = new System.Drawing.Point(299, 271);
            this.finalGradeLabel.Name = "finalGradeLabel";
            this.finalGradeLabel.Size = new System.Drawing.Size(119, 24);
            this.finalGradeLabel.TabIndex = 10;
            this.finalGradeLabel.Text = "Final Grade";
            // 
            // finalGradeValueLabel
            // 
            this.finalGradeValueLabel.AutoSize = true;
            this.finalGradeValueLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.finalGradeValueLabel.ForeColor = System.Drawing.Color.Black;
            this.finalGradeValueLabel.Location = new System.Drawing.Point(333, 305);
            this.finalGradeValueLabel.Name = "finalGradeValueLabel";
            this.finalGradeValueLabel.Size = new System.Drawing.Size(0, 43);
            this.finalGradeValueLabel.TabIndex = 11;
            // 
            // calculateGradeButton
            // 
            this.calculateGradeButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.calculateGradeButton.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.calculateGradeButton.Location = new System.Drawing.Point(273, 377);
            this.calculateGradeButton.Name = "calculateGradeButton";
            this.calculateGradeButton.Size = new System.Drawing.Size(169, 41);
            this.calculateGradeButton.TabIndex = 12;
            this.calculateGradeButton.Text = "Calculate Grade";
            this.calculateGradeButton.UseVisualStyleBackColor = false;
            this.calculateGradeButton.Click += new System.EventHandler(this.calculateGradeButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*\"";
            this.openFileDialog1.InitialDirectory = "s_defaultPath";
            this.openFileDialog1.Title = "Select a Student File";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(496, 454);
            this.Controls.Add(this.calculateGradeButton);
            this.Controls.Add(this.finalGradeValueLabel);
            this.Controls.Add(this.finalGradeLabel);
            this.Controls.Add(this.gradesListBox);
            this.Controls.Add(this.studentPictureBox);
            this.Controls.Add(this.semesterValueLabel);
            this.Controls.Add(this.classNameValueLabel);
            this.Controls.Add(this.nameValueLabel);
            this.Controls.Add(this.gradesLabel);
            this.Controls.Add(this.semesterLabel);
            this.Controls.Add(this.classNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.fileAccessMenuStrip);
            this.MainMenuStrip = this.fileAccessMenuStrip;
            this.Name = "Form1";
            this.Text = "Grade Calculator";
            this.fileAccessMenuStrip.ResumeLayout(false);
            this.fileAccessMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip fileAccessMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label classNameLabel;
        private System.Windows.Forms.Label semesterLabel;
        private System.Windows.Forms.Label gradesLabel;
        private System.Windows.Forms.Label nameValueLabel;
        private System.Windows.Forms.Label classNameValueLabel;
        private System.Windows.Forms.Label semesterValueLabel;
        private System.Windows.Forms.PictureBox studentPictureBox;
        private System.Windows.Forms.ListBox gradesListBox;
        private System.Windows.Forms.Label finalGradeLabel;
        private System.Windows.Forms.Label finalGradeValueLabel;
        private System.Windows.Forms.Button calculateGradeButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

