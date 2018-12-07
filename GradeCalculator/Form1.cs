using System;
using System.IO;
using System.Windows.Forms;

namespace GradeCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
                StreamReader inFile = new StreamReader(fileName);

                int[] grades = new int[8];
                string[] studentData = inFile.ReadLine().Split(',');

                nameValueLabel.Text = studentData[0];
                classNameValueLabel.Text = studentData[1];
                semesterValueLabel.Text = studentData[2];
                studentPictureBox.ImageLocation = studentData[3];

                for(int i=0; i<8; i++)
                {
                    grades[i] = Convert.ToInt32(studentData[i + 4]);
                    gradesListBox.Items.Add(grades[i]);
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculateGradeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
