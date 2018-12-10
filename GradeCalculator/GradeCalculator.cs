using System.Drawing;

/*****************************************/
/*  Project 6:   GradeCalculator Class   */
/*  Author:      Lynn Eades              */
/*  Date:        12/10/2018              */
/*****************************************/

namespace GradeCalculator
{
    class GradeCalculator
    {
        private double[] grades { get; set; }

        // Constructor takes an array list of grades
        public GradeCalculator(double[] gradeList)
        {
            grades = gradeList;
        }

        // Calculates final grade and returns as a percentage
        public double CalculateGradePercentage(double totalPointsPossible)
        {
            double gradeAsPercentage = 0;
            double totalPointsEarned = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                totalPointsEarned = totalPointsEarned + grades[i];
                gradeAsPercentage = (totalPointsEarned / totalPointsPossible) * 100;
            }
            return gradeAsPercentage;
        }

        // Returns a string letter grade for given grade as a percentage
        public string LetterGradeForPercentage(double gradePercentageValue)
        {
            string letterGrade;

            if (gradePercentageValue > 89.0)
            {
                letterGrade = "A";
            }
            else if (gradePercentageValue > 79.0)
            {
                letterGrade = "B";
            }
            else if (gradePercentageValue > 69.0)
            {
                letterGrade = "C";
            }
            else if (gradePercentageValue > 59.0)
            {
                letterGrade = "D";
            }
            else
            {
                letterGrade = "F";
            }
            return letterGrade;
        }

        // Given a letter grade, return color for letter
        // A, B, C = green,  D = orange,  F = red, all others stay black
        public Color ColorForGrade(string gradeValue)
        {
            Color gradeColor = Color.Black;
            switch (gradeValue)
            {
                case "A":
                case "B":
                case "C":
                    gradeColor = Color.Green;
                    break;
                case "D":
                    gradeColor = Color.Orange;
                    break;
                case "E":
                case "F":
                    gradeColor = Color.Red;
                    break;
                default:
                    break;
            }
            return gradeColor;
        }
    }
}
