namespace NutriFitApp.Main
{
    partial class DietSummaryView
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
            this.listViewActivities = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.listViewMeals = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxRemainingDiet = new System.Windows.Forms.GroupBox();
            this.textBoxFats = new System.Windows.Forms.TextBox();
            this.textBoxCarbs = new System.Windows.Forms.TextBox();
            this.textBoxProt = new System.Windows.Forms.TextBox();
            this.textBoxCal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxRemainingDiet.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewActivities
            // 
            this.listViewActivities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewActivities.Location = new System.Drawing.Point(15, 29);
            this.listViewActivities.Name = "listViewActivities";
            this.listViewActivities.Size = new System.Drawing.Size(394, 117);
            this.listViewActivities.TabIndex = 1;
            this.listViewActivities.UseCompatibleStateImageBehavior = false;
            this.listViewActivities.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 157;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Calories Lost (kcal)";
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Activity Type";
            this.columnHeader3.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Todays activities :";
            // 
            // listViewMeals
            // 
            this.listViewMeals.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewMeals.Location = new System.Drawing.Point(15, 184);
            this.listViewMeals.Name = "listViewMeals";
            this.listViewMeals.Size = new System.Drawing.Size(394, 122);
            this.listViewMeals.TabIndex = 3;
            this.listViewMeals.UseCompatibleStateImageBehavior = false;
            this.listViewMeals.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Calories (kcal)";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Proteins (g)";
            this.columnHeader6.Width = 67;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Carbs (g)";
            this.columnHeader7.Width = 59;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Fats (g)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Todays meals : ";
            // 
            // groupBoxRemainingDiet
            // 
            this.groupBoxRemainingDiet.Controls.Add(this.textBoxFats);
            this.groupBoxRemainingDiet.Controls.Add(this.textBoxCarbs);
            this.groupBoxRemainingDiet.Controls.Add(this.textBoxProt);
            this.groupBoxRemainingDiet.Controls.Add(this.textBoxCal);
            this.groupBoxRemainingDiet.Controls.Add(this.label6);
            this.groupBoxRemainingDiet.Controls.Add(this.label5);
            this.groupBoxRemainingDiet.Controls.Add(this.label4);
            this.groupBoxRemainingDiet.Controls.Add(this.label3);
            this.groupBoxRemainingDiet.Location = new System.Drawing.Point(15, 325);
            this.groupBoxRemainingDiet.Name = "groupBoxRemainingDiet";
            this.groupBoxRemainingDiet.Size = new System.Drawing.Size(394, 100);
            this.groupBoxRemainingDiet.TabIndex = 5;
            this.groupBoxRemainingDiet.TabStop = false;
            this.groupBoxRemainingDiet.Text = "Remaining diet for Today";
            // 
            // textBoxFats
            // 
            this.textBoxFats.Location = new System.Drawing.Point(245, 74);
            this.textBoxFats.Name = "textBoxFats";
            this.textBoxFats.ReadOnly = true;
            this.textBoxFats.Size = new System.Drawing.Size(100, 20);
            this.textBoxFats.TabIndex = 7;
            // 
            // textBoxCarbs
            // 
            this.textBoxCarbs.Location = new System.Drawing.Point(245, 47);
            this.textBoxCarbs.Name = "textBoxCarbs";
            this.textBoxCarbs.ReadOnly = true;
            this.textBoxCarbs.Size = new System.Drawing.Size(100, 20);
            this.textBoxCarbs.TabIndex = 6;
            // 
            // textBoxProt
            // 
            this.textBoxProt.Location = new System.Drawing.Point(245, 20);
            this.textBoxProt.Name = "textBoxProt";
            this.textBoxProt.ReadOnly = true;
            this.textBoxProt.Size = new System.Drawing.Size(100, 20);
            this.textBoxProt.TabIndex = 5;
            // 
            // textBoxCal
            // 
            this.textBoxCal.Location = new System.Drawing.Point(73, 43);
            this.textBoxCal.Name = "textBoxCal";
            this.textBoxCal.ReadOnly = true;
            this.textBoxCal.Size = new System.Drawing.Size(100, 20);
            this.textBoxCal.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Fats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Carbs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Proteins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Calories left";
            // 
            // DietSummaryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 434);
            this.Controls.Add(this.groupBoxRemainingDiet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewMeals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewActivities);
            this.Name = "DietSummaryView";
            this.Text = "DietSummaryView";
            this.Load += new System.EventHandler(this.DietSummaryView_Load);
            this.groupBoxRemainingDiet.ResumeLayout(false);
            this.groupBoxRemainingDiet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewActivities;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewMeals;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxRemainingDiet;
        private System.Windows.Forms.TextBox textBoxFats;
        private System.Windows.Forms.TextBox textBoxCarbs;
        private System.Windows.Forms.TextBox textBoxProt;
        private System.Windows.Forms.TextBox textBoxCal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}