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

            var modProduct = new BindingSource();
            modProduct.DataSource = Inventory.AllParts;
            partToProductDataGrid.DataSource = modProduct;

            partToProductDataGrid.Columns["PartID"].HeaderText = "Part ID";
            partToProductDataGrid.Columns["Name"].HeaderText = "Part Name";
            partToProductDataGrid.Columns["InStock"].HeaderText = "Inventory";
            partToProductDataGrid.Columns["Price"].HeaderText = "Price";
            partToProductDataGrid.Columns["Min"].HeaderText = "Minimun";
            partToProductDataGrid.Columns["Max"].HeaderText = "Max";

            var modProductParts = new BindingSource();
            modProductParts.DataSource = Product.AssociatedParts;
            associatedPartsDGV.DataSource = modProductParts;

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
    }
}
