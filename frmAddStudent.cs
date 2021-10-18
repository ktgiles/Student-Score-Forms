using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giles_Lab2
{
    public partial class frmAddStudent : Form
    {
        List<string> tempScores = new List<string>();
        frmStudentScores mainForm;

        public frmAddStudent(frmStudentScores mainFormVar)
        {
            InitializeComponent();           
            this.mainForm = mainFormVar;           
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            //set score in textbox to variable
            string score = tbScore.Text;
            
            //put score in tempscores list
            try
            {
                int intscore = Int32.Parse(score); //parse to validate if integer
                if (intscore > -1 && intscore < 101) //validate if integer is between 0 and 100 (inclusive)
                {
                    tempScores.Add(score); //if validated, add score to tempscores list
                }
                else
                {
                    MessageBox.Show("Score entry must be a whole number between 0 and 100."); //if integer but not between 0-100 inclusive, show error message
                }
            }
            catch (FormatException)
            {
                //names can be submitted without grades, this prevents not entering a value from breaking the program
                //this also catches decimal entries/non-numeric entries, which won't break the program but also will not be accepted/saved
                //future iterations of this program may benefit from additional decimal handling protocols and error message for non-numeric entries
            }     
            
            //join all tempscores into a string, seperated by spaces
            string stringScores = string.Join(" ", tempScores);
            tbAllScores.Text = stringScores; //show all scores in textbox 
            tbScore.Text = ""; //clear score entry textbox because score has been moved to all scores textbox         
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //when "Ok" clicked, save all changes
            string studentName = tbName.Text;
            if (tbName.Text == "") //validate that a name has been entered
            {
                MessageBox.Show("Student name is mandatory field.");
                this.Close();
            }
            else
            {
                string csvGrades = tbAllScores.Text;
                string allGrades = csvGrades.Replace(' ', '|'); //adhere to required formatting standards
                //allData is final version of string to be added to studentlist in frmStudentScores
                string allData = studentName + "|" + allGrades;

                //save allData to listbox in studentScores
                mainForm.addToList(allData);

                //after all code is executed, close add student window
                this.Close();
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
            //if Cancel button clicked, close form and don't save any changes
        {
            this.Close();
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            string studentName = tbName.Text; //set student name field to variable saved above
        }

        private void tbScore_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnClearScores_Click(object sender, EventArgs e)
            //on "Clear Scores" button click, remove all scores from list
        {
            tempScores.Clear();
            string stringScores = string.Join(",", tempScores);
            tbAllScores.Text = stringScores;
        }       
    }
}
