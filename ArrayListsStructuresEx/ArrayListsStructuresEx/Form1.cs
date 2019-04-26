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
    //Erica Moisei -- Apr. 26/2019
    public partial class Form1 : Form
    {
        ArrayList gradesScale = new ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //adding the range
            gradesScale.Add(299);
            gradesScale.Add("F");
            gradesScale.Add(349);
            gradesScale.Add("D");
            gradesScale.Add(399);
            gradesScale.Add("C");
            gradesScale.Add(449);
            gradesScale.Add("B");
            gradesScale.Add(500);
            gradesScale.Add("A");
        }

        private void btnFindGrade_Click(object sender, EventArgs e)
        {
            int score = Convert.ToInt32(txtScore.Text);
            
            if (score >= 0 && score <= Convert.ToInt32(gradesScale[0]))
            {
                MessageBox.Show("The grade is F");
            }
            else if (score <= Convert.ToInt32(gradesScale[2]))
            {
                MessageBox.Show("The grade is D");
            }
            else if (score <= Convert.ToInt32(gradesScale[4]))
            {
                MessageBox.Show("The grade is C");
            }
            else if (score <= Convert.ToInt32(gradesScale[6]))
            {
                MessageBox.Show("The grade is B");
            }
            else if (score <= Convert.ToInt32(gradesScale[8]))
            {
                MessageBox.Show("The grade is A");
            }
            else
            {
                MessageBox.Show("The score is out of the grade range");
            }
        }

    }
}
