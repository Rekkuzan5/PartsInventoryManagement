namespace PartsInventoryManagement
{
    partial class AddPart
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
            this.addPriceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addPartInHouseRadio = new System.Windows.Forms.RadioButton();
            this.addPartOutsourceRadio = new System.Windows.Forms.RadioButton();
            this.addPartIDTextBox = new System.Windows.Forms.TextBox();
            this.addPartMinTextBox = new System.Windows.Forms.TextBox();
            this.addPartNameTextBox = new System.Windows.Forms.TextBox();
            this.addPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.addInvTextBox = new System.Windows.Forms.TextBox();
            this.IDNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addPartIDorNameLabel = new System.Windows.Forms.Label();
            this.addPartSavebutton = new System.Windows.Forms.Button();
            this.addPartCancelButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // addPriceTextBox
            // 
            this.addPriceTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.addPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPriceTextBox.Location = new System.Drawing.Point(272, 346);
            this.addPriceTextBox.Name = "addPriceTextBox";
            this.addPriceTextBox.Size = new System.Drawing.Size(194, 26);
            this.addPriceTextBox.TabIndex = 2;
            this.addPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPriceTextBox_KeyPress);
            this.addPriceTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddPriceTextBox_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // addPartInHouseRadio
            // 
            this.addPartInHouseRadio.AutoSize = true;
            this.addPartInHouseRadio.Checked = true;
            this.addPartInHouseRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInHouseRadio.Location = new System.Drawing.Point(206, 17);
            this.addPartInHouseRadio.Name = "addPartInHouseRadio";
            this.addPartInHouseRadio.Size = new System.Drawing.Size(93, 24);
            this.addPartInHouseRadio.TabIndex = 8;
            this.addPartInHouseRadio.TabStop = true;
            this.addPartInHouseRadio.Text = "In-House";
            this.addPartInHouseRadio.UseVisualStyleBackColor = true;
            // 
            // addPartOutsourceRadio
            // 
            this.addPartOutsourceRadio.AutoSize = true;
            this.addPartOutsourceRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartOutsourceRadio.Location = new System.Drawing.Point(356, 17);
            this.addPartOutsourceRadio.Name = "addPartOutsourceRadio";
            this.addPartOutsourceRadio.Size = new System.Drawing.Size(110, 24);
            this.addPartOutsourceRadio.TabIndex = 9;
            this.addPartOutsourceRadio.Text = "Outsourced";
            this.addPartOutsourceRadio.UseVisualStyleBackColor = true;
            this.addPartOutsourceRadio.CheckedChanged += new System.EventHandler(this.AddPartOutsourceRadio_CheckedChanged);
            // 
            // addPartIDTextBox
            // 
            this.addPartIDTextBox.Enabled = false;
            this.addPartIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartIDTextBox.Location = new System.Drawing.Point(272, 103);
            this.addPartIDTextBox.Name = "addPartIDTextBox";
            this.addPartIDTextBox.ReadOnly = true;
            this.addPartIDTextBox.Size = new System.Drawing.Size(194, 26);
            this.addPartIDTextBox.TabIndex = 2;
            // 
            // addPartMinTextBox
            // 
            this.addPartMinTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.addPartMinTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMinTextBox.Location = new System.Drawing.Point(469, 422);
            this.addPartMinTextBox.Name = "addPartMinTextBox";
            this.addPartMinTextBox.Size = new System.Drawing.Size(100, 26);
            this.addPartMinTextBox.TabIndex = 4;
            this.addPartMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartMinTextBox_KeyPress);
            this.addPartMinTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddPartMinTextBox_Validating);
            // 
            // addPartNameTextBox
            // 
            this.addPartNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.addPartNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartNameTextBox.Location = new System.Drawing.Point(272, 189);
            this.addPartNameTextBox.Name = "addPartNameTextBox";
            this.addPartNameTextBox.Size = new System.Drawing.Size(194, 26);
            this.addPartNameTextBox.TabIndex = 0;
            this.addPartNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddPartNameTextBox_Validating);
            // 
            // addPartMaxTextBox
            // 
            this.addPartMaxTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.addPartMaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartMaxTextBox.Location = new System.Drawing.Point(272, 422);
            this.addPartMaxTextBox.Name = "addPartMaxTextBox";
            this.addPartMaxTextBox.Size = new System.Drawing.Size(93, 26);
            this.addPartMaxTextBox.TabIndex = 3;
            this.addPartMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartMaxTextBox_KeyPress);
            this.addPartMaxTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.AddPartMaxTextBox_Validating);
            // 
            // addInvTextBox
            // 
            this.addInvTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.addInvTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addInvTextBox.Location = new System.Drawing.Point(272, 269);
            this.addInvTextBox.Name = "addInvTextBox";
            this.addInvTextBox.Size = new System.Drawing.Size(194, 26);
            this.addInvTextBox.TabIndex = 1;
            this.addInvTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddInvTextBox_KeyPress);
            this.addInvTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.addInvTextBox_Validating);
            // 
            // IDNameTextBox
            // 
            this.IDNameTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.IDNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDNameTextBox.Location = new System.Drawing.Point(272, 493);
            this.IDNameTextBox.Name = "IDNameTextBox";
            this.IDNameTextBox.Size = new System.Drawing.Size(194, 26);
            this.IDNameTextBox.TabIndex = 5;
            this.IDNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.IDNameTextBox_KeyPress);
            this.IDNameTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.IDNameTextBox_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(154, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(139, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Price / Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(190, 422);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(404, 422);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Min";
            // 
            // addPartIDorNameLabel
            // 
            this.addPartIDorNameLabel.AutoSize = true;
            this.addPartIDorNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartIDorNameLabel.Location = new System.Drawing.Point(138, 493);
            this.addPartIDorNameLabel.Name = "addPartIDorNameLabel";
            this.addPartIDorNameLabel.Size = new System.Drawing.Size(90, 20);
            this.addPartIDorNameLabel.TabIndex = 15;
            this.addPartIDorNameLabel.Text = "Machine ID";
            // 
            // addPartSavebutton
            // 
            this.addPartSavebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartSavebutton.Location = new System.Drawing.Point(358, 557);
            this.addPartSavebutton.Name = "addPartSavebutton";
            this.addPartSavebutton.Size = new System.Drawing.Size(80, 30);
            this.addPartSavebutton.TabIndex = 6;
            this.addPartSavebutton.Text = "Save";
            this.addPartSavebutton.UseVisualStyleBackColor = true;
            this.addPartSavebutton.Click += new System.EventHandler(this.AddPartSavebutton_Click);
            // 
            // addPartCancelButton
            // 
            this.addPartCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartCancelButton.Location = new System.Drawing.Point(489, 557);
            this.addPartCancelButton.Name = "addPartCancelButton";
            this.addPartCancelButton.Size = new System.Drawing.Size(80, 30);
            this.addPartCancelButton.TabIndex = 7;
            this.addPartCancelButton.Text = "Cancel";
            this.addPartCancelButton.UseVisualStyleBackColor = true;
            this.addPartCancelButton.Click += new System.EventHandler(this.AddPartCancelButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(634, 609);
            this.Controls.Add(this.addPartCancelButton);
            this.Controls.Add(this.addPriceTextBox);
            this.Controls.Add(this.addPartSavebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addPartIDorNameLabel);
            this.Controls.Add(this.addPartInHouseRadio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.addPartOutsourceRadio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addPartIDTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addPartMinTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.addPartNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addPartMaxTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addInvTextBox);
            this.Controls.Add(this.IDNameTextBox);
            this.MaximumSize = new System.Drawing.Size(650, 648);
            this.MinimumSize = new System.Drawing.Size(650, 648);
            this.Name = "AddPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventory Management System - Add Part";
            this.Load += new System.EventHandler(this.AddPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addPriceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton addPartInHouseRadio;
        private System.Windows.Forms.RadioButton addPartOutsourceRadio;
        private System.Windows.Forms.TextBox addPartIDTextBox;
        private System.Windows.Forms.TextBox addPartMinTextBox;
        private System.Windows.Forms.TextBox addPartNameTextBox;
        private System.Windows.Forms.TextBox addPartMaxTextBox;
        private System.Windows.Forms.TextBox addInvTextBox;
        private System.Windows.Forms.TextBox IDNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label addPartIDorNameLabel;
        private System.Windows.Forms.Button addPartSavebutton;
        private System.Windows.Forms.Button addPartCancelButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}