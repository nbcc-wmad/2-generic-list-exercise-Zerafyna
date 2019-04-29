using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayListsStructuresEx
{
    public struct Grades
    {
        public int Max;
        public char Grade;
    }

    //Erica Moisei -- Apr. 26/2019
    public partial class Form1 : Form
    {
        ArrayList gradesList = new ArrayList();
        private Grades grades;
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //adding the range-grade
            grades.Max = 299;
            grades.Grade = 'F';
            gradesList.Add(grades);
            grades.Max = 349;
            grades.Grade = 'D';
            gradesList.Add(grades);
            grades.Max = 399;
            grades.Grade = 'C';
            gradesList.Add(grades);
            grades.Max = 449;
            grades.Grade = 'B';
            gradesList.Add(grades);
            grades.Max = 500;
            grades.Grade = 'A';
            gradesList.Add(grades);
        }

        private void btnFindGrade_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(txtScore.Text);

            if (score < 0 || score > 500)
            {
                MessageBox.Show("The score is out of the grade range");
            }
            foreach (Grades g in gradesList)
            {
                if(score <= g.Max)
                {
                    MessageBox.Show($"The grade is {g.Grade}");
                    return;
                    //break will not wxit the btn method and continue code
                }
            }
        }
    }
}
