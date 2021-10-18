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
    public partial class frmUpdateStudentScores : Form
    {
        frmStudentScores mainForm;
        List<string> fullstring = new List<string>();

        public frmUpdateStudentScores(frmStudentScores mainFormVar)
        {
            InitializeComponent();
            this.mainForm = mainFormVar;

            //get selected dataset as string from listbox1 in frmstudentscores
            try
            {
                string selected = this.mainForm.getSelected();
                fullstring = selected.Split('|').ToList();//split dataset into list of strings

                //parse name from selected string
                string studentName = fullstring.First();
                tbName.Text = studentName;

                //display array of scores as list in lbscores
                for (int n = fullstring.Count - 1; n > 0; --n)
                {
                    if (!fullstring[n].Equals("")) //ensure blank values are not inserted into list
                    {
                        lbScores.Items.Add(fullstring[n]);
                    }
                }
            }
            catch //prevents crash if nothing selected
            {
                MessageBox.Show("A student must be selected before updating scores. Close the following Update Student Scores Form and select a student before proceeding.");
                //future iterations of this program may benefit from more advanced exception handling
            }    
        }

        private void btnAdd_Click(object sender, EventArgs e)
            //open Add Score Form when "Add" button clicked
        {
            frmAddScore addScoreForm = new frmAddScore(this);
            addScoreForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
            //open Update Score Form when "Update" button clicked
        {
            frmUpdateScore updateScoreForm = new frmUpdateScore(this);
            updateScoreForm.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //remove selected score when "Remove" button clicked
            int index = lbScores.SelectedIndex;
            try
            {
                lbScores.Items.RemoveAt(index);
            }
            catch
            {
                //if nothing selected to remove, do nothing and don't crash
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //remove ALL scores when "Clear Scores" button clicked
            for (int n = fullstring.Count - 1; n > 0; --n) //iterate through list and remove all
            {
                try
                {
                    lbScores.Items.RemoveAt(n - 1);
                }
                catch
                {
                    //if nothing left to delete, do nothing and don't crash
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            //save all changes to main form
            string allScores = ""; //declare and instantiate allScores as empty string          
             try
            {   //try to parse scores from lbScores
                string[] items = lbScores.Items 
                .OfType<object>()
                .Select(item => item.ToString())
                .ToArray();
                allScores = string.Join("|", items);
             }
            catch
            {
                //since student name can be submitted with no scores, keep program from breaking if no scores to parse
            }
           
            string studentName = fullstring.First();
            string fullSet = studentName + "|" + allScores; //create single string containing all updated data
           
            mainForm.deleteReplace(fullSet); //replace selected item in main form with updated data 
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //if "Cancel" button clicked, close form without saving changes
            this.Close();
        }

        private void frmUpdateStudentScores_Load(object sender, EventArgs e)
        {
        }

        public void addScore(string grade)
            //add score to listbox of scores
        {
            lbScores.Items.Add(grade);
        }

        public void updateScore(string grade)
            //replace selected score in listbox with new score
        {
        int index = lbScores.SelectedIndex;//find index of selected score
        
        lbScores.Items.RemoveAt(index);//remove selected score
            this.addScore(grade);//add updated score
        }
    }
}
