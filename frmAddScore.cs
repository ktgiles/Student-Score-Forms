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
    public partial class frmAddScore : Form
    {
        frmUpdateStudentScores baseForm;

        public frmAddScore(frmUpdateStudentScores baseFormVar)
        {
            InitializeComponent();
            this.baseForm = baseFormVar;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add score when "Add" button clicked
            string newScore = tbScore.Text; //set entry in textbox to variable

            try
            {
                int intscore = Int32.Parse(newScore); //validate entry is integer
                if (intscore > -1 && intscore < 101) //validate integer is between 0 and 100 inclusive
                {
                    baseForm.addScore(newScore);//add score 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Score entry must be a whole number between 0 and 100."); //if entry not between 0 and 100 inclusive, show error message
                }               
            }
            catch
            {
                //this catches decimal entries/non-numeric entries, which won't break the program but also will not be accepted/saved (nothing happens)
                //future iterations of this program may benefit from additional decimal handling protocols and error message for non-numeric entries
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
            //if "Cancel" button clicked, close form without saving changes
        {
            this.Close();
        }

        private void frmAddScore_Load(object sender, EventArgs e)
        {
        }
    }
}
