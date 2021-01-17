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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        // Save button calls verify method
        private void AddPartSavebutton_Click(object sender, EventArgs e)
        {
            VerifyPartSave();

        }

        // verifies if entered information is correct and creates either inhouse or outsourced part
        private void VerifyPartSave()
        {
            if (int.Parse(addPartMinTextBox.Text) > int.Parse(addPartMaxTextBox.Text))
            {
                MessageBox.Show("The minimum amount cannot exceed the maximum");
                return;
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

        // methods for part name validation
        private void addPartNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidName(addPartNameTextBox.Text, out string errorMessage))
            {
                //e.Cancel = true;
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
                //e.Cancel = true;
                addInvTextBox.Focus();
                addInvTextBox.Select(0, addInvTextBox.TextLength);

                this.errorProvider1.SetError(addInvTextBox, errorMessage);
            }
        }

        public bool ValidInventory(string inventory, out string errorMessage)
        {
            if (addInvTextBox.TextLength == 0)
            {
                errorMessage = "Inventory amount is required!";
                return false;
            }
            else if (addInvTextBox.TextLength > 0)
            {
                errorMessage = "";
                errorProvider1.Clear();
                return true;
            }

            errorMessage = "Name must be numbers!";
            return false;
        }
    }
}
  