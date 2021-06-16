namespace Box_Measerments
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
            this.HeightComboBox = new System.Windows.Forms.ComboBox();
            this.WidthComboBox = new System.Windows.Forms.ComboBox();
            this.LengthComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HeightComboBox
            // 
            this.HeightComboBox.FormattingEnabled = true;
            this.HeightComboBox.Location = new System.Drawing.Point(681, 268);
            this.HeightComboBox.Name = "HeightComboBox";
            this.HeightComboBox.Size = new System.Drawing.Size(121, 37);
            this.HeightComboBox.TabIndex = 0;
            // 
            // WidthComboBox
            // 
            this.WidthComboBox.FormattingEnabled = true;
            this.WidthComboBox.Location = new System.Drawing.Point(681, 379);
            this.WidthComboBox.Name = "WidthComboBox";
            this.WidthComboBox.Size = new System.Drawing.Size(121, 37);
            this.WidthComboBox.TabIndex = 1;
            // 
            // LengthComboBox
            // 
            this.LengthComboBox.FormattingEnabled = true;
            this.LengthComboBox.Location = new System.Drawing.Point(681, 490);
            this.LengthComboBox.Name = "LengthComboBox";
            this.LengthComboBox.Size = new System.Drawing.Size(121, 37);
            this.LengthComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(690, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(681, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Length";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1750, 868);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LengthComboBox);
            this.Controls.Add(this.WidthComboBox);
            this.Controls.Add(this.HeightComboBox);
            this.Name = "Form1";
            this.Text = "BoxMeasurments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox HeightComboBox;
        private System.Windows.Forms.ComboBox WidthComboBox;
        private System.Windows.Forms.ComboBox LengthComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

