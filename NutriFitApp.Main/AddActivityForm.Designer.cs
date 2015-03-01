namespace NutriFitApp.Main
{
    partial class AddActivityForm
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
            this.labelActivityName = new System.Windows.Forms.Label();
            this.labelCaloriesLost = new System.Windows.Forms.Label();
            this.labelActivityType = new System.Windows.Forms.Label();
            this.textBoxActivityName = new System.Windows.Forms.TextBox();
            this.numericUpDownCalLost = new System.Windows.Forms.NumericUpDown();
            this.comboBoxActiType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCalLost)).BeginInit();
            this.SuspendLayout();
            // 
            // labelActivityName
            // 
            this.labelActivityName.AutoSize = true;
            this.labelActivityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActivityName.Location = new System.Drawing.Point(22, 42);
            this.labelActivityName.Name = "labelActivityName";
            this.labelActivityName.Size = new System.Drawing.Size(96, 16);
            this.labelActivityName.TabIndex = 0;
            this.labelActivityName.Text = "Activity Name :";
            this.labelActivityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCaloriesLost
            // 
            this.labelCaloriesLost.AutoSize = true;
            this.labelCaloriesLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCaloriesLost.Location = new System.Drawing.Point(26, 95);
            this.labelCaloriesLost.Name = "labelCaloriesLost";
            this.labelCaloriesLost.Size = new System.Drawing.Size(92, 16);
            this.labelCaloriesLost.TabIndex = 1;
            this.labelCaloriesLost.Text = "Calories Lost :";
            this.labelCaloriesLost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActivityType
            // 
            this.labelActivityType.AutoSize = true;
            this.labelActivityType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActivityType.Location = new System.Drawing.Point(27, 157);
            this.labelActivityType.Name = "labelActivityType";
            this.labelActivityType.Size = new System.Drawing.Size(91, 16);
            this.labelActivityType.TabIndex = 2;
            this.labelActivityType.Text = "Activity Type :";
            this.labelActivityType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxActivityName
            // 
            this.textBoxActivityName.Location = new System.Drawing.Point(124, 42);
            this.textBoxActivityName.Name = "textBoxActivityName";
            this.textBoxActivityName.Size = new System.Drawing.Size(129, 20);
            this.textBoxActivityName.TabIndex = 3;
            // 
            // numericUpDownCalLost
            // 
            this.numericUpDownCalLost.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownCalLost.Location = new System.Drawing.Point(124, 91);
            this.numericUpDownCalLost.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownCalLost.Name = "numericUpDownCalLost";
            this.numericUpDownCalLost.Size = new System.Drawing.Size(129, 20);
            this.numericUpDownCalLost.TabIndex = 4;
            // 
            // comboBoxActiType
            // 
            this.comboBoxActiType.FormattingEnabled = true;
            this.comboBoxActiType.Items.AddRange(new object[] {
            "Aerobic Exercise",
            "Anaerobic Exercise",
            "Flexibility Exercise"});
            this.comboBoxActiType.Location = new System.Drawing.Point(124, 156);
            this.comboBoxActiType.Name = "comboBoxActiType";
            this.comboBoxActiType.Size = new System.Drawing.Size(129, 21);
            this.comboBoxActiType.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(81, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.Location = new System.Drawing.Point(178, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddActivityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxActiType);
            this.Controls.Add(this.numericUpDownCalLost);
            this.Controls.Add(this.textBoxActivityName);
            this.Controls.Add(this.labelActivityType);
            this.Controls.Add(this.labelCaloriesLost);
            this.Controls.Add(this.labelActivityName);
            this.Name = "AddActivityForm";
            this.Text = "AddActivityForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCalLost)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelActivityName;
        private System.Windows.Forms.Label labelCaloriesLost;
        private System.Windows.Forms.Label labelActivityType;
        private System.Windows.Forms.TextBox textBoxActivityName;
        private System.Windows.Forms.NumericUpDown numericUpDownCalLost;
        private System.Windows.Forms.ComboBox comboBoxActiType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}