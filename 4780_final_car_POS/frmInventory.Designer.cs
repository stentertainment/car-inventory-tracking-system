﻿namespace _4780_final_car_POS
{
    partial class frmInventory
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbx_vin = new System.Windows.Forms.TextBox();
            this.tbx_price = new System.Windows.Forms.TextBox();
            this.tbx_year = new System.Windows.Forms.TextBox();
            this.tbx_description = new System.Windows.Forms.TextBox();
            this.cmb_model = new System.Windows.Forms.ComboBox();
            this.bnt_addCar = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.lbl_errors = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(499, 517);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 178);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(707, 275);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Model";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "VIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Description";
            // 
            // tbx_vin
            // 
            this.tbx_vin.Location = new System.Drawing.Point(67, 48);
            this.tbx_vin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_vin.Name = "tbx_vin";
            this.tbx_vin.Size = new System.Drawing.Size(92, 20);
            this.tbx_vin.TabIndex = 8;
            // 
            // tbx_price
            // 
            this.tbx_price.Location = new System.Drawing.Point(67, 72);
            this.tbx_price.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_price.Name = "tbx_price";
            this.tbx_price.Size = new System.Drawing.Size(92, 20);
            this.tbx_price.TabIndex = 9;
            // 
            // tbx_year
            // 
            this.tbx_year.Location = new System.Drawing.Point(67, 97);
            this.tbx_year.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_year.Name = "tbx_year";
            this.tbx_year.Size = new System.Drawing.Size(92, 20);
            this.tbx_year.TabIndex = 10;
            // 
            // tbx_description
            // 
            this.tbx_description.Location = new System.Drawing.Point(67, 122);
            this.tbx_description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbx_description.Multiline = true;
            this.tbx_description.Name = "tbx_description";
            this.tbx_description.Size = new System.Drawing.Size(217, 52);
            this.tbx_description.TabIndex = 11;
            // 
            // cmb_model
            // 
            this.cmb_model.FormattingEnabled = true;
            this.cmb_model.Location = new System.Drawing.Point(67, 24);
            this.cmb_model.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmb_model.Name = "cmb_model";
            this.cmb_model.Size = new System.Drawing.Size(92, 21);
            this.cmb_model.TabIndex = 12;
            // 
            // bnt_addCar
            // 
            this.bnt_addCar.Location = new System.Drawing.Point(299, 24);
            this.bnt_addCar.Name = "bnt_addCar";
            this.bnt_addCar.Size = new System.Drawing.Size(75, 23);
            this.bnt_addCar.TabIndex = 13;
            this.bnt_addCar.Text = "Add";
            this.bnt_addCar.UseVisualStyleBackColor = true;
            this.bnt_addCar.Click += new System.EventHandler(this.bnt_addCar_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(380, 24);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear Values";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // lbl_errors
            // 
            this.lbl_errors.AutoSize = true;
            this.lbl_errors.ForeColor = System.Drawing.Color.Red;
            this.lbl_errors.Location = new System.Drawing.Point(296, 55);
            this.lbl_errors.Name = "lbl_errors";
            this.lbl_errors.Size = new System.Drawing.Size(34, 13);
            this.lbl_errors.TabIndex = 15;
            this.lbl_errors.Text = "Errors";
            this.lbl_errors.Visible = false;
            // 
            // frmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 559);
            this.Controls.Add(this.lbl_errors);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.bnt_addCar);
            this.Controls.Add(this.cmb_model);
            this.Controls.Add(this.tbx_description);
            this.Controls.Add(this.tbx_year);
            this.Controls.Add(this.tbx_price);
            this.Controls.Add(this.tbx_vin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmInventory";
            this.Text = "frmInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbx_vin;
        private System.Windows.Forms.TextBox tbx_price;
        private System.Windows.Forms.TextBox tbx_year;
        private System.Windows.Forms.TextBox tbx_description;
        private System.Windows.Forms.ComboBox cmb_model;
        private System.Windows.Forms.Button bnt_addCar;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label lbl_errors;
    }
}