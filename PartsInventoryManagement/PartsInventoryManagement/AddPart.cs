using System;
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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        //**  Save button calls verify method  **//
        private void AddPartSavebutton_Click(object sender, EventArgs e)
        {
            CheckInput();
        }

        //**  Verifies if entered information is correct and creates either inhouse or outsourced part  **//
        private void VerifyPartSave()
        {
            //if (int.Parse(addPartMinTextBox.Text) > int.Parse(addPartMaxTextBox.Text))
            //{
            //    MessageBox.Show("The minimum amount cannot exceed the maximum");
            //}

            if (addPartInHouseRadio.Checked)
            {
                //int counter = Inventory.Products.Count;
                InHouse inHouse = new InHouse(partID, addPartNameTextBox.Text, decimal.Parse(addPriceTextBox.Text),
                int.Parse(addInvTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(IDNameTextBox.Text));
                Inventory.AddPart(inHouse);
            }
            else
            {
                int partID = Inventory.AllParts[Inventory.AllParts.Count - 1].PartID + 1;
                Outsourced outsourcedPart = new Outsourced(partID, addPartNameTextBox.Text, decimal.Parse(addPriceTextBox.Text),
                int.Parse(addInvTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(addPartMaxTextBox.Text), IDNameTextBox.Text);
                Inventory.AddPart(outsourcedPart);
            }
            this.Close();
        }

        private void AddPartOutsourceRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (addPartOutsourceRadio.Checked)
            {
                addPartIDorNameLabel.Text = "Company Name";
            }
            else
            {
                addPartIDorNameLabel.Text = "Machine ID";
            }
        }

        private void AddPartCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //**  Final Validation  **//

        private void CheckInput()
        {
            if (this.ValidateChildren())
            {
                
                if (int.Parse(addInvTextBox.Text) >= int.Parse(addPartMinTextBox.Text) && int.Parse(addInvTextBox.Text) <= int.Parse(addPartMaxTextBox.Text))
                {
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

        private void AddPartNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidName(addPartNameTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                addPartNameTextBox.Focus();
                addPartNameTextBox.Select(0, addPartNameTextBox.TextLength);
                this.errorProvider1.SetError(addPartNameTextBox, errorMessage);
            }
        }

        public bool ValidName(string partName, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(addPartNameTextBox.Text))
            {
                errorMessage = "A name is required!";
                return false;
            }
            else
            {
                errorMessage = "";
                //errorProvider1.Clear();
                return true;
            }
        }

        //**  Inventory validation  **//

        private void AddInvTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidInventory(addInvTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                addInvTextBox.Focus();
                addInvTextBox.Select(0, addInvTextBox.TextLength);

                this.errorProvider1.SetError(addInvTextBox, errorMessage);
            }
        }

        public bool ValidInventory(string inventory, out string errorMessage)
        {
            errorMessage = "Inventory amount is required!";
            if (string.IsNullOrWhiteSpace(addInvTextBox.Text))
            {
                //errorMessage = "Inventory amount is required!";
                return false;
            }
            else if (addInvTextBox.TextLength > 0)
            {
                errorMessage = "";
                //errorProvider1.Clear();
                return true;
            }

            return false;
        }

        private void AddInvTextBox_KeyPress(object sender, KeyPressEventArgs e)
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
            if (addPriceTextBox.TextLength > 0 && regex.IsMatch(addPriceTextBox.Text))
            {
                //addPriceTextBox.ForeColor = Color.Green;    //for testing valid inputs
                //errorProvider1.Clear();
                errorMessage = "";
                return true;
            }

            return false;
        }

        private void AddPriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidatedPrice(addPriceTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                addPriceTextBox.Focus();
                addPriceTextBox.Select(0, addPriceTextBox.TextLength);

                this.errorProvider1.SetError(addPriceTextBox, errorMessage);
            }
        }

        private void AddPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //**  Min/Max textbox modifications  **//

        private void AddPartMaxTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidPartMax(addPartMaxTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                addPartMaxTextBox.Focus();
                addPartMaxTextBox.Select(0, addPartMaxTextBox.TextLength);

                this.errorProvider1.SetError(addPartMaxTextBox, errorMessage);
            }
        }

        public bool ValidPartMax(string max, out string errorMessage)
        {
            errorMessage = ("Enter the maximum number of parts.");
             if (!string.IsNullOrEmpty(addPartMaxTextBox.Text))
            {
                errorMessage = "";
                //errorProvider1.Clear();
                return true;
            }
            return false;
        }

        private void AddPartMinTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidPartMin(addPartMinTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                addPartMinTextBox.Focus();
                addPartMinTextBox.Select(0, addPartMinTextBox.TextLength);

                this.errorProvider1.SetError(addPartMinTextBox, errorMessage);
            }
        }

        public bool ValidPartMin(string min, out string errorMessage)
        {
            errorMessage = ("Enter the minimum number of parts.");
            if (!string.IsNullOrEmpty(addPartMinTextBox.Text))
            {
                errorMessage = "";
                //errorProvider1.Clear();
                return true;
            }
            return false;
        }

        private void AddPartMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddPartMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //**  MachineID/Company textbox validation  **//

        private void IDNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (addPartInHouseRadio.Checked)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
        }

        private void IDNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidIDName(IDNameTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                IDNameTextBox.Focus();
                IDNameTextBox.Select(0, IDNameTextBox.TextLength);

                this.errorProvider1.SetError(IDNameTextBox, errorMessage);
            }
        }

        private bool ValidIDName(string id, out string errorMessage)
        {
            errorMessage = ("Enter the Machine ID or Vendor Name.");
            if (!string.IsNullOrEmpty(IDNameTextBox.Text))
            {
                errorMessage = "";
                errorProvider1.Clear();
                return true;
            }
            return false;
        }

    }
}
  