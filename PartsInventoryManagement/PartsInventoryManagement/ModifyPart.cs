using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PartsInventoryManagement
{
    public partial class ModifyPart : Form
    {
        public ModifyPart()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public ModifyPart(InHouse housePart)
        {
            InitializeComponent();

            modPartIDTextBox.Text = housePart.PartID.ToString();
            modNameTextBox.Text = housePart.Name.ToString();
            modInventoryTextBox.Text = housePart.InStock.ToString();
            modPriceTextBox.Text = housePart.Price.ToString();
            modMaxTextBox.Text = housePart.Max.ToString();
            modMinTextBox.Text = housePart.Min.ToString();
            modMachineIDTextBox.Text = housePart.MachineID.ToString();
            partMachineIDLabel.Text = "Machine ID";
            InHouseRadButton.Checked = true;
        }

        public ModifyPart(Outsourced outsidePart)
        {
            InitializeComponent();

            modPartIDTextBox.Text = outsidePart.PartID.ToString();
            modNameTextBox.Text = outsidePart.Name.ToString();
            modInventoryTextBox.Text = outsidePart.InStock.ToString();
            modPriceTextBox.Text = outsidePart.Price.ToString();
            modMaxTextBox.Text = outsidePart.Max.ToString();
            modMinTextBox.Text = outsidePart.Min.ToString();
            modMachineIDTextBox.Text = outsidePart.CompanyName.ToString();
            partMachineIDLabel.Text = "Company Name";
            OutsourcedRadButton.Checked = true;
        }

        private void modifyPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OutsourcedRadButton_CheckedChanged(object sender, EventArgs e)
        {
            if (OutsourcedRadButton.Checked)
            {
                partMachineIDLabel.Text = "Company Name";
            }
            else
            {
                partMachineIDLabel.Text = "Machine ID";
            }
        }

        //private void PartSaveButton_Click(object sender, EventArgs e)
        //{

        //}
    }
}
