namespace NutriFitApp.Main
{
    partial class MainForm
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
            this.groupBoxPhysioInfo = new System.Windows.Forms.GroupBox();
            this.buttonUpdateInfo = new System.Windows.Forms.Button();
            this.comboBoxDietRegime = new System.Windows.Forms.ComboBox();
            this.labelDietRegime = new System.Windows.Forms.Label();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.labelAge = new System.Windows.Forms.Label();
            this.buttonDietSummary = new System.Windows.Forms.Button();
            this.groupBoxFood = new System.Windows.Forms.GroupBox();
            this.btnViewMeals = new System.Windows.Forms.Button();
            this.btnAddMeal = new System.Windows.Forms.Button();
            this.groupBoxActivity = new System.Windows.Forms.GroupBox();
            this.btnViewActivites = new System.Windows.Forms.Button();
            this.btnAddActivity = new System.Windows.Forms.Button();
            this.buttonNewDay = new System.Windows.Forms.Button();
            this.groupBoxPhysioInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.groupBoxFood.SuspendLayout();
            this.groupBoxActivity.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPhysioInfo
            // 
            this.groupBoxPhysioInfo.Controls.Add(this.buttonUpdateInfo);
            this.groupBoxPhysioInfo.Controls.Add(this.comboBoxDietRegime);
            this.groupBoxPhysioInfo.Controls.Add(this.labelDietRegime);
            this.groupBoxPhysioInfo.Controls.Add(this.numericUpDownWeight);
            this.groupBoxPhysioInfo.Controls.Add(this.labelWeight);
            this.groupBoxPhysioInfo.Controls.Add(this.labelGender);
            this.groupBoxPhysioInfo.Controls.Add(this.radioButtonFemale);
            this.groupBoxPhysioInfo.Controls.Add(this.radioButtonMale);
            this.groupBoxPhysioInfo.Controls.Add(this.numericUpDownAge);
            this.groupBoxPhysioInfo.Controls.Add(this.labelAge);
            this.groupBoxPhysioInfo.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPhysioInfo.Name = "groupBoxPhysioInfo";
            this.groupBoxPhysioInfo.Size = new System.Drawing.Size(389, 190);
            this.groupBoxPhysioInfo.TabIndex = 0;
            this.groupBoxPhysioInfo.TabStop = false;
            this.groupBoxPhysioInfo.Text = "Physiological info";
            // 
            // buttonUpdateInfo
            // 
            this.buttonUpdateInfo.Location = new System.Drawing.Point(287, 151);
            this.buttonUpdateInfo.Name = "buttonUpdateInfo";
            this.buttonUpdateInfo.Size = new System.Drawing.Size(96, 33);
            this.buttonUpdateInfo.TabIndex = 9;
            this.buttonUpdateInfo.Text = "Update Info";
            this.buttonUpdateInfo.UseVisualStyleBackColor = true;
            this.buttonUpdateInfo.Click += new System.EventHandler(this.buttonUpdateInfo_Click);
            // 
            // comboBoxDietRegime
            // 
            this.comboBoxDietRegime.FormattingEnabled = true;
            this.comboBoxDietRegime.Items.AddRange(new object[] {
            "Balanced Diet",
            "Weight Loss Diet",
            "Mass Gainer Diet"});
            this.comboBoxDietRegime.Location = new System.Drawing.Point(169, 124);
            this.comboBoxDietRegime.Name = "comboBoxDietRegime";
            this.comboBoxDietRegime.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDietRegime.TabIndex = 8;
            this.comboBoxDietRegime.Text = "Balanced Diet";
            // 
            // labelDietRegime
            // 
            this.labelDietRegime.AutoSize = true;
            this.labelDietRegime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelDietRegime.Location = new System.Drawing.Point(36, 129);
            this.labelDietRegime.Name = "labelDietRegime";
            this.labelDietRegime.Size = new System.Drawing.Size(89, 16);
            this.labelDietRegime.TabIndex = 7;
            this.labelDietRegime.Text = "Diet Regime :";
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.DecimalPlaces = 1;
            this.numericUpDownWeight.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownWeight.Location = new System.Drawing.Point(169, 88);
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 6;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelWeight.Location = new System.Drawing.Point(69, 92);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(56, 16);
            this.labelWeight.TabIndex = 5;
            this.labelWeight.Text = "Weight :";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGender.Location = new System.Drawing.Point(66, 61);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(59, 16);
            this.labelGender.TabIndex = 4;
            this.labelGender.Text = "Gender :";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(230, 61);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 3;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Checked = true;
            this.radioButtonMale.Location = new System.Drawing.Point(169, 61);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 2;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(169, 23);
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownAge.TabIndex = 1;
            this.numericUpDownAge.Value = new decimal(new int[] {
            22,
            0,
            0,
            0});
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAge.Location = new System.Drawing.Point(86, 27);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(39, 16);
            this.labelAge.TabIndex = 0;
            this.labelAge.Text = "Age :";
            this.labelAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonDietSummary
            // 
            this.buttonDietSummary.Location = new System.Drawing.Point(299, 360);
            this.buttonDietSummary.Name = "buttonDietSummary";
            this.buttonDietSummary.Size = new System.Drawing.Size(102, 39);
            this.buttonDietSummary.TabIndex = 1;
            this.buttonDietSummary.Text = "Calculate My Diet";
            this.buttonDietSummary.UseVisualStyleBackColor = true;
            this.buttonDietSummary.Click += new System.EventHandler(this.buttonDietSummary_Click);
            // 
            // groupBoxFood
            // 
            this.groupBoxFood.Controls.Add(this.btnViewMeals);
            this.groupBoxFood.Controls.Add(this.btnAddMeal);
            this.groupBoxFood.Location = new System.Drawing.Point(12, 209);
            this.groupBoxFood.Name = "groupBoxFood";
            this.groupBoxFood.Size = new System.Drawing.Size(187, 100);
            this.groupBoxFood.TabIndex = 2;
            this.groupBoxFood.TabStop = false;
            this.groupBoxFood.Text = "Meals";
            // 
            // btnViewMeals
            // 
            this.btnViewMeals.Location = new System.Drawing.Point(97, 39);
            this.btnViewMeals.Name = "btnViewMeals";
            this.btnViewMeals.Size = new System.Drawing.Size(83, 33);
            this.btnViewMeals.TabIndex = 1;
            this.btnViewMeals.Text = "View Meals";
            this.btnViewMeals.UseVisualStyleBackColor = true;
            this.btnViewMeals.Click += new System.EventHandler(this.btnViewMeals_Click);
            // 
            // btnAddMeal
            // 
            this.btnAddMeal.Location = new System.Drawing.Point(8, 39);
            this.btnAddMeal.Name = "btnAddMeal";
            this.btnAddMeal.Size = new System.Drawing.Size(83, 33);
            this.btnAddMeal.TabIndex = 0;
            this.btnAddMeal.Text = "Add meal";
            this.btnAddMeal.UseVisualStyleBackColor = true;
            this.btnAddMeal.Click += new System.EventHandler(this.btnAddMeal_Click);
            // 
            // groupBoxActivity
            // 
            this.groupBoxActivity.Controls.Add(this.btnViewActivites);
            this.groupBoxActivity.Controls.Add(this.btnAddActivity);
            this.groupBoxActivity.Location = new System.Drawing.Point(205, 209);
            this.groupBoxActivity.Name = "groupBoxActivity";
            this.groupBoxActivity.Size = new System.Drawing.Size(196, 100);
            this.groupBoxActivity.TabIndex = 3;
            this.groupBoxActivity.TabStop = false;
            this.groupBoxActivity.Text = "Activites";
            // 
            // btnViewActivites
            // 
            this.btnViewActivites.Location = new System.Drawing.Point(94, 39);
            this.btnViewActivites.Name = "btnViewActivites";
            this.btnViewActivites.Size = new System.Drawing.Size(83, 33);
            this.btnViewActivites.TabIndex = 1;
            this.btnViewActivites.Text = "View Activities";
            this.btnViewActivites.UseVisualStyleBackColor = true;
            this.btnViewActivites.Click += new System.EventHandler(this.btnViewActivites_Click);
            // 
            // btnAddActivity
            // 
            this.btnAddActivity.Location = new System.Drawing.Point(6, 39);
            this.btnAddActivity.Name = "btnAddActivity";
            this.btnAddActivity.Size = new System.Drawing.Size(83, 33);
            this.btnAddActivity.TabIndex = 0;
            this.btnAddActivity.Text = "Add Activity";
            this.btnAddActivity.UseVisualStyleBackColor = true;
            this.btnAddActivity.Click += new System.EventHandler(this.btnAddActivity_Click);
            // 
            // buttonNewDay
            // 
            this.buttonNewDay.Location = new System.Drawing.Point(20, 360);
            this.buttonNewDay.Name = "buttonNewDay";
            this.buttonNewDay.Size = new System.Drawing.Size(102, 39);
            this.buttonNewDay.TabIndex = 4;
            this.buttonNewDay.Text = "Start A New Day";
            this.buttonNewDay.UseVisualStyleBackColor = true;
            this.buttonNewDay.Click += new System.EventHandler(this.buttonNewDay_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 411);
            this.Controls.Add(this.buttonNewDay);
            this.Controls.Add(this.groupBoxActivity);
            this.Controls.Add(this.groupBoxFood);
            this.Controls.Add(this.buttonDietSummary);
            this.Controls.Add(this.groupBoxPhysioInfo);
            this.Name = "MainForm";
            this.Text = "NutriFitApp";
            this.groupBoxPhysioInfo.ResumeLayout(false);
            this.groupBoxPhysioInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.groupBoxFood.ResumeLayout(false);
            this.groupBoxActivity.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPhysioInfo;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.ComboBox comboBoxDietRegime;
        private System.Windows.Forms.Label labelDietRegime;
        private System.Windows.Forms.Button buttonDietSummary;
        private System.Windows.Forms.Button buttonUpdateInfo;
        private System.Windows.Forms.GroupBox groupBoxFood;
        private System.Windows.Forms.Button btnViewMeals;
        private System.Windows.Forms.Button btnAddMeal;
        private System.Windows.Forms.GroupBox groupBoxActivity;
        private System.Windows.Forms.Button btnViewActivites;
        private System.Windows.Forms.Button btnAddActivity;
        private System.Windows.Forms.Button buttonNewDay;
    }
}

