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
    public partial class AddProduct : Form
    {
        Product product = new Product();

        public AddProduct()
        {
            InitializeComponent();
            AddProductLoadScreen();
        }

        private void CancelProductButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            this.Close();
        }

        private void AddProductLoadScreen()
        {
            AllPartsDataGrid.DataSource = Inventory.AllParts;

            AllPartsDataGrid.Columns["PartID"].HeaderText = "Part ID";
            AllPartsDataGrid.Columns["Name"].HeaderText = "Part Name";
            AllPartsDataGrid.Columns["InStock"].HeaderText = "Inventory";
            AllPartsDataGrid.Columns["Price"].HeaderText = "Price";
            AllPartsDataGrid.Columns["Min"].HeaderText = "Min";
            AllPartsDataGrid.Columns["Max"].HeaderText = "Max";

            AssociatedPartsDGV.DataSource = product.AssociatedParts;

            AssociatedPartsDGV.Columns["PartID"].HeaderText = "Part ID";
            AssociatedPartsDGV.Columns["Name"].HeaderText = "Part Name";
            AssociatedPartsDGV.Columns["InStock"].HeaderText = "Inventory";
            AssociatedPartsDGV.Columns["Price"].HeaderText = "Price";
            AssociatedPartsDGV.Columns["Min"].HeaderText = "Min";
            AssociatedPartsDGV.Columns["Max"].HeaderText = "Max";
        }

        //** Creates product **//
        private void VerifyProductSave()
        {

            int productID = Inventory.AssignProductID();
            Product newProduct = new Product(productID, AddProdNameTextBox.Text, decimal.Parse(AddProdPriceTextBox.Text), int.Parse(AddProdInvTextBox.Text),
            int.Parse(AddProdMinTextBox.Text), int.Parse(AddProdMaxTextBox.Text));
            Inventory.AddProduct(newProduct);

            foreach (DataGridViewRow row in AssociatedPartsDGV.Rows)
            {
                Part addedPart = (Part)row.DataBoundItem;
                newProduct.AssociatedParts.Add(addedPart);
            }
            this.Close();
        }

        //** Validate min/max/inv values and returns boolean **//
        private bool IsBetween()
        {
            var inv = int.Parse(AddProdInvTextBox.Text);
            var min = int.Parse(AddProdMinTextBox.Text);
            var max = int.Parse(AddProdMaxTextBox.Text);

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
        private void SaveProductButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                if (IsBetween())
                {
                    errorProvider1.Clear();
                    VerifyProductSave();
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

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            Part addedPart = (Part)AllPartsDataGrid.CurrentRow.DataBoundItem;
            product.AddAssociatedPart(addedPart);
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AssociatedPartsDGV.SelectedRows)
            {
                AssociatedPartsDGV.Rows.RemoveAt(row.Index);
            }
        }

        private void ModProductSearchButton_Click(object sender, EventArgs e)
        {
            if (AddSearchTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(AddSearchTextBox.Text.ToUpper()))
                    {
                        int searchPart = Inventory.AllParts[i].PartID;
                        Part partFound = Inventory.LookupPart(searchPart);

                        foreach (DataGridViewRow row in AllPartsDataGrid.Rows)
                        {
                            Part part = (Part)row.DataBoundItem;
                            if (part.PartID == partFound.PartID)
                            {
                                row.Selected = true;
                                break;
                            }
                            else
                            {
                                row.Selected = false;
                            }
                        }
                    }
                }
            }
        }

        //** Product Name Validation **//
        private void AddProdNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidName(AddProdNameTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                AddProdNameTextBox.Select(0, AddProdNameTextBox.TextLength);

                this.errorProvider1.SetError(AddProdNameTextBox, errorMessage);
            }
        }

        public bool ValidName(string productName, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(AddProdNameTextBox.Text))
            {
                errorMessage = "A name is required!";
                return false;
            }
            else
            {
                errorMessage = "";
                errorProvider1.SetError(AddProdNameTextBox, errorMessage);
                return true;
            }
        }

        //** Product Inventory Validation **//
        private void addInvTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidInventory(AddProdInvTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                AddProdInvTextBox.Select(0, AddProdInvTextBox.TextLength);
                this.errorProvider1.SetError(AddProdInvTextBox, errorMessage);
            }
        }

        public bool ValidInventory(string inventory, out string errorMessage)
        {
            errorMessage = "Inventory amount is required!";
            if (AddProdInvTextBox.TextLength > 0)
            {
                errorMessage = "";
                errorProvider1.SetError(AddProdInvTextBox, errorMessage);
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

        private void AddPriceTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidatedPrice(AddProdPriceTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(AddProdPriceTextBox, errorMessage);
            }
        }

        public bool ValidatedPrice(string price, out string errorMessage)
        {
            errorMessage = "Please enter a numeric price.  For example 24.99";
            if (AddProdPriceTextBox.TextLength > 0 && regex.IsMatch(AddProdPriceTextBox.Text))
            {
                //addPriceTextBox.ForeColor = Color.Green;    //for testing valid inputs
                errorMessage = "";
                errorProvider1.SetError(AddProdPriceTextBox, errorMessage);
                return true;
            }
            return false;
        }

        private void AddPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //**  Min/Max Product Validation  **//
        private void AddMaxTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidProductMax(AddProdMaxTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                AddProdMaxTextBox.Select(0, AddProdMaxTextBox.TextLength);
                this.errorProvider1.SetError(AddProdMaxTextBox, errorMessage);
            }
        }

        public bool ValidProductMax(string max, out string errorMessage)
        {
            errorMessage = ("Enter the maximum number of parts.");
            if (AddProdMaxTextBox.TextLength > 0)
            {
                errorMessage = "";
                errorProvider1.SetError(AddProdMaxTextBox, errorMessage);
                return true;
            }
            return false;
        }

        private void AddMinTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidProductMin(AddProdMinTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                AddProdMinTextBox.Select(0, AddProdMinTextBox.TextLength);
                this.errorProvider1.SetError(AddProdMinTextBox, errorMessage);
            }
        }

        public bool ValidProductMin(string min, out string errorMessage)
        {
            errorMessage = ("Enter the minimum number of parts.");
            if (AddProdMinTextBox.TextLength > 0)
            {
                errorMessage = "";
                errorProvider1.SetError(AddProdMinTextBox, errorMessage);
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
    }
}
