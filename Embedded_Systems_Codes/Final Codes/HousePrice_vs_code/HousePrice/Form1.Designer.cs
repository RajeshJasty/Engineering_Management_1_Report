namespace HousePrice
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.HouseTypeComboBox = new System.Windows.Forms.ComboBox();
            this.HouseLocationComboBox = new System.Windows.Forms.ComboBox();
            this.HouseYearComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.HouseCostTextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(252, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(2266, 779);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.HouseYearComboBox);
            this.tabPage1.Controls.Add(this.HouseLocationComboBox);
            this.tabPage1.Controls.Add(this.HouseTypeComboBox);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(2246, 722);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "HousePrice";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Sienna;
            this.tabPage2.Controls.Add(this.CalculateButton);
            this.tabPage2.Controls.Add(this.HouseCostTextBox);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(2246, 722);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calculation";
            // 
            // HouseTypeComboBox
            // 
            this.HouseTypeComboBox.FormattingEnabled = true;
            this.HouseTypeComboBox.Location = new System.Drawing.Point(377, 106);
            this.HouseTypeComboBox.Name = "HouseTypeComboBox";
            this.HouseTypeComboBox.Size = new System.Drawing.Size(121, 37);
            this.HouseTypeComboBox.TabIndex = 0;
            // 
            // HouseLocationComboBox
            // 
            this.HouseLocationComboBox.FormattingEnabled = true;
            this.HouseLocationComboBox.Location = new System.Drawing.Point(377, 221);
            this.HouseLocationComboBox.Name = "HouseLocationComboBox";
            this.HouseLocationComboBox.Size = new System.Drawing.Size(121, 37);
            this.HouseLocationComboBox.TabIndex = 1;
            // 
            // HouseYearComboBox
            // 
            this.HouseYearComboBox.FormattingEnabled = true;
            this.HouseYearComboBox.Location = new System.Drawing.Point(377, 353);
            this.HouseYearComboBox.Name = "HouseYearComboBox";
            this.HouseYearComboBox.Size = new System.Drawing.Size(121, 37);
            this.HouseYearComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Houe Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "House Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "House Year";
            // 
            // HouseCostTextBox
            // 
            this.HouseCostTextBox.Location = new System.Drawing.Point(644, 183);
            this.HouseCostTextBox.Name = "HouseCostTextBox";
            this.HouseCostTextBox.Size = new System.Drawing.Size(465, 35);
            this.HouseCostTextBox.TabIndex = 0;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(390, 172);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(143, 56);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2846, 980);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "HousePrice";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox HouseYearComboBox;
        private System.Windows.Forms.ComboBox HouseLocationComboBox;
        private System.Windows.Forms.ComboBox HouseTypeComboBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox HouseCostTextBox;
    }
}

