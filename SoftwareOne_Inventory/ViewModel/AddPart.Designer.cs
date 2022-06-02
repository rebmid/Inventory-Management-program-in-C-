﻿
namespace SoftwareOne_Inventory.ViewModel
{
    partial class AddPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            this.AddPartLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddPartDynamicLbl = new System.Windows.Forms.Label();
            this.AddPartInHousedRadioBtn = new System.Windows.Forms.RadioButton();
            this.AddPartOutsourcedRadioBtn = new System.Windows.Forms.RadioButton();
            this.AddPartIDTextBox = new System.Windows.Forms.TextBox();
            this.AddPartNameTextBox = new System.Windows.Forms.TextBox();
            this.AddPartInventoryTextBox = new System.Windows.Forms.TextBox();
            this.AddPartPriceTextBox = new System.Windows.Forms.TextBox();
            this.AddPartMaxTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddPartMinTextBox = new System.Windows.Forms.TextBox();
            this.AddPartDynamicTextBox = new System.Windows.Forms.TextBox();
            this.AddPartCancelBtn = new System.Windows.Forms.Button();
            this.AddPartSaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPartLbl
            // 
            this.AddPartLbl.AutoSize = true;
            this.AddPartLbl.Location = new System.Drawing.Point(16, 15);
            this.AddPartLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddPartLbl.Name = "AddPartLbl";
            this.AddPartLbl.Size = new System.Drawing.Size(63, 17);
            this.AddPartLbl.TabIndex = 0;
            this.AddPartLbl.Text = "Add Part";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 192);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price / Cost";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Max";
            // 
            // AddPartDynamicLbl
            // 
            this.AddPartDynamicLbl.AutoSize = true;
            this.AddPartDynamicLbl.Location = new System.Drawing.Point(55, 261);
            this.AddPartDynamicLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddPartDynamicLbl.Name = "AddPartDynamicLbl";
            this.AddPartDynamicLbl.Size = new System.Drawing.Size(108, 17);
            this.AddPartDynamicLbl.TabIndex = 6;
            this.AddPartDynamicLbl.Text = "Company Name";
            // 
            // AddPartInHousedRadioBtn
            // 
            this.AddPartInHousedRadioBtn.AutoSize = true;
            this.AddPartInHousedRadioBtn.Location = new System.Drawing.Point(160, 15);
            this.AddPartInHousedRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPartInHousedRadioBtn.Name = "AddPartInHousedRadioBtn";
            this.AddPartInHousedRadioBtn.Size = new System.Drawing.Size(86, 21);
            this.AddPartInHousedRadioBtn.TabIndex = 7;
            this.AddPartInHousedRadioBtn.Text = "In-House";
            this.AddPartInHousedRadioBtn.UseVisualStyleBackColor = true;
            this.AddPartInHousedRadioBtn.CheckedChanged += new System.EventHandler(this.AddPartInHousedBtn_CheckedChanged);
            // 
            // AddPartOutsourcedRadioBtn
            // 
            this.AddPartOutsourcedRadioBtn.AutoSize = true;
            this.AddPartOutsourcedRadioBtn.Checked = true;
            this.AddPartOutsourcedRadioBtn.Location = new System.Drawing.Point(337, 15);
            this.AddPartOutsourcedRadioBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPartOutsourcedRadioBtn.Name = "AddPartOutsourcedRadioBtn";
            this.AddPartOutsourcedRadioBtn.Size = new System.Drawing.Size(103, 21);
            this.AddPartOutsourcedRadioBtn.TabIndex = 8;
            this.AddPartOutsourcedRadioBtn.TabStop = true;
            this.AddPartOutsourcedRadioBtn.Text = "Outsourced";
            this.AddPartOutsourcedRadioBtn.UseVisualStyleBackColor = true;
            this.AddPartOutsourcedRadioBtn.CheckedChanged += new System.EventHandler(this.AddPartOutsourcedBtn_CheckedChanged);
            // 
            // AddPartIDTextBox
            // 
            this.AddPartIDTextBox.Enabled = false;
            this.AddPartIDTextBox.Location = new System.Drawing.Point(172, 66);
            this.AddPartIDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPartIDTextBox.Name = "AddPartIDTextBox";
            this.AddPartIDTextBox.ReadOnly = true;
            this.AddPartIDTextBox.Size = new System.Drawing.Size(271, 22);
            this.AddPartIDTextBox.TabIndex = 9;
            this.AddPartIDTextBox.TextChanged += new System.EventHandler(this.AddPartIDTextBox_TextChanged);
            // 
            // AddPartNameTextBox
            // 
            this.AddPartNameTextBox.Location = new System.Drawing.Point(172, 107);
            this.AddPartNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPartNameTextBox.Name = "AddPartNameTextBox";
            this.AddPartNameTextBox.Size = new System.Drawing.Size(271, 22);
            this.AddPartNameTextBox.TabIndex = 10;
            this.AddPartNameTextBox.TextChanged += new System.EventHandler(this.AddPartNameTextBox_TextChanged);
            // 
            // AddPartInventoryTextBox
            // 
            this.AddPartInventoryTextBox.Location = new System.Drawing.Point(172, 149);
            this.AddPartInventoryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPartInventoryTextBox.Name = "AddPartInventoryTextBox";
            this.AddPartInventoryTextBox.Size = new System.Drawing.Size(271, 22);
            this.AddPartInventoryTextBox.TabIndex = 11;
            this.AddPartInventoryTextBox.TextChanged += new System.EventHandler(this.AddPartInventoryTextBox_TextChanged);
            this.AddPartInventoryTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartInventoryTextBox_KeyPress);
            // 
            // AddPartPriceTextBox
            // 
            this.AddPartPriceTextBox.Location = new System.Drawing.Point(172, 188);
            this.AddPartPriceTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPartPriceTextBox.Name = "AddPartPriceTextBox";
            this.AddPartPriceTextBox.Size = new System.Drawing.Size(271, 22);
            this.AddPartPriceTextBox.TabIndex = 12;
            this.AddPartPriceTextBox.TextChanged += new System.EventHandler(this.AddPartPriceTextBox_TextChanged);
            this.AddPartPriceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartPriceTextBox_KeyPress);
            // 
            // AddPartMaxTextBox
            // 
            this.AddPartMaxTextBox.Location = new System.Drawing.Point(172, 224);
            this.AddPartMaxTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPartMaxTextBox.Name = "AddPartMaxTextBox";
            this.AddPartMaxTextBox.Size = new System.Drawing.Size(132, 22);
            this.AddPartMaxTextBox.TabIndex = 13;
            this.AddPartMaxTextBox.TextChanged += new System.EventHandler(this.AddPartMaxTextBox_TextChanged);
            this.AddPartMaxTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartMaxTextBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(412, 228);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Min";
            // 
            // AddPartMinTextBox
            // 
            this.AddPartMinTextBox.Location = new System.Drawing.Point(452, 224);
            this.AddPartMinTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPartMinTextBox.Name = "AddPartMinTextBox";
            this.AddPartMinTextBox.Size = new System.Drawing.Size(132, 22);
            this.AddPartMinTextBox.TabIndex = 15;
            this.AddPartMinTextBox.TextChanged += new System.EventHandler(this.AddPartMinTextBox_TextChanged);
            this.AddPartMinTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartMinTextBox_KeyPress);
            // 
            // AddPartDynamicTextBox
            // 
            this.AddPartDynamicTextBox.Location = new System.Drawing.Point(172, 261);
            this.AddPartDynamicTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPartDynamicTextBox.Name = "AddPartDynamicTextBox";
            this.AddPartDynamicTextBox.Size = new System.Drawing.Size(271, 22);
            this.AddPartDynamicTextBox.TabIndex = 16;
            this.AddPartDynamicTextBox.TextChanged += new System.EventHandler(this.AddPartDynamicTextBox_TextChanged);
            this.AddPartDynamicTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPartDynamicTextBox_KeyPress);
            // 
            // AddPartCancelBtn
            // 
            this.AddPartCancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartCancelBtn.Location = new System.Drawing.Point(499, 309);
            this.AddPartCancelBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPartCancelBtn.Name = "AddPartCancelBtn";
            this.AddPartCancelBtn.Size = new System.Drawing.Size(87, 39);
            this.AddPartCancelBtn.TabIndex = 17;
            this.AddPartCancelBtn.Text = "Cancel";
            this.AddPartCancelBtn.UseVisualStyleBackColor = true;
            this.AddPartCancelBtn.Click += new System.EventHandler(this.AddPartCancelBtn_Click);
            // 
            // AddPartSaveBtn
            // 
            this.AddPartSaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPartSaveBtn.Location = new System.Drawing.Point(416, 309);
            this.AddPartSaveBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddPartSaveBtn.Name = "AddPartSaveBtn";
            this.AddPartSaveBtn.Size = new System.Drawing.Size(75, 39);
            this.AddPartSaveBtn.TabIndex = 18;
            this.AddPartSaveBtn.Text = "Save";
            this.AddPartSaveBtn.UseVisualStyleBackColor = true;
            this.AddPartSaveBtn.Click += new System.EventHandler(this.AddPartSaveBtn_Click);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 476);
            this.Controls.Add(this.AddPartSaveBtn);
            this.Controls.Add(this.AddPartCancelBtn);
            this.Controls.Add(this.AddPartDynamicTextBox);
            this.Controls.Add(this.AddPartMinTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AddPartMaxTextBox);
            this.Controls.Add(this.AddPartPriceTextBox);
            this.Controls.Add(this.AddPartInventoryTextBox);
            this.Controls.Add(this.AddPartNameTextBox);
            this.Controls.Add(this.AddPartIDTextBox);
            this.Controls.Add(this.AddPartOutsourcedRadioBtn);
            this.Controls.Add(this.AddPartInHousedRadioBtn);
            this.Controls.Add(this.AddPartDynamicLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddPartLbl);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddPart";
            this.Text = "AddPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddPartLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AddPartDynamicLbl;
        private System.Windows.Forms.RadioButton AddPartInHousedRadioBtn;
        private System.Windows.Forms.RadioButton AddPartOutsourcedRadioBtn;
        private System.Windows.Forms.TextBox AddPartIDTextBox;
        private System.Windows.Forms.TextBox AddPartNameTextBox;
        private System.Windows.Forms.TextBox AddPartInventoryTextBox;
        private System.Windows.Forms.TextBox AddPartPriceTextBox;
        private System.Windows.Forms.TextBox AddPartMaxTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddPartMinTextBox;
        private System.Windows.Forms.TextBox AddPartDynamicTextBox;
        private System.Windows.Forms.Button AddPartCancelBtn;
        private System.Windows.Forms.Button AddPartSaveBtn;
    }
}