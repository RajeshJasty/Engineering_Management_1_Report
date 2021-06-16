namespace lightControl
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
            this.readingMicroRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StartsCommsButton = new System.Windows.Forms.Button();
            this.serialRadioButton = new System.Windows.Forms.RadioButton();
            this.serialOpenButton = new System.Windows.Forms.Button();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.serialStatusTextBox = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.trackValueLabel = new System.Windows.Forms.TrackBar();
            this.commsTestButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackValueLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(250, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1650, 818);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Teal;
            this.tabPage1.Controls.Add(this.commsTestButton);
            this.tabPage1.Controls.Add(this.readingMicroRadioButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.StartsCommsButton);
            this.tabPage1.Controls.Add(this.serialRadioButton);
            this.tabPage1.Controls.Add(this.serialOpenButton);
            this.tabPage1.Controls.Add(this.baudRateComboBox);
            this.tabPage1.Controls.Add(this.portComboBox);
            this.tabPage1.Controls.Add(this.serialStatusTextBox);
            this.tabPage1.Location = new System.Drawing.Point(10, 47);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1630, 761);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Serial";
            // 
            // readingMicroRadioButton
            // 
            this.readingMicroRadioButton.AutoSize = true;
            this.readingMicroRadioButton.Location = new System.Drawing.Point(990, 537);
            this.readingMicroRadioButton.Name = "readingMicroRadioButton";
            this.readingMicroRadioButton.Size = new System.Drawing.Size(27, 26);
            this.readingMicroRadioButton.TabIndex = 8;
            this.readingMicroRadioButton.TabStop = true;
            this.readingMicroRadioButton.UseVisualStyleBackColor = true;
            this.readingMicroRadioButton.CheckedChanged += new System.EventHandler(this.readingMicroRadioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(918, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 40);
            this.label2.TabIndex = 7;
            this.label2.Text = "BAUD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(913, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 40);
            this.label1.TabIndex = 6;
            this.label1.Text = "PORT";
            // 
            // StartsCommsButton
            // 
            this.StartsCommsButton.Location = new System.Drawing.Point(1146, 511);
            this.StartsCommsButton.Name = "StartsCommsButton";
            this.StartsCommsButton.Size = new System.Drawing.Size(229, 79);
            this.StartsCommsButton.TabIndex = 5;
            this.StartsCommsButton.Text = "Start Comms";
            this.StartsCommsButton.UseVisualStyleBackColor = true;
            this.StartsCommsButton.Click += new System.EventHandler(this.StartsCommsButton_Click);
            // 
            // serialRadioButton
            // 
            this.serialRadioButton.AutoSize = true;
            this.serialRadioButton.Location = new System.Drawing.Point(990, 401);
            this.serialRadioButton.Name = "serialRadioButton";
            this.serialRadioButton.Size = new System.Drawing.Size(27, 26);
            this.serialRadioButton.TabIndex = 4;
            this.serialRadioButton.TabStop = true;
            this.serialRadioButton.UseVisualStyleBackColor = true;
            // 
            // serialOpenButton
            // 
            this.serialOpenButton.Location = new System.Drawing.Point(1146, 374);
            this.serialOpenButton.Name = "serialOpenButton";
            this.serialOpenButton.Size = new System.Drawing.Size(229, 80);
            this.serialOpenButton.TabIndex = 3;
            this.serialOpenButton.Text = "Serial On/Off";
            this.serialOpenButton.UseVisualStyleBackColor = true;
            this.serialOpenButton.Click += new System.EventHandler(this.serialOpenButton_Click);
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(1146, 252);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(229, 37);
            this.baudRateComboBox.TabIndex = 2;
            // 
            // portComboBox
            // 
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(1146, 124);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(229, 37);
            this.portComboBox.TabIndex = 1;
            // 
            // serialStatusTextBox
            // 
            this.serialStatusTextBox.Location = new System.Drawing.Point(103, 92);
            this.serialStatusTextBox.Name = "serialStatusTextBox";
            this.serialStatusTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.serialStatusTextBox.Size = new System.Drawing.Size(564, 572);
            this.serialStatusTextBox.TabIndex = 0;
            this.serialStatusTextBox.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.trackValueLabel);
            this.tabPage2.Location = new System.Drawing.Point(10, 47);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1630, 761);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Control";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(763, 392);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(675, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "LightControl";
            // 
            // trackValueLabel
            // 
            this.trackValueLabel.Location = new System.Drawing.Point(491, 311);
            this.trackValueLabel.Maximum = 255;
            this.trackValueLabel.Name = "trackValueLabel";
            this.trackValueLabel.Size = new System.Drawing.Size(625, 101);
            this.trackValueLabel.TabIndex = 0;
            this.trackValueLabel.Scroll += new System.EventHandler(this.lightTrackBar_Scroll);
            // 
            // commsTestButton
            // 
            this.commsTestButton.Location = new System.Drawing.Point(1146, 643);
            this.commsTestButton.Name = "commsTestButton";
            this.commsTestButton.Size = new System.Drawing.Size(229, 77);
            this.commsTestButton.TabIndex = 9;
            this.commsTestButton.Text = "Test Comms";
            this.commsTestButton.UseVisualStyleBackColor = true;
            this.commsTestButton.Click += new System.EventHandler(this.commsTestButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(2061, 894);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Light Control";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackValueLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton readingMicroRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartsCommsButton;
        private System.Windows.Forms.RadioButton serialRadioButton;
        private System.Windows.Forms.Button serialOpenButton;
        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.RichTextBox serialStatusTextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackValueLabel;
        private System.Windows.Forms.Button commsTestButton;
    }
}

