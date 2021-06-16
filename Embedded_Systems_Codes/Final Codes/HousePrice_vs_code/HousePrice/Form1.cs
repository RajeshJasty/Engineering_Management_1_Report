using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HousePrice
{
    public partial class Form1 : Form
    {
        HousePrice myHouse = new HousePrice();
        public Form1()
        {
            InitializeComponent();

            string[] houseTypeItems = new string[] { "Villa", "Modern", "Bungalow" };
            HouseTypeComboBox.DataSource = houseTypeItems;
            HouseTypeComboBox.SelectedIndex = 0;

            string[] houseLocationItems = new string[] { "takapuna", "Albany", "Warkworth" };
            HouseLocationComboBox.DataSource = houseLocationItems;
            HouseLocationComboBox.SelectedIndex = 1;

            string[] houseYearItems = new string[] { "above 2000", "1960 to 2000", "Up to 1960" };
            HouseYearComboBox.DataSource = houseYearItems;
            HouseYearComboBox.SelectedIndex = 2;

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            decimal calculation;

            myHouse.houseType = HouseTypeComboBox.SelectedIndex;
            myHouse.houseLocation = HouseLocationComboBox.SelectedIndex;
            myHouse.houseYear = HouseYearComboBox.SelectedIndex;

            calculation = myHouse.CalculateValue();

            HouseCostTextBox.Text = ("s" + calculation.ToString());
        }

        class HousePrice
        {
            public int houseType, houseLocation, houseYear;

            public decimal CalculateValue()
            {
                decimal houseValue, typeMultiplier, locationMultiplier, yearMulatiplier;
                if (houseType == 0)         // Villa
                    typeMultiplier = 1.5M;
                else if (houseType == 1)    // Modern
                    typeMultiplier = 1M;
                else                        // Bungalow
                    typeMultiplier = 0.5M;
                if (houseLocation == 0)     // Takapuna
                    locationMultiplier = 1.5M;
                else if (houseType == 1)    // Albany
                    locationMultiplier = 1M;
                else                        // Warkworth
                    locationMultiplier = 0.5M;
                if (houseYear == 0)         // >2000
                    yearMulatiplier = 1.5M;
                else if (houseType == 1)    // 1960-200
                    yearMulatiplier = 1M;
                else                        // <1960
                    yearMulatiplier = 0.5M;

                houseValue = 1000000 * typeMultiplier * yearMulatiplier * locationMultiplier;

                return houseValue;

                
            }
        }
    }
}
