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

    public partial class frmStudentScores : Form
    {
        public static List<string> studentlist = new List<string>(); //create list to hold strings of name and score data

        public frmStudentScores()
        {
            InitializeComponent();

            //add starting data to list
            this.listBox1.Items.Add("Bruce Wayne|78|83|65");
            this.listBox1.Items.Add("Alfred Pennyworth|100|96|99");
            this.listBox1.Items.Add("Selina Kyle|85|94|97");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
            //this method uses event handler to call "do math" method any time selected item is changed/item is selected
        {
           try 
            {
                doMath(this.listBox1.SelectedItem.ToString());
            }
            catch
            {//do nothing except not break if selected item has been deleted/no item is selected
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void btnAddNew_Click(object sender, EventArgs e)
            //this method uses event handler to show Add Student Form when "Add New" button is clicked
        {
            frmAddStudent addStudentForm = new frmAddStudent(this);
            addStudentForm.Show();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
            //this method uses event handler to show Update Student Score Form when "Update" button is clicked
        {
            frmUpdateStudentScores updateStudentScoreForm = new frmUpdateStudentScores(this);
            updateStudentScoreForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
            //this method closes form when Exit button is clicked
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //this method gets selected item and deletes it from listbox when "Delete" button is clicked
            try
            {
                string selected = this.listBox1.SelectedItem.ToString(); //get selected

                //iterate through list, find and delete selected string from list
                for (int n = this.listBox1.Items.Count - 1; n >= 0; --n)
                {
                    if (this.listBox1.Items[n].ToString().Contains(selected))
                    {
                        this.listBox1.Items.RemoveAt(n);
                    }
                }
            }
            catch
            {
                //if nothing selected when delete is clicked, nothing happens and the program doesn't break
            }
        }

        private void frmStudentScores_Load(object sender, EventArgs e)
        {
        }

        public void addToList(string dataset)
            //this method adds whatever string is passed to it to studentlist
        {
            studentlist.Add(dataset);
            this.listBox1.Items.Add(dataset);
        }

        public void doMath(string dataset) 
            //this method uses whatever string is passed to it to set values for count/sum/avg boxes on main form
        {
            List<string> fullstring = new List<string>(); //string list will hold every item from dataset 
            List<int> numbers = new List<int>(); //int list will hold only numbers from dataset

            fullstring = dataset.Split('|').ToList(); //split dataset into list of strings

            foreach (var item in fullstring) //check to see if string item is number
            {
                int n;
                int.TryParse(item, out n);
                numbers.Add(n); //if string item is number, add to numbers list
            }

           int count = numbers.Count - 1; 
            tbScoreCount.Text = count.ToString(); //set value to count textbox

            int sum = numbers.Sum(x => Convert.ToInt32(x));
            tbScoreTotal.Text = sum.ToString(); //set value to sum textbox

            int avg = sum / count;
            tbAverage.Text = avg.ToString(); //set value to average textbox
        }

        public string getSelected()
            //returns selected item as string
        {
            string selected = listBox1.SelectedItem.ToString();
            return selected;
        }

        public void deleteReplace(string newString) 
            //deletes selected list item and replace with new string
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
            listBox1.Items.Add(newString);

        }
    }
}

