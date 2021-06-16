using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box_Measerments
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   
            string[] height = new string[] { "100" };
            HeightComboBox.DataSource = height;
            string[] width = new string[]  { "180" };
            WidthComboBox.DataSource = width;           
            string[] Length = new string[] { "160" };
            LengthComboBox.DataSource = Length;                      
                     
        }
    }

}

