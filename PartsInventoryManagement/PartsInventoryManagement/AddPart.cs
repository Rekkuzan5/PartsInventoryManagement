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
            //addPartNameTextBox.Focus();
        }

        private void AddPart_Load(object sender, EventArgs e)
        {
            
        }

        // Save button calls verify method
        private void AddPartSavebutton_Click(object sender, EventArgs e)
        {
            CheckInput();
        }

        // verifies if entered information is correct and creates either inhouse or outsourced part
        private void VerifyPartSave()
        {


            if (int.Parse(addPartMinTextBox.Text) > int.Parse(addPartMaxTextBox.Text))
            {
                MessageBox.Show("The minimum amount cannot exceed the maximum");
            }

            if (addPartInHouseRadio.Checked)
            {
                int partID = Inventory.AllParts[Inventory.AllParts.Count - 1].PartID + 1;
                InHouse inHouse = new InHouse(partID, addPartNameTextBox.Text, decimal.Parse(addPriceTextBox.Text),
                int.Parse(addInvTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(addPartMaxTextBox.Text), int.Parse(IDNameTextBox.Text));
                Inventory.AddPart(inHouse);
            }
            else
            {
                int partID = (Inventory.AllParts[Inventory.AllParts.Count - 1].PartID + 1);
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

        //-- Validation --//

        // Verify all textboxes are filled before saving //

        //private bool ValidateTextBoxes()
        //{
        //    //ValidateTextBoxes();

        //CheckInput(addPartNameTextBox);
        //CheckInput(addInvTextBox);
        //CheckInput(addPriceTextBox);
        //CheckInput(addPartMaxTextBox);
        //CheckInput(addPartMinTextBox);
        //CheckInput(IDNameTextBox);
        //}

        //public override bool ValidateChildren()
        //{

        //}

        //private void CheckInput_Validating(object sender, CancelEventArgs e)
        //{
        //    if (CheckInput())
        //    {
        //        e.Cancel = true;
        //        MessageBox.Show("All fields must be completed before saving.");
        //    }
        //    else
        //    {
        //        VerifyPartSave();
        //    }
        //}

        private void CheckInput()
        {
            if (this.ValidateChildren())
            {
                VerifyPartSave();
            }
            else
            {
                MessageBox.Show("All fields must be completed before saving.");
            }
            //foreach (Control c in this.Controls)
            //{
            //    if (c is TextBox)
            //    {
            //        if (string.IsNullOrEmpty(c.Text))
            //        {
            //            MessageBox.Show("All fields must be completed before saving.");
            //            //addPartSavebutton.Enabled = false;
            //            break;
            //        }
            //        if (!string.IsNullOrEmpty(c.Text))
            //        {
            //            addPartSavebutton.Enabled = true;
            //            VerifyPartSave();
            //        }
            //    }
            //}

        }

        // methods for part name validation
        private void AddPartNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidName(addPartNameTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                addPartNameTextBox.Focus();
                //addPartNameTextBox.Select(0, addPartNameTextBox.TextLength);
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
                errorProvider1.Clear();
                return true;
            }
        }



        // Inventory validation //

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
            if (addInvTextBox.TextLength == 0)
            {
                //errorMessage = "Inventory amount is required!";
                return false;
            }
            else if (addInvTextBox.TextLength > 0)
            {
                errorMessage = "";
                errorProvider1.Clear();
                return true;
            }

            //errorMessage = "Must be numbers!";
            return false;
        }

        private void AddInvTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // ---------- ********** need to fix the textboxes that aren't correct with regex ********** --------- //


        //**  Checks for valid price input using Regex to verify proper format  **//

        Regex regex = new Regex("^\\d*(\\.\\d{1,2})?$");

        public bool ValidatedPrice(string price, out string errorMessage)
        {
            errorMessage = "Please enter a numeric price.  For example 24.99";
            if (addPriceTextBox.TextLength > 0 && regex.IsMatch(addPriceTextBox.Text))
            {
                //addPriceTextBox.ForeColor = Color.Green;    //for testing valid inputs
                errorProvider1.Clear();
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

        //**  End of price validation  **//

        //**  Min/Max textbox modifications  **//

        private void addPartMaxTextBox_Validating(object sender, CancelEventArgs e)
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
             if (addPartMaxTextBox.TextLength > 0)
            {
                errorMessage = "";
                errorProvider1.Clear();
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

        private void InvalidMinMax()
        {
            if (int.Parse(addPartMinTextBox.Text) > int.Parse(addPartMaxTextBox.Text))
            {
                MessageBox.Show("The minimum amount cannot exceed the maximum");

            }
        }

        //**  End of Min/Max Modifications  **//

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

        

        //**  End of Machine/Company textbox validation  **//
    }
}
  