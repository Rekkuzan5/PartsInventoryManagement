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
    public partial class ModifyProduct : Form
    {
        //BindingList<Part> ModPartsToAdd = new BindingList<Part>();

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

            //var modProduct = new BindingSource();
            //modProduct.DataSource = Inventory.AllParts;
            partToProductDataGrid.DataSource = Inventory.AllParts;

            partToProductDataGrid.Columns["PartID"].HeaderText = "Part ID";
            partToProductDataGrid.Columns["Name"].HeaderText = "Part Name";
            partToProductDataGrid.Columns["InStock"].HeaderText = "Inventory";
            partToProductDataGrid.Columns["Price"].HeaderText = "Price";
            partToProductDataGrid.Columns["Min"].HeaderText = "Minimun";
            partToProductDataGrid.Columns["Max"].HeaderText = "Max";
         
            //foreach (Part existingPart in moddedProduct.AssociatedParts)
            //{
            //    ModPartsToAdd.Add(existingPart);
            //}

            //var modProductParts = new BindingSource();
            //modProductParts.DataSource = moddedProduct.AssociatedParts;
            associatedPartsDGV.DataSource = moddedProduct.AssociatedParts;

            associatedPartsDGV.Columns["PartID"].HeaderText = "Part ID";
            associatedPartsDGV.Columns["Name"].HeaderText = "Part Name";
            associatedPartsDGV.Columns["InStock"].HeaderText = "Inventory";
            associatedPartsDGV.Columns["Price"].HeaderText = "Price";
            associatedPartsDGV.Columns["Min"].HeaderText = "Minimun";
            associatedPartsDGV.Columns["Max"].HeaderText = "Max";
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void AddPartToProduct_Click(object sender, EventArgs e)
        {
            //Part addedPart = (Part)partToProductDataGrid.CurrentRow.DataBoundItem;
            //.Add(addedPart);

            int productID = int.Parse(modProductIDTextBox.Text);
            int partID = Convert.ToInt32(partToProductDataGrid.Rows[partToProductDataGrid.CurrentCell.RowIndex].Cells[0].Value);

            Product product = Inventory.LookupProduct(productID);
            Part part = Inventory.LookupPart(partID);
            Inventory.UpdateProduct(productID, product);
            product.AddAssociatedPart(part);
            associatedPartsDGV.DataSource = product.AssociatedParts;
        }

        private void DeletePartFromProduct_Click(object sender, EventArgs e)
        {
           // if (P.Count > 0)
            //{
                //int partID = int.Parse(associatedPartsDGV.Rows[associatedPartsDGV.CurrentCell.RowIndex].Cells[0].Value.ToString());
                //Product.RemoveAssociatedPart(partID);

                //foreach (DataGridViewRow row in associatedPartsDGV.SelectedRows)
                //{
                //    associatedPartsDGV.Rows.RemoveAt(row.Index);
                //}

                //Part currentPart = (Part)associatedPartsDGV.CurrentRow.DataBoundItem;

                //int lookupID = int.Parse(modProductIDTextBox.Text);
                //Product currentProd = Inventory.LookupProduct(lookupID);
                //currentProd.RemoveAssociatedPart(currentPart.PartID);

                foreach (DataGridViewRow row in associatedPartsDGV.SelectedRows)
                {
                    associatedPartsDGV.Rows.RemoveAt(row.Index);
                }
            //}
        }

        private void SaveModifiedPart_Click(object sender, EventArgs e)
        {
            Product modifiedProduct = new Product(int.Parse(modProductIDTextBox.Text), modProductNameTextBox.Text, decimal.Parse(modProductInvTextBox.Text), int.Parse(modProductPriceTextBox.Text), int.Parse(modProductMaxTextBox.Text), int.Parse(modProductMinTextBox.Text));
            
            //foreach (Part addedPart in ModPartsToAdd)
            //{
            //    modifiedProduct.AddAssociatedPart(addedPart);
            //}

            foreach (DataGridViewRow row in associatedPartsDGV.Rows)
            {
                Part associatedPart = (Part)row.DataBoundItem;
                modifiedProduct.AssociatedParts.Add(associatedPart);
            }

            Inventory.UpdateProduct(int.Parse(modProductIDTextBox.Text), modifiedProduct);

            //foreach (DataGridViewRow row in associatedPartsDGV.Rows)
            //{
            //    Part associatedPart = (Part)row.DataBoundItem;
            //    Product.AssociatedParts.Add(associatedPart);
            //}
            //Inventory.updateProduct(int.Parse(modProductIDTextBox.Text), modifiedProduct);
            this.Close();
        }
    }
}
