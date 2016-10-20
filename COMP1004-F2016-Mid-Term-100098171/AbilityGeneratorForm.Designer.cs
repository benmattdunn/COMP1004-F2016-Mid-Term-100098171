namespace COMP1004_F2016_Mid_Term_100098171
{
    /// <summary>
    /// 
    /// <summary>
    /// DND character generator
    /// Tom T. & Ben Dunn
    /// Created 2016, oct 20
    /// 
    /// Creates a form that allows a user to generate abilites
    /// </summary>
    /// </summary>
    partial class AbilityGeneratorForm
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
            this.AbilityGroupBox = new System.Windows.Forms.GroupBox();
            this.CharismaTextBox = new System.Windows.Forms.TextBox();
            this.CharismaLabel = new System.Windows.Forms.Label();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.WisdomTextBox = new System.Windows.Forms.TextBox();
            this.WisdomLabel = new System.Windows.Forms.Label();
            this.IntelligenceTextBox = new System.Windows.Forms.TextBox();
            this.IntelligenceLabel = new System.Windows.Forms.Label();
            this.ConstitutionTextBox = new System.Windows.Forms.TextBox();
            this.ConstitutionLabel = new System.Windows.Forms.Label();
            this.DexterityTextBox = new System.Windows.Forms.TextBox();
            this.DexterityLabel = new System.Windows.Forms.Label();
            this.StrengthTextBox = new System.Windows.Forms.TextBox();
            this.StrengthLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SwapGroupBox = new System.Windows.Forms.GroupBox();
            this.SwitchFromBox = new System.Windows.Forms.ComboBox();
            this.SwitchTwoBox = new System.Windows.Forms.ComboBox();
            this.SwitchButton = new System.Windows.Forms.Button();
            this.AbilityGroupBox.SuspendLayout();
            this.SwapGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AbilityGroupBox
            // 
            this.AbilityGroupBox.Controls.Add(this.CharismaTextBox);
            this.AbilityGroupBox.Controls.Add(this.CharismaLabel);
            this.AbilityGroupBox.Controls.Add(this.GenerateButton);
            this.AbilityGroupBox.Controls.Add(this.WisdomTextBox);
            this.AbilityGroupBox.Controls.Add(this.WisdomLabel);
            this.AbilityGroupBox.Controls.Add(this.IntelligenceTextBox);
            this.AbilityGroupBox.Controls.Add(this.IntelligenceLabel);
            this.AbilityGroupBox.Controls.Add(this.ConstitutionTextBox);
            this.AbilityGroupBox.Controls.Add(this.ConstitutionLabel);
            this.AbilityGroupBox.Controls.Add(this.DexterityTextBox);
            this.AbilityGroupBox.Controls.Add(this.DexterityLabel);
            this.AbilityGroupBox.Controls.Add(this.StrengthTextBox);
            this.AbilityGroupBox.Controls.Add(this.StrengthLabel);
            this.AbilityGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbilityGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AbilityGroupBox.Name = "AbilityGroupBox";
            this.AbilityGroupBox.Size = new System.Drawing.Size(162, 462);
            this.AbilityGroupBox.TabIndex = 0;
            this.AbilityGroupBox.TabStop = false;
            this.AbilityGroupBox.Text = "Abilities";
            // 
            // CharismaTextBox
            // 
            this.CharismaTextBox.BackColor = System.Drawing.Color.White;
            this.CharismaTextBox.Location = new System.Drawing.Point(7, 361);
            this.CharismaTextBox.Name = "CharismaTextBox";
            this.CharismaTextBox.ReadOnly = true;
            this.CharismaTextBox.Size = new System.Drawing.Size(127, 26);
            this.CharismaTextBox.TabIndex = 11;
            this.CharismaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CharismaLabel
            // 
            this.CharismaLabel.AutoSize = true;
            this.CharismaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CharismaLabel.Location = new System.Drawing.Point(7, 335);
            this.CharismaLabel.Name = "CharismaLabel";
            this.CharismaLabel.Size = new System.Drawing.Size(84, 20);
            this.CharismaLabel.TabIndex = 10;
            this.CharismaLabel.Text = "Charisma";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateButton.Location = new System.Drawing.Point(10, 409);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(138, 40);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // WisdomTextBox
            // 
            this.WisdomTextBox.BackColor = System.Drawing.Color.White;
            this.WisdomTextBox.Location = new System.Drawing.Point(7, 301);
            this.WisdomTextBox.Name = "WisdomTextBox";
            this.WisdomTextBox.ReadOnly = true;
            this.WisdomTextBox.Size = new System.Drawing.Size(127, 26);
            this.WisdomTextBox.TabIndex = 9;
            this.WisdomTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // WisdomLabel
            // 
            this.WisdomLabel.AutoSize = true;
            this.WisdomLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WisdomLabel.Location = new System.Drawing.Point(7, 275);
            this.WisdomLabel.Name = "WisdomLabel";
            this.WisdomLabel.Size = new System.Drawing.Size(72, 20);
            this.WisdomLabel.TabIndex = 8;
            this.WisdomLabel.Text = "Wisdom";
            // 
            // IntelligenceTextBox
            // 
            this.IntelligenceTextBox.BackColor = System.Drawing.Color.White;
            this.IntelligenceTextBox.Location = new System.Drawing.Point(7, 241);
            this.IntelligenceTextBox.Name = "IntelligenceTextBox";
            this.IntelligenceTextBox.ReadOnly = true;
            this.IntelligenceTextBox.Size = new System.Drawing.Size(127, 26);
            this.IntelligenceTextBox.TabIndex = 7;
            this.IntelligenceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IntelligenceLabel
            // 
            this.IntelligenceLabel.AutoSize = true;
            this.IntelligenceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IntelligenceLabel.Location = new System.Drawing.Point(7, 215);
            this.IntelligenceLabel.Name = "IntelligenceLabel";
            this.IntelligenceLabel.Size = new System.Drawing.Size(102, 20);
            this.IntelligenceLabel.TabIndex = 6;
            this.IntelligenceLabel.Text = "Intelligence";
            // 
            // ConstitutionTextBox
            // 
            this.ConstitutionTextBox.BackColor = System.Drawing.Color.White;
            this.ConstitutionTextBox.Location = new System.Drawing.Point(7, 181);
            this.ConstitutionTextBox.Name = "ConstitutionTextBox";
            this.ConstitutionTextBox.ReadOnly = true;
            this.ConstitutionTextBox.Size = new System.Drawing.Size(127, 26);
            this.ConstitutionTextBox.TabIndex = 5;
            this.ConstitutionTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ConstitutionLabel
            // 
            this.ConstitutionLabel.AutoSize = true;
            this.ConstitutionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConstitutionLabel.Location = new System.Drawing.Point(7, 155);
            this.ConstitutionLabel.Name = "ConstitutionLabel";
            this.ConstitutionLabel.Size = new System.Drawing.Size(106, 20);
            this.ConstitutionLabel.TabIndex = 4;
            this.ConstitutionLabel.Text = "Constitution";
            // 
            // DexterityTextBox
            // 
            this.DexterityTextBox.BackColor = System.Drawing.Color.White;
            this.DexterityTextBox.Location = new System.Drawing.Point(7, 121);
            this.DexterityTextBox.Name = "DexterityTextBox";
            this.DexterityTextBox.ReadOnly = true;
            this.DexterityTextBox.Size = new System.Drawing.Size(127, 26);
            this.DexterityTextBox.TabIndex = 3;
            this.DexterityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DexterityLabel
            // 
            this.DexterityLabel.AutoSize = true;
            this.DexterityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DexterityLabel.Location = new System.Drawing.Point(7, 95);
            this.DexterityLabel.Name = "DexterityLabel";
            this.DexterityLabel.Size = new System.Drawing.Size(80, 20);
            this.DexterityLabel.TabIndex = 2;
            this.DexterityLabel.Text = "Dexterity";
            // 
            // StrengthTextBox
            // 
            this.StrengthTextBox.BackColor = System.Drawing.Color.White;
            this.StrengthTextBox.Location = new System.Drawing.Point(7, 61);
            this.StrengthTextBox.Name = "StrengthTextBox";
            this.StrengthTextBox.ReadOnly = true;
            this.StrengthTextBox.Size = new System.Drawing.Size(127, 26);
            this.StrengthTextBox.TabIndex = 1;
            this.StrengthTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StrengthLabel
            // 
            this.StrengthLabel.AutoSize = true;
            this.StrengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrengthLabel.Location = new System.Drawing.Point(7, 35);
            this.StrengthLabel.Name = "StrengthLabel";
            this.StrengthLabel.Size = new System.Drawing.Size(79, 20);
            this.StrengthLabel.TabIndex = 0;
            this.StrengthLabel.Text = "Strength";
            // 
            // NextButton
            // 
            this.NextButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextButton.Location = new System.Drawing.Point(360, 421);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(113, 40);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(180, 421);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(113, 40);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // SwapGroupBox
            // 
            this.SwapGroupBox.Controls.Add(this.SwitchTwoBox);
            this.SwapGroupBox.Controls.Add(this.SwitchFromBox);
            this.SwapGroupBox.Controls.Add(this.SwitchButton);
            this.SwapGroupBox.Location = new System.Drawing.Point(181, 277);
            this.SwapGroupBox.Name = "SwapGroupBox";
            this.SwapGroupBox.Size = new System.Drawing.Size(311, 121);
            this.SwapGroupBox.TabIndex = 4;
            this.SwapGroupBox.TabStop = false;
            // 
            // SwitchFromBox
            // 
            this.SwitchFromBox.FormattingEnabled = true;
            this.SwitchFromBox.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.SwitchFromBox.Location = new System.Drawing.Point(6, 20);
            this.SwitchFromBox.Name = "SwitchFromBox";
            this.SwitchFromBox.Size = new System.Drawing.Size(299, 21);
            this.SwitchFromBox.TabIndex = 0;
            // 
            // SwitchTwoBox
            // 
            this.SwitchTwoBox.FormattingEnabled = true;
            this.SwitchTwoBox.Items.AddRange(new object[] {
            "Strength",
            "Dexterity",
            "Constitution",
            "Intelligence",
            "Wisdom",
            "Charisma"});
            this.SwitchTwoBox.Location = new System.Drawing.Point(6, 47);
            this.SwitchTwoBox.Name = "SwitchTwoBox";
            this.SwitchTwoBox.Size = new System.Drawing.Size(299, 21);
            this.SwitchTwoBox.TabIndex = 0;
            // 
            // SwitchButton
            // 
            this.SwitchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SwitchButton.Location = new System.Drawing.Point(6, 74);
            this.SwitchButton.Name = "SwitchButton";
            this.SwitchButton.Size = new System.Drawing.Size(299, 40);
            this.SwitchButton.TabIndex = 3;
            this.SwitchButton.Text = "Switch Abilites";
            this.SwitchButton.UseVisualStyleBackColor = true;
            this.SwitchButton.Click += new System.EventHandler(this.SwitchButton_Click);
            // 
            // AbilityGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 481);
            this.Controls.Add(this.SwapGroupBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.AbilityGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AbilityGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ability Generator";
            this.Load += new System.EventHandler(this.GeneratorForm_Load);
            this.AbilityGroupBox.ResumeLayout(false);
            this.AbilityGroupBox.PerformLayout();
            this.SwapGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AbilityGroupBox;
        private System.Windows.Forms.TextBox CharismaTextBox;
        private System.Windows.Forms.Label CharismaLabel;
        private System.Windows.Forms.TextBox WisdomTextBox;
        private System.Windows.Forms.Label WisdomLabel;
        private System.Windows.Forms.TextBox IntelligenceTextBox;
        private System.Windows.Forms.Label IntelligenceLabel;
        private System.Windows.Forms.TextBox ConstitutionTextBox;
        private System.Windows.Forms.Label ConstitutionLabel;
        private System.Windows.Forms.TextBox DexterityTextBox;
        private System.Windows.Forms.Label DexterityLabel;
        private System.Windows.Forms.TextBox StrengthTextBox;
        private System.Windows.Forms.Label StrengthLabel;
        private System.Windows.Forms.Button GenerateButton;
        protected System.Windows.Forms.Button NextButton;
        protected System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.GroupBox SwapGroupBox;
        private System.Windows.Forms.ComboBox SwitchTwoBox;
        private System.Windows.Forms.ComboBox SwitchFromBox;
        protected System.Windows.Forms.Button SwitchButton;
    }
}

