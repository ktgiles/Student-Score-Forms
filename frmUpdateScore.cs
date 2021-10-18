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
    public partial class frmUpdateScore : Form
    {
        frmUpdateStudentScores baseForm;
        public frmUpdateScore(frmUpdateStudentScores baseFormVar)
        {
            InitializeComponent();
            this.baseForm = baseFormVar;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newScore = tbScore.Text;//set new text entry to string variable

            try //validate new score data
            {
                int intscore = Int32.Parse(newScore); //parse to ensure integer
                if (intscore > -1 && intscore < 101) //check that integer is between 0 and 100 (inclusive)
                {
                    baseForm.updateScore(newScore); //call update score method to replace score
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Score entry must be a whole number between 0 and 100."); //if entry is an integer but outside of 0-100, show error in message box
                }
            }
            catch
            {
                //this catches decimal entries/non-numeric entries, which won't break the program but also will not be accepted/saved (nothing happens)
                //future iterations of this program may benefit from additional decimal handling protocols and error message for non-numeric entries
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
            //close form when "Cancel" button clicked
        {
            this.Close();
        }

        private void frmUpdateScore_Load(object sender, EventArgs e)
        {
            //future iterations of this program would benefit from logic that will prevent program from opening
            //the Update Score form if user has not selected a score to update/there are no scores to update
            //right now the described scenario does not break the program but is not handled elegantly
        }
    }
}
