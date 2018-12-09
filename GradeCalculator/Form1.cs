using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

/*****************************************/
/*  Project 6:   Grade Calculator        */
/*  Author:      Lynn Eades              */
/*  Date:        12/10/2018              */
/*****************************************/

namespace GradeCalculator
{
    public partial class Form1 : Form
    {
        const int TOTAL_GRADE_POINTS_POSSIBLE = 800;
        int[] grades; // Will hold student's project/exam grades

        public Form1()
        {
            InitializeComponent();
            grades = new int[8]; // 6 projects + 2 exams
        }

        // Open a search file dialog box for selecting a student data file
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Clear grades from previously selected student
                gradesListBox.Items.Clear();
                finalGradeValueLabel.Text = null;

                // Open the selected file and set up a reader to read the file
                string fileName = openFileDialog1.FileName;
                StreamReader inFile = new StreamReader(fileName);
                string pathToFile = Path.GetDirectoryName(openFileDialog1.FileName);

                // Read the data and separate the data into an array for processing
                string[] studentData = inFile.ReadLine().Split(',');

                // Grab the student name, class, semester and picture and populate form
                nameValueLabel.Text = studentData[0];
                classNameValueLabel.Text = studentData[1];
                semesterValueLabel.Text = studentData[2];
                studentPictureBox.Image = Image.FromFile(pathToFile + "\\" + studentData[3]);

                // Grab the grades and add to ListBox with some description text
                string gradeWithDescription = "";
                for (int i=0; i<8; i++)
                {
                    grades[i] = Convert.ToInt32(studentData[i + 4]);
                    if (i < 6)
                    {
                        gradeWithDescription = String.Format(" {0, -9}{1} {2, 4}", "Project", i+1, grades[i]);
                    }
                    else if (i == 6)
                    {
                        gradeWithDescription = String.Format(" {0, -10} {1, 4}", "Midterm", grades[i]);
                    }
                    else
                    {
                        gradeWithDescription = String.Format(" {0, -10} {1, 4}", "Final", grades[i]);
                    }
                    gradesListBox.Items.Add(gradeWithDescription);
                }

                // Button is disabled until the grades are loaded and a calculation can be made
                calculateGradeButton.Enabled = true;
            }
        }

        // Open a search file dialog box for selecting a student data file
        private void calculateGradeButton_Click(object sender, EventArgs e)
        {
            double finalGradePercent = CalculateGrade(grades);
            char letterGrade = GetLetterGradeForPercentage(finalGradePercent);
            finalGradeValueLabel.Text = letterGrade.ToString();
            finalGradeValueLabel.ForeColor = GetColorForGrade(letterGrade);
        }

        // Calculates final grade and returns as a percentage
        private double CalculateGrade(int[] grades)
        {
            double gradeAsPercentage = 0;
            double finalGrade = 0;

            for(int i=0; i < grades.Length; i++)
            {
                finalGrade = finalGrade + grades[i];
                gradeAsPercentage = finalGrade / TOTAL_GRADE_POINTS_POSSIBLE * 100;
            }

            return gradeAsPercentage;
        }

        // Returns a letter grade for given grade as a percentage
        private char GetLetterGradeForPercentage(double gradePercentageValue)
        {
            char letterGrade;

            if (gradePercentageValue > 89.0)
            {
                letterGrade = 'A';
            }
            else if (gradePercentageValue > 89.0)
            {
                letterGrade = 'B';
            } else if (gradePercentageValue > 89.0)
            {
                letterGrade = 'C';
            }
            else if (gradePercentageValue > 89.0)
            {
                letterGrade = 'D';
            } else
            {
                letterGrade = 'F';
            }

            return letterGrade;
        }

        // Return color for a letter grade
        private Color GetColorForGrade(char gradeValue)
        {
            Color gradeColor = Color.Green;
            switch (gradeValue)
            {
                case 'A':
                case 'B':
                case 'C':
                    gradeColor = Color.Green;
                    break;
                case 'D':
                    gradeColor = Color.Orange;
                    break;
                case 'F':
                    gradeColor = Color.Red;
                    break;
            }

            return gradeColor;
        }

        // Exit application
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
