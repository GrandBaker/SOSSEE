namespace SOSSE
{
    partial class GeneralEditingForm
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
            this.healthNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.staminaNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.healthLabel = new System.Windows.Forms.Label();
            this.staminaLabel = new System.Windows.Forms.Label();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.dayComboBox = new System.Windows.Forms.ComboBox();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.monthLabel = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.hourNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.minuteNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.hourLabel = new System.Windows.Forms.Label();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.difficultyGroupBox = new System.Windows.Forms.GroupBox();
            this.originalRadioButton = new System.Windows.Forms.RadioButton();
            this.seedlingRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.healthNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staminaNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).BeginInit();
            this.difficultyGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // healthNumericUpDown
            // 
            this.healthNumericUpDown.Location = new System.Drawing.Point(112, 24);
            this.healthNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.healthNumericUpDown.Name = "healthNumericUpDown";
            this.healthNumericUpDown.Size = new System.Drawing.Size(96, 31);
            this.healthNumericUpDown.TabIndex = 0;
            // 
            // staminaNumericUpDown
            // 
            this.staminaNumericUpDown.Location = new System.Drawing.Point(448, 24);
            this.staminaNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.staminaNumericUpDown.Name = "staminaNumericUpDown";
            this.staminaNumericUpDown.Size = new System.Drawing.Size(96, 31);
            this.staminaNumericUpDown.TabIndex = 1;
            // 
            // healthLabel
            // 
            this.healthLabel.AutoSize = true;
            this.healthLabel.Location = new System.Drawing.Point(24, 30);
            this.healthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.healthLabel.Name = "healthLabel";
            this.healthLabel.Size = new System.Drawing.Size(74, 25);
            this.healthLabel.TabIndex = 2;
            this.healthLabel.Text = "Health";
            // 
            // staminaLabel
            // 
            this.staminaLabel.AutoSize = true;
            this.staminaLabel.Location = new System.Drawing.Point(346, 30);
            this.staminaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.staminaLabel.Name = "staminaLabel";
            this.staminaLabel.Size = new System.Drawing.Size(90, 25);
            this.staminaLabel.TabIndex = 3;
            this.staminaLabel.Text = "Stamina";
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(112, 78);
            this.moneyTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(196, 31);
            this.moneyTextBox.TabIndex = 4;
            this.moneyTextBox.TextChanged += new System.EventHandler(this.moneyTextBox_TextChanged);
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(24, 84);
            this.moneyLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(77, 25);
            this.moneyLabel.TabIndex = 5;
            this.moneyLabel.Text = "Money";
            // 
            // monthComboBox
            // 
            this.monthComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Location = new System.Drawing.Point(112, 132);
            this.monthComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(92, 33);
            this.monthComboBox.TabIndex = 6;
            // 
            // dayComboBox
            // 
            this.dayComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayComboBox.FormattingEnabled = true;
            this.dayComboBox.Location = new System.Drawing.Point(284, 132);
            this.dayComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.dayComboBox.Name = "dayComboBox";
            this.dayComboBox.Size = new System.Drawing.Size(90, 33);
            this.dayComboBox.TabIndex = 7;
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(470, 132);
            this.yearNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(74, 31);
            this.yearNumericUpDown.TabIndex = 8;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(24, 136);
            this.monthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(72, 25);
            this.monthLabel.TabIndex = 9;
            this.monthLabel.Text = "Month";
            // 
            // dayLabel
            // 
            this.dayLabel.AutoSize = true;
            this.dayLabel.Location = new System.Drawing.Point(220, 138);
            this.dayLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(50, 25);
            this.dayLabel.TabIndex = 10;
            this.dayLabel.Text = "Day";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(386, 134);
            this.yearLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(58, 25);
            this.yearLabel.TabIndex = 11;
            this.yearLabel.Text = "Year";
            // 
            // hourNumericUpDown
            // 
            this.hourNumericUpDown.Location = new System.Drawing.Point(112, 188);
            this.hourNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.hourNumericUpDown.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.hourNumericUpDown.Name = "hourNumericUpDown";
            this.hourNumericUpDown.Size = new System.Drawing.Size(96, 31);
            this.hourNumericUpDown.TabIndex = 12;
            // 
            // minuteNumericUpDown
            // 
            this.minuteNumericUpDown.Location = new System.Drawing.Point(448, 188);
            this.minuteNumericUpDown.Margin = new System.Windows.Forms.Padding(6);
            this.minuteNumericUpDown.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.minuteNumericUpDown.Name = "minuteNumericUpDown";
            this.minuteNumericUpDown.Size = new System.Drawing.Size(96, 31);
            this.minuteNumericUpDown.TabIndex = 13;
            // 
            // hourLabel
            // 
            this.hourLabel.AutoSize = true;
            this.hourLabel.Location = new System.Drawing.Point(24, 192);
            this.hourLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.hourLabel.Name = "hourLabel";
            this.hourLabel.Size = new System.Drawing.Size(58, 25);
            this.hourLabel.TabIndex = 14;
            this.hourLabel.Text = "Hour";
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Location = new System.Drawing.Point(359, 192);
            this.minuteLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(77, 25);
            this.minuteLabel.TabIndex = 15;
            this.minuteLabel.Text = "Minute";
            // 
            // difficultyGroupBox
            // 
            this.difficultyGroupBox.Controls.Add(this.originalRadioButton);
            this.difficultyGroupBox.Controls.Add(this.seedlingRadioButton);
            this.difficultyGroupBox.Location = new System.Drawing.Point(24, 240);
            this.difficultyGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.difficultyGroupBox.Name = "difficultyGroupBox";
            this.difficultyGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.difficultyGroupBox.Size = new System.Drawing.Size(520, 84);
            this.difficultyGroupBox.TabIndex = 16;
            this.difficultyGroupBox.TabStop = false;
            this.difficultyGroupBox.Text = "Difficulty";
            // 
            // originalRadioButton
            // 
            this.originalRadioButton.AutoSize = true;
            this.originalRadioButton.Location = new System.Drawing.Point(276, 38);
            this.originalRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.originalRadioButton.Name = "originalRadioButton";
            this.originalRadioButton.Size = new System.Drawing.Size(117, 29);
            this.originalRadioButton.TabIndex = 1;
            this.originalRadioButton.TabStop = true;
            this.originalRadioButton.Text = "Original";
            this.originalRadioButton.UseVisualStyleBackColor = true;
            // 
            // seedlingRadioButton
            // 
            this.seedlingRadioButton.AutoSize = true;
            this.seedlingRadioButton.Location = new System.Drawing.Point(12, 38);
            this.seedlingRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.seedlingRadioButton.Name = "seedlingRadioButton";
            this.seedlingRadioButton.Size = new System.Drawing.Size(127, 29);
            this.seedlingRadioButton.TabIndex = 0;
            this.seedlingRadioButton.TabStop = true;
            this.seedlingRadioButton.Text = "Seedling";
            this.seedlingRadioButton.UseVisualStyleBackColor = true;
            // 
            // GeneralEditingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(567, 348);
            this.Controls.Add(this.difficultyGroupBox);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.hourLabel);
            this.Controls.Add(this.minuteNumericUpDown);
            this.Controls.Add(this.hourNumericUpDown);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.yearNumericUpDown);
            this.Controls.Add(this.dayComboBox);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.moneyTextBox);
            this.Controls.Add(this.staminaLabel);
            this.Controls.Add(this.healthLabel);
            this.Controls.Add(this.staminaNumericUpDown);
            this.Controls.Add(this.healthNumericUpDown);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneralEditingForm";
            this.Text = "GeneralEditingForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GeneralEditingForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.healthNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staminaNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minuteNumericUpDown)).EndInit();
            this.difficultyGroupBox.ResumeLayout(false);
            this.difficultyGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown healthNumericUpDown;
        private System.Windows.Forms.NumericUpDown staminaNumericUpDown;
        private System.Windows.Forms.Label healthLabel;
        private System.Windows.Forms.Label staminaLabel;
        private System.Windows.Forms.TextBox moneyTextBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.ComboBox monthComboBox;
        private System.Windows.Forms.ComboBox dayComboBox;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.NumericUpDown hourNumericUpDown;
        private System.Windows.Forms.NumericUpDown minuteNumericUpDown;
        private System.Windows.Forms.Label hourLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.GroupBox difficultyGroupBox;
        private System.Windows.Forms.RadioButton originalRadioButton;
        private System.Windows.Forms.RadioButton seedlingRadioButton;
    }
}