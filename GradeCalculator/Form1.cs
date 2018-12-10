using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

/*****************************************/
/*  Project 6:   Grade Calculator App    */
/*  Author:      Lynn Eades              */
/*  Date:        12/10/2018              */
/*****************************************/


/* Expected student files contain a single line of data comma-deliminated   */
/* Data should be found in the following order:                             */
/* student_name,class_name,semester,image_filename,                         */
/*              p1_grade,p2_grade,p3_grade,p4_grade,                        */
/*              p5_grade,p6_grade,midterm_grade,final_grade                 */
/* Example data:                                                            */
/* Lynn Eades,CSharp,Fall 2018,lynn.eades.jpg,90,100,90,85,90,90,90,80      */
/*                                                                          */
/* Image files are expected to be in the same directory as the data files   */


namespace GradeCalculator
{
    public partial class Form1 : Form
    {
        private const int TOTAL_GRADE_POINTS_POSSIBLE = 800;

        private double[] grades;             // Will hold student grades
        private GradeCalculator calculator;  // Handles all the calculations
        private StreamReader inFile;         // For reading student data from file

        public Form1()
        {
            InitializeComponent();
        }

        // Open a search file dialog box for selecting a student data file
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // A container to hold the 8 grades: 6 projects + 2 exams
                grades = new double[8];

                // Clear grades from previously selected student
                gradesListBox.Items.Clear();
                finalGradeValueLabel.Text = null;

                // Wrap the file open and read with a try-catch in case something goes wrong
                try
                {
                    // Open the selected file and set up a reader to read the file
                    string filename = openFileDialog1.FileName;
                    inFile = new StreamReader(filename);
                    
                    // Capture the path to use when retrieving the image file
                    string pathToFile = Path.GetDirectoryName(openFileDialog1.FileName);

                    // Read the data and separate the data into an array for processing
                    string[] studentData = inFile.ReadLine().Split(',');

                    // Grab the student name, class, semester and picture and populate form
                    nameValueLabel.Text = studentData[0];
                    classNameValueLabel.Text = studentData[1];
                    semesterValueLabel.Text = studentData[2];
                    studentPictureBox.Image = Image.FromFile(pathToFile + "\\" + studentData[3]);

                    // Grab the grades and add to ListBox with some description text
                    for (int i = 0; i < 8; i++)
                    {
                        // Collect the grades in a container to use later
                        grades[i] = Convert.ToDouble(studentData[i + 4]);
                    }
                    PopulateListBox(grades);

                    // Button is disabled until the grades are loaded and a calculation can be made
                    calculateGradeButton.Enabled = true;
                }
                catch (Exception)
                {
                    // Clear any displayed data that may have been read in incorrectly
                    nameValueLabel.Text = "Select a student file";
                    classNameValueLabel.Text = "";
                    semesterValueLabel.Text = "";
                    studentPictureBox.Image = null;
                    calculateGradeButton.Enabled = false;

                    // Show a message to user that something went wrong reading file or its contents
                    MessageBox.Show("ERROR!\nUnable to read student file or its contents.\nPlease try again.");
                } finally {
                    // Close the stream if it exists
                    if (inFile != default(StreamReader))
                    {
                        inFile.Close();
                    }
                }
            }
        }

        // Add list of grades with project/exam description to the listbox
        private void PopulateListBox(double [] grades)
        {
            string gradeWithDescription = "";
            for (int i = 0; i < 8; i++)
            {
                if (i < 6)
                {
                    gradeWithDescription = String.Format(" {0, -9}{1}   {2,5}", "Project", i + 1, grades[i]);
                }
                else if (i == 6)
                {
                    gradeWithDescription = String.Format(" {0, -10}   {1,5}", "Midterm", grades[i]);
                }
                else
                {
                    gradeWithDescription = String.Format(" {0, -10}   {1,5}", "Final", grades[i]);
                }
                gradesListBox.Items.Add(gradeWithDescription);
            }
        }

        // Use the grade calculator to get grade percentage, letter value, and color for grade
        private void CalculateGradeButton_Click(object sender, EventArgs e)
        {
            // Initialize the GradeCalculator passing the list of grades
            calculator = new GradeCalculator(grades);

            // Do all the calculations
            double finalGradePercent = calculator.CalculateGradePercentage(TOTAL_GRADE_POINTS_POSSIBLE);
            string letterGrade = calculator.LetterGradeForPercentage(finalGradePercent);
            Color gradeColor = calculator.ColorForGrade(letterGrade);

            // Display grade result on form
            finalGradeValueLabel.Text = letterGrade;
            finalGradeValueLabel.ForeColor = gradeColor;
        }

        // Exit application
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
