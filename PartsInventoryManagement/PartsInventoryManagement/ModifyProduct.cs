﻿using System;
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
        public ModifyProduct()
        {
            InitializeComponent();
            ModifyProductScreenLoad();
        }

        public void ModifyProductScreenLoad()
        {
            var modProduct = new BindingSource();
            modProduct.DataSource = Inventory.AllParts;
            partToProductDataGrid.DataSource = modProduct;

            partToProductDataGrid.Columns["PartID"].HeaderText = "Part ID";
            partToProductDataGrid.Columns["Name"].HeaderText = "Part Name";
            partToProductDataGrid.Columns["InStock"].HeaderText = "Inventory";
            partToProductDataGrid.Columns["Price"].HeaderText = "Price";
            partToProductDataGrid.Columns["Min"].HeaderText = "Minimun";
            partToProductDataGrid.Columns["Max"].HeaderText = "Max";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyProductSearchButton(object sender, EventArgs e)
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
