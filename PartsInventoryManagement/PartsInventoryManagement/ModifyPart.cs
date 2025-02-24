﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

        private void ModPart_Load(object sender, EventArgs e)
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

        private void ModifyPartCancelButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
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

        private void VerifyPartSave()
        {
            if (InHouseRadButton.Checked)
            {
                InHouse inHousePart = new InHouse(int.Parse(modPartIDTextBox.Text), modNameTextBox.Text, decimal.Parse(modPriceTextBox.Text),
                int.Parse(modInventoryTextBox.Text), int.Parse(modMinTextBox.Text), int.Parse(modMaxTextBox.Text), int.Parse(modMachineIDTextBox.Text));
                Inventory.UpdatePart(int.Parse(modPartIDTextBox.Text), inHousePart);
                InHouseRadButton.Checked = true;
            }
            else if (OutsourcedRadButton.Checked)
            {
                Outsourced outsourcedPart = new Outsourced(int.Parse(modPartIDTextBox.Text), modNameTextBox.Text, decimal.Parse(modPriceTextBox.Text),
                int.Parse(modInventoryTextBox.Text), int.Parse(modMinTextBox.Text), int.Parse(modMaxTextBox.Text), modMachineIDTextBox.Text);
                Inventory.UpdatePart(int.Parse(modPartIDTextBox.Text), outsourcedPart);
                OutsourcedRadButton.Checked = true;
            }
            this.Close();
        }

        private void ModPartOutsourceRadio_CheckedChanged(object sender, EventArgs e)
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

        private void ModPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //** Validate min/max/inv values and returns boolean **//
        private bool IsBetween()
        {
            var inv = int.Parse(modInventoryTextBox.Text);
            var min = int.Parse(modMinTextBox.Text);
            var max = int.Parse(modMaxTextBox.Text);

            if ((min >= max) || (inv < min) || (inv > max))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //** If all child textboxes of form validate, evaluate the inventory and min/max logic and call save function.  If false, then display messagebox. **//
        private void Partsavebutton_click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (IsBetween())
                {
                    errorProvider1.Clear();
                    VerifyPartSave();
                }
                else
                {
                    MessageBox.Show("The minimum amount cannot be equal to or exceed the maximum.  Inventory must be within the minimum and maximum.");
                }
            }
            else
            {
                MessageBox.Show("All fields must be completed before saving.");
            }
        }

        //**  Methods for part name validation  **//

        private void ModPartNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidName(modNameTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                modNameTextBox.Select(0, modNameTextBox.TextLength);
                this.errorProvider1.SetError(modNameTextBox, errorMessage);
            }
        }

        public bool ValidName(string partName, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(modNameTextBox.Text))
            {
                errorMessage = "A name is required!";
                return false;
            }
            else
            {
                errorMessage = "";
                errorProvider1.SetError(modNameTextBox, errorMessage);
                return true;
            }
        }

        //**  Inventory validation  **//
        private void ModInvTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidInventory(modInventoryTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                modInventoryTextBox.Select(0, modInventoryTextBox.TextLength);
                this.errorProvider1.SetError(modInventoryTextBox, errorMessage);
            }
        }

        public bool ValidInventory(string inventory, out string errorMessage)
        {
            errorMessage = "Inventory amount is required!";
            if (modInventoryTextBox.TextLength > 0)
            {
                errorMessage = "";
                errorProvider1.SetError(modInventoryTextBox, errorMessage);
                return true;
            }
            return false;
        }

        private void ModInvTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //**  Checks for valid price input using Regex to verify proper format  **//

        Regex regex = new Regex("^\\d*(\\.\\d{1,2})?$");

        public bool ValidatedPrice(string price, out string errorMessage)
        {
            errorMessage = "Please enter a numeric price.  For example 24.99";
            if (modPriceTextBox.TextLength > 0 && regex.IsMatch(modPriceTextBox.Text))
            {
                //modPriceTextBox.ForeColor = Color.Green;    //for testing valid inputs
                errorMessage = "";
                errorProvider1.SetError(modPriceTextBox, errorMessage);
                return true;
            }
            return false;
        }

        private void ModPriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidatedPrice(modPriceTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                errorProvider1.SetError(modPriceTextBox, errorMessage);
            }
        }

        private void ModPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //**  Min/Max textbox modifications  **//

        private void ModPartMaxTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidPartMax(modMaxTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                modMaxTextBox.Select(0, modMaxTextBox.TextLength);
                this.errorProvider1.SetError(modMaxTextBox, errorMessage);
            }
        }

        public bool ValidPartMax(string max, out string errorMessage)
        {
            errorMessage = ("Enter the maximum number of parts.");
            if (modMaxTextBox.TextLength > 0)
            {
                errorMessage = "";
                this.errorProvider1.SetError(modMaxTextBox, errorMessage);
                return true;
            }
            return false;
        }

        private void ModPartMinTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidPartMin(modMinTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                modMinTextBox.Select(0, modMinTextBox.TextLength);
                this.errorProvider1.SetError(modMinTextBox, errorMessage);
            }
        }

        public bool ValidPartMin(string min, out string errorMessage)
        {
            errorMessage = ("Enter the minimum number of parts.");
            if (modMinTextBox.TextLength > 0)
            {
                errorMessage = "";
                this.errorProvider1.SetError(modMinTextBox, errorMessage);
                return true;
            }
            return false;
        }

        private void ModPartMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ModPartMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //**  MachineID/Company textbox validation  **//
        private void IDNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (InHouseRadButton.Checked)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void IDNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidIDName(modMachineIDTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                modMachineIDTextBox.Select(0, modMachineIDTextBox.TextLength);
                this.errorProvider1.SetError(modMachineIDTextBox, errorMessage);
            }
        }

        private bool ValidIDName(string id, out string errorMessage)
        {
            errorMessage = ("Enter the Machine ID or Vendor Name.");
            if (modMachineIDTextBox.TextLength > 0)
            {
                errorMessage = "";
                this.errorProvider1.SetError(modMachineIDTextBox, errorMessage);
                return true;
            }
            return false;
        }
    }
}
