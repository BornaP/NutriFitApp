namespace NutriFitApp.Main
{
    partial class AddMealForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelCalories = new System.Windows.Forms.Label();
            this.labelProteins = new System.Windows.Forms.Label();
            this.labelCarbs = new System.Windows.Forms.Label();
            this.labelFats = new System.Windows.Forms.Label();
            this.textBoxFoodName = new System.Windows.Forms.TextBox();
            this.numericUpDownCalories = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownProteins = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownCarbs = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFats = new System.Windows.Forms.NumericUpDown();
            this.buttonOK = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCalories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProteins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarbs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFats)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(52, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 16);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name :";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelCalories
            // 
            this.labelCalories.AutoSize = true;
            this.labelCalories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCalories.Location = new System.Drawing.Point(40, 68);
            this.labelCalories.Name = "labelCalories";
            this.labelCalories.Size = new System.Drawing.Size(64, 16);
            this.labelCalories.TabIndex = 1;
            this.labelCalories.Text = "Calories :";
            this.labelCalories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProteins
            // 
            this.labelProteins.AutoSize = true;
            this.labelProteins.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelProteins.Location = new System.Drawing.Point(40, 103);
            this.labelProteins.Name = "labelProteins";
            this.labelProteins.Size = new System.Drawing.Size(63, 16);
            this.labelProteins.TabIndex = 2;
            this.labelProteins.Text = "Proteins :";
            this.labelProteins.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCarbs
            // 
            this.labelCarbs.AutoSize = true;
            this.labelCarbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCarbs.Location = new System.Drawing.Point(53, 138);
            this.labelCarbs.Name = "labelCarbs";
            this.labelCarbs.Size = new System.Drawing.Size(50, 16);
            this.labelCarbs.TabIndex = 3;
            this.labelCarbs.Text = "Carbs :";
            this.labelCarbs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFats
            // 
            this.labelFats.AutoSize = true;
            this.labelFats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFats.Location = new System.Drawing.Point(63, 173);
            this.labelFats.Name = "labelFats";
            this.labelFats.Size = new System.Drawing.Size(40, 16);
            this.labelFats.TabIndex = 4;
            this.labelFats.Text = "Fats :";
            this.labelFats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxFoodName
            // 
            this.textBoxFoodName.Location = new System.Drawing.Point(126, 33);
            this.textBoxFoodName.Name = "textBoxFoodName";
            this.textBoxFoodName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFoodName.TabIndex = 5;
            // 
            // numericUpDownCalories
            // 
            this.numericUpDownCalories.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownCalories.Location = new System.Drawing.Point(126, 67);
            this.numericUpDownCalories.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownCalories.Name = "numericUpDownCalories";
            this.numericUpDownCalories.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownCalories.TabIndex = 6;
            this.numericUpDownCalories.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownProteins
            // 
            this.numericUpDownProteins.Location = new System.Drawing.Point(126, 101);
            this.numericUpDownProteins.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownProteins.Name = "numericUpDownProteins";
            this.numericUpDownProteins.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownProteins.TabIndex = 7;
            // 
            // numericUpDownCarbs
            // 
            this.numericUpDownCarbs.Location = new System.Drawing.Point(126, 135);
            this.numericUpDownCarbs.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownCarbs.Name = "numericUpDownCarbs";
            this.numericUpDownCarbs.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownCarbs.TabIndex = 8;
            // 
            // numericUpDownFats
            // 
            this.numericUpDownFats.Location = new System.Drawing.Point(126, 169);
            this.numericUpDownFats.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownFats.Name = "numericUpDownFats";
            this.numericUpDownFats.Size = new System.Drawing.Size(100, 20);
            this.numericUpDownFats.TabIndex = 9;
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(151, 215);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(75, 23);
            this.buttonOK.TabIndex = 10;
            this.buttonOK.Text = "Add";
            this.buttonOK.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(66, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddMealForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownFats);
            this.Controls.Add(this.numericUpDownCarbs);
            this.Controls.Add(this.numericUpDownProteins);
            this.Controls.Add(this.numericUpDownCalories);
            this.Controls.Add(this.textBoxFoodName);
            this.Controls.Add(this.labelFats);
            this.Controls.Add(this.labelCarbs);
            this.Controls.Add(this.labelProteins);
            this.Controls.Add(this.labelCalories);
            this.Controls.Add(this.labelName);
            this.Name = "AddMealForm";
            this.Text = "AddMealForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCalories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProteins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCarbs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelCalories;
        private System.Windows.Forms.Label labelProteins;
        private System.Windows.Forms.Label labelCarbs;
        private System.Windows.Forms.Label labelFats;
        private System.Windows.Forms.TextBox textBoxFoodName;
        private System.Windows.Forms.NumericUpDown numericUpDownCalories;
        private System.Windows.Forms.NumericUpDown numericUpDownProteins;
        private System.Windows.Forms.NumericUpDown numericUpDownCarbs;
        private System.Windows.Forms.NumericUpDown numericUpDownFats;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button button1;
    }
}