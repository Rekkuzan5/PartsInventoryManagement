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
    public partial class ModifyProduct : Form
    {

        public ModifyProduct(Product product)
        {
            InitializeComponent();
            ModifyProductScreenLoad(product);
        }

        public void ModifyProductScreenLoad(Product moddedProduct)
        {
            modProductIDTextBox.Text = moddedProduct.ProductID.ToString();
            modProductNameTextBox.Text = moddedProduct.Name.ToString();
            modProductInvTextBox.Text = moddedProduct.InStock.ToString();
            modProductPriceTextBox.Text = moddedProduct.Price.ToString();
            modProductMaxTextBox.Text = moddedProduct.Max.ToString();
            modProductMinTextBox.Text = moddedProduct.Min.ToString();

            partToProductDataGrid.DataSource = Inventory.AllParts;

            partToProductDataGrid.Columns["PartID"].HeaderText = "Part ID";
            partToProductDataGrid.Columns["Name"].HeaderText = "Part Name";
            partToProductDataGrid.Columns["InStock"].HeaderText = "Inventory";
            partToProductDataGrid.Columns["Price"].HeaderText = "Price";
            partToProductDataGrid.Columns["Min"].HeaderText = "Minimun";
            partToProductDataGrid.Columns["Max"].HeaderText = "Max";
         
            associatedPartsDGV.DataSource = moddedProduct.AssociatedParts;

            associatedPartsDGV.Columns["PartID"].HeaderText = "Part ID";
            associatedPartsDGV.Columns["Name"].HeaderText = "Part Name";
            associatedPartsDGV.Columns["InStock"].HeaderText = "Inventory";
            associatedPartsDGV.Columns["Price"].HeaderText = "Price";
            associatedPartsDGV.Columns["Min"].HeaderText = "Minimun";
            associatedPartsDGV.Columns["Max"].HeaderText = "Max";
        }

        private void modSaveButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            this.Close();
        }

        private void ModifyProductSearchButton_Click(object sender, EventArgs e)
        {
            if (modSearchTextBox.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(modSearchTextBox.Text.ToUpper()))
                    {
                        int searchPart = Inventory.AllParts[i].PartID;
                        Part partFound = Inventory.LookupPart(searchPart);

                        foreach (DataGridViewRow row in partToProductDataGrid.Rows)
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

        //** Adds a part from allparts to a product object's associatedparts **//
        private void AddPartToProduct_Click(object sender, EventArgs e)
        {
            int productID = int.Parse(modProductIDTextBox.Text);
            int partID = Convert.ToInt32(partToProductDataGrid.Rows[partToProductDataGrid.CurrentCell.RowIndex].Cells[0].Value);

            Product product = Inventory.LookupProduct(productID);
            Part part = Inventory.LookupPart(partID);
            Inventory.UpdateProduct(productID, product);
            product.AddAssociatedPart(part);
            associatedPartsDGV.DataSource = product.AssociatedParts;
        }

        //** Deletes a part from a product **//
        private void DeletePartFromProduct_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in associatedPartsDGV.SelectedRows)
            {
                associatedPartsDGV.Rows.RemoveAt(row.Index);
            }
        }

        //** Validate min/max/inv values and returns boolean **//
        private bool IsBetween()
        {
            var inv = int.Parse(modProductInvTextBox.Text);
            var min = int.Parse(modProductMinTextBox.Text);
            var max = int.Parse(modProductMaxTextBox.Text);

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

        //** Creates/updates existing product and adds/removes parts to existing list **//
        private void VerifyProductSave()
        {
            Product modifiedProduct = new Product(int.Parse(modProductIDTextBox.Text), modProductNameTextBox.Text, decimal.Parse(modProductInvTextBox.Text), 
            int.Parse(modProductPriceTextBox.Text), int.Parse(modProductMinTextBox.Text), int.Parse(modProductMaxTextBox.Text));

            foreach (DataGridViewRow row in associatedPartsDGV.Rows)
            {
                Part associatedPart = (Part)row.DataBoundItem;
                modifiedProduct.AssociatedParts.Add(associatedPart);
            }

            Inventory.UpdateProduct(int.Parse(modProductIDTextBox.Text), modifiedProduct);
            this.Close();
        }

        //** Product Name Validation **//
        private void AddProdNameTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidName(modProductNameTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                modProductNameTextBox.Select(0, modProductNameTextBox.TextLength);

                this.errorProvider1.SetError(modProductNameTextBox, errorMessage);
            }
        }

        public bool ValidName(string productName, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(modProductNameTextBox.Text))
            {
                errorMessage = "A name is required!";
                //addPartNameTextBox.Focus();
                return false;
            }
            else
            {
                errorMessage = "";

                errorProvider1.SetError(modProductNameTextBox, errorMessage);
                return true;
            }
        }

        //** Product Inventory Validation **//
        private void addInvTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidInventory(modProductInvTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                modProductInvTextBox.Select(0, modProductInvTextBox.TextLength);

                this.errorProvider1.SetError(modProductInvTextBox, errorMessage);
            }
        }

        public bool ValidInventory(string inventory, out string errorMessage)
        {
            errorMessage = "Inventory amount is required!";
            if (modProductInvTextBox.TextLength > 0)
            {
                errorMessage = "";
                errorProvider1.SetError(modProductInvTextBox, errorMessage);
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
            if (!ValidatedPrice(modProductPriceTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                this.errorProvider1.SetError(modProductPriceTextBox, errorMessage);
            }
        }

        public bool ValidatedPrice(string price, out string errorMessage)
        {
            errorMessage = "Please enter a numeric price.  For example 24.99";
            if (modProductPriceTextBox.TextLength > 0 && regex.IsMatch(modProductPriceTextBox.Text))
            {
                //addPriceTextBox.ForeColor = Color.Green;    //for testing valid inputs
                errorMessage = "";
                errorProvider1.SetError(modProductPriceTextBox, errorMessage);
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
            if (!ValidProductMax(modProductMaxTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                modProductMaxTextBox.Select(0, modProductMaxTextBox.TextLength);

                this.errorProvider1.SetError(modProductMaxTextBox, errorMessage);
            }
        }

        public bool ValidProductMax(string max, out string errorMessage)
        {
            errorMessage = ("Enter the maximum number of parts.");
            if (modProductMaxTextBox.TextLength > 0)
            {
                errorMessage = "";
                errorProvider1.SetError(modProductMaxTextBox, errorMessage);
                return true;
            }
            return false;
        }

        private void AddMinTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (!ValidProductMin(modProductMinTextBox.Text, out string errorMessage))
            {
                e.Cancel = true;
                modProductMinTextBox.Select(0, modProductMinTextBox.TextLength);

                this.errorProvider1.SetError(modProductMinTextBox, errorMessage);
            }
        }

        public bool ValidProductMin(string min, out string errorMessage)
        {
            errorMessage = ("Enter the minimum number of parts.");
            if (modProductMinTextBox.TextLength > 0)
            {
                errorMessage = "";
                errorProvider1.SetError(modProductMinTextBox, errorMessage);
                return true;
            }
            return false;
        }

        private void AddMaxTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddMinTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}

