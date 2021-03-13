
namespace PartsInventoryManagement
{
    partial class AddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddProductLabel = new System.Windows.Forms.Label();
            this.AllPartsDataGrid = new System.Windows.Forms.DataGridView();
            this.AssociatedPartsDGV = new System.Windows.Forms.DataGridView();
            this.CancelProductButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.SaveProductButton = new System.Windows.Forms.Button();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.AddSearchTextBox = new System.Windows.Forms.TextBox();
            this.AddProdNameTextBox = new System.Windows.Forms.TextBox();
            this.AddProdInvTextBox = new System.Windows.Forms.TextBox();
            this.AddProdPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddProdMaxTextBox = new System.Windows.Forms.TextBox();
            this.AddProdMinTextBox = new System.Windows.Forms.TextBox();
            this.PartProdGridLabel = new System.Windows.Forms.Label();
            this.AddPartProdGridLabel = new System.Windows.Forms.Label();
            this.ProdNameLabel = new System.Windows.Forms.Label();
            this.ProdInvLabel = new System.Windows.Forms.Label();
            this.ProdPriceLabel = new System.Windows.Forms.Label();
            this.ProdMaxLabel = new System.Windows.Forms.Label();
            this.ProdMinLabel = new System.Windows.Forms.Label();
            this.AddProdIDTextBox = new System.Windows.Forms.TextBox();
            this.ProdIDLabel = new System.Windows.Forms.Label();
            this.modProductSearchButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProductLabel
            // 
            this.AddProductLabel.AutoSize = true;
            this.AddProductLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProductLabel.Location = new System.Drawing.Point(20, 15);
            this.AddProductLabel.Name = "AddProductLabel";
            this.AddProductLabel.Size = new System.Drawing.Size(174, 33);
            this.AddProductLabel.TabIndex = 0;
            this.AddProductLabel.Text = "Add Product";
            // 
            // AllPartsDataGrid
            // 
            this.AllPartsDataGrid.AllowUserToAddRows = false;
            this.AllPartsDataGrid.AllowUserToDeleteRows = false;
            this.AllPartsDataGrid.AllowUserToResizeColumns = false;
            this.AllPartsDataGrid.AllowUserToResizeRows = false;
            this.AllPartsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AllPartsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.AllPartsDataGrid.ColumnHeadersHeight = 30;
            this.AllPartsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AllPartsDataGrid.DefaultCellStyle = dataGridViewCellStyle17;
            this.AllPartsDataGrid.EnableHeadersVisualStyles = false;
            this.AllPartsDataGrid.Location = new System.Drawing.Point(463, 90);
            this.AllPartsDataGrid.MultiSelect = false;
            this.AllPartsDataGrid.Name = "AllPartsDataGrid";
            this.AllPartsDataGrid.ReadOnly = true;
            this.AllPartsDataGrid.RowHeadersVisible = false;
            this.AllPartsDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AllPartsDataGrid.RowTemplate.Height = 30;
            this.AllPartsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AllPartsDataGrid.ShowEditingIcon = false;
            this.AllPartsDataGrid.Size = new System.Drawing.Size(606, 227);
            this.AllPartsDataGrid.TabIndex = 1;
            this.AllPartsDataGrid.TabStop = false;
            // 
            // AssociatedPartsDGV
            // 
            this.AssociatedPartsDGV.AllowUserToAddRows = false;
            this.AssociatedPartsDGV.AllowUserToDeleteRows = false;
            this.AssociatedPartsDGV.AllowUserToResizeColumns = false;
            this.AssociatedPartsDGV.AllowUserToResizeRows = false;
            this.AssociatedPartsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AssociatedPartsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.AssociatedPartsDGV.ColumnHeadersHeight = 30;
            this.AssociatedPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AssociatedPartsDGV.DefaultCellStyle = dataGridViewCellStyle19;
            this.AssociatedPartsDGV.EnableHeadersVisualStyles = false;
            this.AssociatedPartsDGV.Location = new System.Drawing.Point(463, 396);
            this.AssociatedPartsDGV.MultiSelect = false;
            this.AssociatedPartsDGV.Name = "AssociatedPartsDGV";
            this.AssociatedPartsDGV.ReadOnly = true;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AssociatedPartsDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle20;
            this.AssociatedPartsDGV.RowHeadersVisible = false;
            this.AssociatedPartsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AssociatedPartsDGV.RowTemplate.Height = 30;
            this.AssociatedPartsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssociatedPartsDGV.ShowEditingIcon = false;
            this.AssociatedPartsDGV.Size = new System.Drawing.Size(606, 246);
            this.AssociatedPartsDGV.TabIndex = 2;
            this.AssociatedPartsDGV.TabStop = false;
            // 
            // CancelProductButton
            // 
            this.CancelProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelProductButton.Location = new System.Drawing.Point(989, 718);
            this.CancelProductButton.Name = "CancelProductButton";
            this.CancelProductButton.Size = new System.Drawing.Size(80, 30);
            this.CancelProductButton.TabIndex = 10;
            this.CancelProductButton.Text = "Cancel";
            this.CancelProductButton.UseVisualStyleBackColor = true;
            this.CancelProductButton.Click += new System.EventHandler(this.CancelProductButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePartButton.Location = new System.Drawing.Point(989, 648);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(80, 30);
            this.DeletePartButton.TabIndex = 8;
            this.DeletePartButton.Text = "Delete";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // SaveProductButton
            // 
            this.SaveProductButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveProductButton.Location = new System.Drawing.Point(903, 718);
            this.SaveProductButton.Name = "SaveProductButton";
            this.SaveProductButton.Size = new System.Drawing.Size(80, 30);
            this.SaveProductButton.TabIndex = 9;
            this.SaveProductButton.Text = "Save";
            this.SaveProductButton.UseVisualStyleBackColor = true;
            this.SaveProductButton.Click += new System.EventHandler(this.SaveProductButton_Click);
            // 
            // AddPartButton
            // 
            this.AddPartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartButton.Location = new System.Drawing.Point(989, 323);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(80, 30);
            this.AddPartButton.TabIndex = 7;
            this.AddPartButton.Text = "Add";
            this.AddPartButton.UseVisualStyleBackColor = true;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // AddSearchTextBox
            // 
            this.AddSearchTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddSearchTextBox.Location = new System.Drawing.Point(709, 23);
            this.AddSearchTextBox.Name = "AddSearchTextBox";
            this.AddSearchTextBox.Size = new System.Drawing.Size(360, 29);
            this.AddSearchTextBox.TabIndex = 5;
            // 
            // AddProdNameTextBox
            // 
            this.AddProdNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdNameTextBox.Location = new System.Drawing.Point(126, 292);
            this.AddProdNameTextBox.Name = "AddProdNameTextBox";
            this.AddProdNameTextBox.Size = new System.Drawing.Size(275, 26);
            this.AddProdNameTextBox.TabIndex = 0;
            this.AddProdNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddProdNameTextBox_Validating);
            // 
            // AddProdInvTextBox
            // 
            this.AddProdInvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdInvTextBox.Location = new System.Drawing.Point(127, 357);
            this.AddProdInvTextBox.Name = "AddProdInvTextBox";
            this.AddProdInvTextBox.Size = new System.Drawing.Size(274, 26);
            this.AddProdInvTextBox.TabIndex = 1;
            this.AddProdInvTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddInvTextBox_KeyPress);
            this.AddProdInvTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addInvTextBox_Validating);
            // 
            // AddProdPriceTextBox
            // 
            this.AddProdPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdPriceTextBox.Location = new System.Drawing.Point(127, 426);
            this.AddProdPriceTextBox.Name = "AddProdPriceTextBox";
            this.AddProdPriceTextBox.Size = new System.Drawing.Size(274, 26);
            this.AddProdPriceTextBox.TabIndex = 2;
            this.AddProdPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPriceTextBox_KeyPress);
            this.AddProdPriceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddPriceTextBox_Validating);
            // 
            // AddProdMaxTextBox
            // 
            this.AddProdMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdMaxTextBox.Location = new System.Drawing.Point(127, 485);
            this.AddProdMaxTextBox.Name = "AddProdMaxTextBox";
            this.AddProdMaxTextBox.Size = new System.Drawing.Size(90, 26);
            this.AddProdMaxTextBox.TabIndex = 3;
            this.AddProdMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartMaxTextBox_KeyPress);
            this.AddProdMaxTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddMaxTextBox_Validating);
            // 
            // AddProdMinTextBox
            // 
            this.AddProdMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdMinTextBox.Location = new System.Drawing.Point(311, 485);
            this.AddProdMinTextBox.Name = "AddProdMinTextBox";
            this.AddProdMinTextBox.Size = new System.Drawing.Size(90, 26);
            this.AddProdMinTextBox.TabIndex = 4;
            this.AddProdMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartMinTextBox_KeyPress);
            this.AddProdMinTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddMinTextBox_Validating);
            // 
            // PartProdGridLabel
            // 
            this.PartProdGridLabel.AutoSize = true;
            this.PartProdGridLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartProdGridLabel.Location = new System.Drawing.Point(460, 375);
            this.PartProdGridLabel.Name = "PartProdGridLabel";
            this.PartProdGridLabel.Size = new System.Drawing.Size(249, 20);
            this.PartProdGridLabel.TabIndex = 14;
            this.PartProdGridLabel.Text = "Parts Associated with this Product";
            // 
            // AddPartProdGridLabel
            // 
            this.AddPartProdGridLabel.AutoSize = true;
            this.AddPartProdGridLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartProdGridLabel.Location = new System.Drawing.Point(459, 67);
            this.AddPartProdGridLabel.Name = "AddPartProdGridLabel";
            this.AddPartProdGridLabel.Size = new System.Drawing.Size(67, 20);
            this.AddPartProdGridLabel.TabIndex = 15;
            this.AddPartProdGridLabel.Text = "All Parts";
            // 
            // ProdNameLabel
            // 
            this.ProdNameLabel.AutoSize = true;
            this.ProdNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdNameLabel.Location = new System.Drawing.Point(22, 295);
            this.ProdNameLabel.Name = "ProdNameLabel";
            this.ProdNameLabel.Size = new System.Drawing.Size(51, 20);
            this.ProdNameLabel.TabIndex = 16;
            this.ProdNameLabel.Text = "Name";
            // 
            // ProdInvLabel
            // 
            this.ProdInvLabel.AutoSize = true;
            this.ProdInvLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdInvLabel.Location = new System.Drawing.Point(22, 360);
            this.ProdInvLabel.Name = "ProdInvLabel";
            this.ProdInvLabel.Size = new System.Drawing.Size(74, 20);
            this.ProdInvLabel.TabIndex = 17;
            this.ProdInvLabel.Text = "Inventory";
            // 
            // ProdPriceLabel
            // 
            this.ProdPriceLabel.AutoSize = true;
            this.ProdPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdPriceLabel.Location = new System.Drawing.Point(22, 429);
            this.ProdPriceLabel.Name = "ProdPriceLabel";
            this.ProdPriceLabel.Size = new System.Drawing.Size(44, 20);
            this.ProdPriceLabel.TabIndex = 18;
            this.ProdPriceLabel.Text = "Price";
            // 
            // ProdMaxLabel
            // 
            this.ProdMaxLabel.AutoSize = true;
            this.ProdMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdMaxLabel.Location = new System.Drawing.Point(22, 488);
            this.ProdMaxLabel.Name = "ProdMaxLabel";
            this.ProdMaxLabel.Size = new System.Drawing.Size(38, 20);
            this.ProdMaxLabel.TabIndex = 19;
            this.ProdMaxLabel.Text = "Max";
            // 
            // ProdMinLabel
            // 
            this.ProdMinLabel.AutoSize = true;
            this.ProdMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdMinLabel.Location = new System.Drawing.Point(246, 488);
            this.ProdMinLabel.Name = "ProdMinLabel";
            this.ProdMinLabel.Size = new System.Drawing.Size(34, 20);
            this.ProdMinLabel.TabIndex = 20;
            this.ProdMinLabel.Text = "Min";
            // 
            // AddProdIDTextBox
            // 
            this.AddProdIDTextBox.Enabled = false;
            this.AddProdIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProdIDTextBox.Location = new System.Drawing.Point(126, 226);
            this.AddProdIDTextBox.Name = "AddProdIDTextBox";
            this.AddProdIDTextBox.Size = new System.Drawing.Size(275, 26);
            this.AddProdIDTextBox.TabIndex = 21;
            // 
            // ProdIDLabel
            // 
            this.ProdIDLabel.AutoSize = true;
            this.ProdIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProdIDLabel.Location = new System.Drawing.Point(22, 229);
            this.ProdIDLabel.Name = "ProdIDLabel";
            this.ProdIDLabel.Size = new System.Drawing.Size(26, 20);
            this.ProdIDLabel.TabIndex = 22;
            this.ProdIDLabel.Text = "ID";
            // 
            // modProductSearchButton
            // 
            this.modProductSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modProductSearchButton.Location = new System.Drawing.Point(623, 22);
            this.modProductSearchButton.Name = "modProductSearchButton";
            this.modProductSearchButton.Size = new System.Drawing.Size(80, 30);
            this.modProductSearchButton.TabIndex = 6;
            this.modProductSearchButton.Text = "Search";
            this.modProductSearchButton.UseVisualStyleBackColor = true;
            this.modProductSearchButton.Click += new System.EventHandler(this.ModProductSearchButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1084, 761);
            this.Controls.Add(this.ProdIDLabel);
            this.Controls.Add(this.AddProdPriceTextBox);
            this.Controls.Add(this.AddProdIDTextBox);
            this.Controls.Add(this.AddProductLabel);
            this.Controls.Add(this.ProdMinLabel);
            this.Controls.Add(this.AllPartsDataGrid);
            this.Controls.Add(this.ProdMaxLabel);
            this.Controls.Add(this.AssociatedPartsDGV);
            this.Controls.Add(this.ProdPriceLabel);
            this.Controls.Add(this.CancelProductButton);
            this.Controls.Add(this.ProdInvLabel);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.ProdNameLabel);
            this.Controls.Add(this.modProductSearchButton);
            this.Controls.Add(this.SaveProductButton);
            this.Controls.Add(this.AddPartProdGridLabel);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.PartProdGridLabel);
            this.Controls.Add(this.AddSearchTextBox);
            this.Controls.Add(this.AddProdMinTextBox);
            this.Controls.Add(this.AddProdNameTextBox);
            this.Controls.Add(this.AddProdMaxTextBox);
            this.Controls.Add(this.AddProdInvTextBox);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddProduct";
            ((System.ComponentModel.ISupportInitialize)(this.AllPartsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssociatedPartsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProductLabel;
        private System.Windows.Forms.DataGridView AllPartsDataGrid;
        private System.Windows.Forms.DataGridView AssociatedPartsDGV;
        private System.Windows.Forms.Button CancelProductButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button SaveProductButton;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.TextBox AddSearchTextBox;
        private System.Windows.Forms.TextBox AddProdNameTextBox;
        private System.Windows.Forms.TextBox AddProdInvTextBox;
        private System.Windows.Forms.TextBox AddProdPriceTextBox;
        private System.Windows.Forms.TextBox AddProdMaxTextBox;
        private System.Windows.Forms.TextBox AddProdMinTextBox;
        private System.Windows.Forms.Label PartProdGridLabel;
        private System.Windows.Forms.Label AddPartProdGridLabel;
        private System.Windows.Forms.Label ProdNameLabel;
        private System.Windows.Forms.Label ProdInvLabel;
        private System.Windows.Forms.Label ProdPriceLabel;
        private System.Windows.Forms.Label ProdMaxLabel;
        private System.Windows.Forms.Label ProdMinLabel;
        private System.Windows.Forms.TextBox AddProdIDTextBox;
        private System.Windows.Forms.Label ProdIDLabel;
        private System.Windows.Forms.Button modProductSearchButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}