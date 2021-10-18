
namespace Giles_Lab2
{
    partial class frmStudentScores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Students = new System.Windows.Forms.Label();
            this.Average = new System.Windows.Forms.Label();
            this.Scorecount = new System.Windows.Forms.Label();
            this.ScoreTotal = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbScoreTotal = new System.Windows.Forms.TextBox();
            this.tbScoreCount = new System.Windows.Forms.TextBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.frmStudentScoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.frmStudentScoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 39);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(295, 121);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Students
            // 
            this.Students.AutoSize = true;
            this.Students.Location = new System.Drawing.Point(12, 9);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(52, 13);
            this.Students.TabIndex = 1;
            this.Students.Text = "Students:";
            // 
            // Average
            // 
            this.Average.AutoSize = true;
            this.Average.Location = new System.Drawing.Point(159, 231);
            this.Average.Name = "Average";
            this.Average.Size = new System.Drawing.Size(50, 13);
            this.Average.TabIndex = 2;
            this.Average.Text = "Average:";
            this.Average.Click += new System.EventHandler(this.label1_Click);
            // 
            // Scorecount
            // 
            this.Scorecount.AutoSize = true;
            this.Scorecount.Location = new System.Drawing.Point(159, 204);
            this.Scorecount.Name = "Scorecount";
            this.Scorecount.Size = new System.Drawing.Size(68, 13);
            this.Scorecount.TabIndex = 3;
            this.Scorecount.Text = "Score count:";
            // 
            // ScoreTotal
            // 
            this.ScoreTotal.AutoSize = true;
            this.ScoreTotal.Location = new System.Drawing.Point(159, 178);
            this.ScoreTotal.Name = "ScoreTotal";
            this.ScoreTotal.Size = new System.Drawing.Size(61, 13);
            this.ScoreTotal.TabIndex = 4;
            this.ScoreTotal.Text = "Score total:";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(340, 39);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 5;
            this.btnAddNew.Text = "Add New...";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(340, 78);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update...";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(340, 119);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbScoreTotal
            // 
            this.tbScoreTotal.Location = new System.Drawing.Point(238, 171);
            this.tbScoreTotal.Name = "tbScoreTotal";
            this.tbScoreTotal.ReadOnly = true;
            this.tbScoreTotal.Size = new System.Drawing.Size(69, 20);
            this.tbScoreTotal.TabIndex = 8;
            // 
            // tbScoreCount
            // 
            this.tbScoreCount.Location = new System.Drawing.Point(238, 197);
            this.tbScoreCount.Name = "tbScoreCount";
            this.tbScoreCount.ReadOnly = true;
            this.tbScoreCount.Size = new System.Drawing.Size(69, 20);
            this.tbScoreCount.TabIndex = 9;
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(238, 224);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.ReadOnly = true;
            this.tbAverage.Size = new System.Drawing.Size(69, 20);
            this.tbAverage.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(340, 226);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStudentScoresBindingSource
            // 
            this.frmStudentScoresBindingSource.DataSource = typeof(Giles_Lab2.frmStudentScores);
            // 
            // frmStudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 287);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.tbScoreCount);
            this.Controls.Add(this.tbScoreTotal);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.ScoreTotal);
            this.Controls.Add(this.Scorecount);
            this.Controls.Add(this.Average);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.listBox1);
            this.Name = "frmStudentScores";
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.frmStudentScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frmStudentScoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Students;
        private System.Windows.Forms.Label Average;
        private System.Windows.Forms.Label Scorecount;
        private System.Windows.Forms.Label ScoreTotal;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tbScoreTotal;
        private System.Windows.Forms.TextBox tbScoreCount;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.BindingSource frmStudentScoresBindingSource;
    }
}

