﻿namespace VMA
{
    partial class UserControl_my_rents
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_rent = new System.Windows.Forms.Label();
            this.dataGridView_my_rents = new System.Windows.Forms.DataGridView();
            this.panel_end_rent = new System.Windows.Forms.Panel();
            this.panel_all_cost = new System.Windows.Forms.Panel();
            this.textBox_all_cost = new System.Windows.Forms.TextBox();
            this.label_all_cost = new System.Windows.Forms.Label();
            this.panel_litres = new System.Windows.Forms.Panel();
            this.textBox_litres = new System.Windows.Forms.TextBox();
            this.label_litres = new System.Windows.Forms.Label();
            this.comboBox_type_cost = new System.Windows.Forms.ComboBox();
            this.label_other = new System.Windows.Forms.Label();
            this.panel_other = new System.Windows.Forms.Panel();
            this.textBox_other = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_confirm_end_rent = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.textBox_mileage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_to = new System.Windows.Forms.Label();
            this.label_from = new System.Windows.Forms.Label();
            this.label_purpose = new System.Windows.Forms.Label();
            this.label_model = new System.Windows.Forms.Label();
            this.label_brand = new System.Windows.Forms.Label();
            this.label_desc_to = new System.Windows.Forms.Label();
            this.label_desc_mileage = new System.Windows.Forms.Label();
            this.label_desc_from = new System.Windows.Forms.Label();
            this.label_desc_model = new System.Windows.Forms.Label();
            this.label_desc_brand = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_my_rents)).BeginInit();
            this.panel_end_rent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_rent
            // 
            this.label_rent.AutoSize = true;
            this.label_rent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_rent.ForeColor = System.Drawing.Color.Yellow;
            this.label_rent.Location = new System.Drawing.Point(32, 49);
            this.label_rent.Margin = new System.Windows.Forms.Padding(0);
            this.label_rent.Name = "label_rent";
            this.label_rent.Size = new System.Drawing.Size(277, 29);
            this.label_rent.TabIndex = 47;
            this.label_rent.Text = "MOJE WYPOŻYCZENIA";
            // 
            // dataGridView_my_rents
            // 
            this.dataGridView_my_rents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_my_rents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_my_rents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_my_rents.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_my_rents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_my_rents.Location = new System.Drawing.Point(37, 112);
            this.dataGridView_my_rents.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_my_rents.Name = "dataGridView_my_rents";
            this.dataGridView_my_rents.RowTemplate.Height = 24;
            this.dataGridView_my_rents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_my_rents.Size = new System.Drawing.Size(653, 167);
            this.dataGridView_my_rents.TabIndex = 48;
            this.dataGridView_my_rents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_my_rents_CellClick);
            // 
            // panel_end_rent
            // 
            this.panel_end_rent.Controls.Add(this.panel_all_cost);
            this.panel_end_rent.Controls.Add(this.textBox_all_cost);
            this.panel_end_rent.Controls.Add(this.label_all_cost);
            this.panel_end_rent.Controls.Add(this.panel_litres);
            this.panel_end_rent.Controls.Add(this.textBox_litres);
            this.panel_end_rent.Controls.Add(this.label_litres);
            this.panel_end_rent.Controls.Add(this.comboBox_type_cost);
            this.panel_end_rent.Controls.Add(this.label_other);
            this.panel_end_rent.Controls.Add(this.panel_other);
            this.panel_end_rent.Controls.Add(this.textBox_other);
            this.panel_end_rent.Controls.Add(this.label2);
            this.panel_end_rent.Controls.Add(this.button_confirm_end_rent);
            this.panel_end_rent.Controls.Add(this.panel10);
            this.panel_end_rent.Controls.Add(this.textBox_mileage);
            this.panel_end_rent.Controls.Add(this.label1);
            this.panel_end_rent.Controls.Add(this.label_to);
            this.panel_end_rent.Controls.Add(this.label_from);
            this.panel_end_rent.Controls.Add(this.label_purpose);
            this.panel_end_rent.Controls.Add(this.label_model);
            this.panel_end_rent.Controls.Add(this.label_brand);
            this.panel_end_rent.Controls.Add(this.label_desc_to);
            this.panel_end_rent.Controls.Add(this.label_desc_mileage);
            this.panel_end_rent.Controls.Add(this.label_desc_from);
            this.panel_end_rent.Controls.Add(this.label_desc_model);
            this.panel_end_rent.Controls.Add(this.label_desc_brand);
            this.panel_end_rent.Location = new System.Drawing.Point(37, 316);
            this.panel_end_rent.Name = "panel_end_rent";
            this.panel_end_rent.Size = new System.Drawing.Size(904, 337);
            this.panel_end_rent.TabIndex = 58;
            // 
            // panel_all_cost
            // 
            this.panel_all_cost.BackColor = System.Drawing.Color.Yellow;
            this.panel_all_cost.Location = new System.Drawing.Point(213, 295);
            this.panel_all_cost.Margin = new System.Windows.Forms.Padding(4);
            this.panel_all_cost.Name = "panel_all_cost";
            this.panel_all_cost.Size = new System.Drawing.Size(173, 1);
            this.panel_all_cost.TabIndex = 97;
            // 
            // textBox_all_cost
            // 
            this.textBox_all_cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_all_cost.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_all_cost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_all_cost.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_all_cost.Location = new System.Drawing.Point(213, 275);
            this.textBox_all_cost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_all_cost.MaximumSize = new System.Drawing.Size(200, 25);
            this.textBox_all_cost.MinimumSize = new System.Drawing.Size(5, 18);
            this.textBox_all_cost.Name = "textBox_all_cost";
            this.textBox_all_cost.Size = new System.Drawing.Size(173, 19);
            this.textBox_all_cost.TabIndex = 96;
            this.textBox_all_cost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_all_cost
            // 
            this.label_all_cost.AutoSize = true;
            this.label_all_cost.Font = new System.Drawing.Font("Arial", 12F);
            this.label_all_cost.ForeColor = System.Drawing.Color.Yellow;
            this.label_all_cost.Location = new System.Drawing.Point(47, 273);
            this.label_all_cost.Margin = new System.Windows.Forms.Padding(0);
            this.label_all_cost.Name = "label_all_cost";
            this.label_all_cost.Size = new System.Drawing.Size(161, 23);
            this.label_all_cost.TabIndex = 95;
            this.label_all_cost.Text = "Suma wydatków:";
            // 
            // panel_litres
            // 
            this.panel_litres.BackColor = System.Drawing.Color.Yellow;
            this.panel_litres.Location = new System.Drawing.Point(420, 251);
            this.panel_litres.Margin = new System.Windows.Forms.Padding(4);
            this.panel_litres.Name = "panel_litres";
            this.panel_litres.Size = new System.Drawing.Size(173, 1);
            this.panel_litres.TabIndex = 94;
            // 
            // textBox_litres
            // 
            this.textBox_litres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_litres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_litres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_litres.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_litres.Location = new System.Drawing.Point(420, 231);
            this.textBox_litres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_litres.MaximumSize = new System.Drawing.Size(200, 25);
            this.textBox_litres.MinimumSize = new System.Drawing.Size(5, 18);
            this.textBox_litres.Name = "textBox_litres";
            this.textBox_litres.Size = new System.Drawing.Size(173, 19);
            this.textBox_litres.TabIndex = 93;
            this.textBox_litres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_litres
            // 
            this.label_litres.AutoSize = true;
            this.label_litres.Font = new System.Drawing.Font("Arial", 12F);
            this.label_litres.ForeColor = System.Drawing.Color.Yellow;
            this.label_litres.Location = new System.Drawing.Point(307, 228);
            this.label_litres.Margin = new System.Windows.Forms.Padding(0);
            this.label_litres.Name = "label_litres";
            this.label_litres.Size = new System.Drawing.Size(110, 23);
            this.label_litres.TabIndex = 92;
            this.label_litres.Text = "Ilość litrów:";
            // 
            // comboBox_type_cost
            // 
            this.comboBox_type_cost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox_type_cost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_type_cost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_type_cost.ForeColor = System.Drawing.Color.Yellow;
            this.comboBox_type_cost.Items.AddRange(new object[] {
            "Tankowanie",
            "Inne\t",
            "Tankowanie oraz inne"});
            this.comboBox_type_cost.Location = new System.Drawing.Point(231, 192);
            this.comboBox_type_cost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_type_cost.Name = "comboBox_type_cost";
            this.comboBox_type_cost.Size = new System.Drawing.Size(173, 24);
            this.comboBox_type_cost.TabIndex = 91;
            this.comboBox_type_cost.SelectedIndexChanged += new System.EventHandler(this.comboBox_type_cost_SelectedIndexChanged);
            // 
            // label_other
            // 
            this.label_other.AutoSize = true;
            this.label_other.Font = new System.Drawing.Font("Arial", 12F);
            this.label_other.ForeColor = System.Drawing.Color.Yellow;
            this.label_other.Location = new System.Drawing.Point(47, 228);
            this.label_other.Margin = new System.Windows.Forms.Padding(0);
            this.label_other.Name = "label_other";
            this.label_other.Size = new System.Drawing.Size(53, 23);
            this.label_other.TabIndex = 85;
            this.label_other.Text = "Inne:";
            // 
            // panel_other
            // 
            this.panel_other.BackColor = System.Drawing.Color.Yellow;
            this.panel_other.Location = new System.Drawing.Point(103, 252);
            this.panel_other.Margin = new System.Windows.Forms.Padding(4);
            this.panel_other.Name = "panel_other";
            this.panel_other.Size = new System.Drawing.Size(173, 1);
            this.panel_other.TabIndex = 84;
            // 
            // textBox_other
            // 
            this.textBox_other.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_other.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_other.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_other.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_other.Location = new System.Drawing.Point(103, 232);
            this.textBox_other.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_other.MaximumSize = new System.Drawing.Size(200, 25);
            this.textBox_other.MinimumSize = new System.Drawing.Size(5, 18);
            this.textBox_other.Name = "textBox_other";
            this.textBox_other.Size = new System.Drawing.Size(173, 19);
            this.textBox_other.TabIndex = 83;
            this.textBox_other.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(47, 189);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 23);
            this.label2.TabIndex = 82;
            this.label2.Text = "Rodzaj wydatków:";
            // 
            // button_confirm_end_rent
            // 
            this.button_confirm_end_rent.BackColor = System.Drawing.Color.Yellow;
            this.button_confirm_end_rent.FlatAppearance.BorderSize = 0;
            this.button_confirm_end_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_confirm_end_rent.Font = new System.Drawing.Font("Arial", 9.75F);
            this.button_confirm_end_rent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_confirm_end_rent.Location = new System.Drawing.Point(697, 258);
            this.button_confirm_end_rent.Name = "button_confirm_end_rent";
            this.button_confirm_end_rent.Size = new System.Drawing.Size(207, 57);
            this.button_confirm_end_rent.TabIndex = 81;
            this.button_confirm_end_rent.Text = "Potwierdź zakończenie wypożyczenia";
            this.button_confirm_end_rent.UseVisualStyleBackColor = false;
            this.button_confirm_end_rent.Click += new System.EventHandler(this.button_confirm_end_rent_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Yellow;
            this.panel10.Location = new System.Drawing.Point(315, 173);
            this.panel10.Margin = new System.Windows.Forms.Padding(4);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(173, 1);
            this.panel10.TabIndex = 80;
            // 
            // textBox_mileage
            // 
            this.textBox_mileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_mileage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_mileage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_mileage.ForeColor = System.Drawing.Color.Yellow;
            this.textBox_mileage.Location = new System.Drawing.Point(315, 153);
            this.textBox_mileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_mileage.MaximumSize = new System.Drawing.Size(200, 25);
            this.textBox_mileage.MinimumSize = new System.Drawing.Size(5, 18);
            this.textBox_mileage.Name = "textBox_mileage";
            this.textBox_mileage.Size = new System.Drawing.Size(173, 19);
            this.textBox_mileage.TabIndex = 79;
            this.textBox_mileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(47, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 23);
            this.label1.TabIndex = 78;
            this.label1.Text = "Przebieg po wypożyczeniu:";
            // 
            // label_to
            // 
            this.label_to.AutoSize = true;
            this.label_to.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_to.ForeColor = System.Drawing.Color.Yellow;
            this.label_to.Location = new System.Drawing.Point(404, 63);
            this.label_to.Margin = new System.Windows.Forms.Padding(0);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(0, 24);
            this.label_to.TabIndex = 77;
            // 
            // label_from
            // 
            this.label_from.AutoSize = true;
            this.label_from.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_from.ForeColor = System.Drawing.Color.Yellow;
            this.label_from.Location = new System.Drawing.Point(402, 17);
            this.label_from.Margin = new System.Windows.Forms.Padding(0);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(0, 24);
            this.label_from.TabIndex = 76;
            // 
            // label_purpose
            // 
            this.label_purpose.AutoSize = true;
            this.label_purpose.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_purpose.ForeColor = System.Drawing.Color.Yellow;
            this.label_purpose.Location = new System.Drawing.Point(375, 111);
            this.label_purpose.Margin = new System.Windows.Forms.Padding(0);
            this.label_purpose.Name = "label_purpose";
            this.label_purpose.Size = new System.Drawing.Size(0, 24);
            this.label_purpose.TabIndex = 75;
            // 
            // label_model
            // 
            this.label_model.AutoSize = true;
            this.label_model.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_model.Location = new System.Drawing.Point(119, 64);
            this.label_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_model.Name = "label_model";
            this.label_model.Size = new System.Drawing.Size(0, 24);
            this.label_model.TabIndex = 74;
            // 
            // label_brand
            // 
            this.label_brand.AutoSize = true;
            this.label_brand.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_brand.Location = new System.Drawing.Point(119, 18);
            this.label_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_brand.Name = "label_brand";
            this.label_brand.Size = new System.Drawing.Size(0, 24);
            this.label_brand.TabIndex = 73;
            // 
            // label_desc_to
            // 
            this.label_desc_to.AutoSize = true;
            this.label_desc_to.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_to.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_to.Location = new System.Drawing.Point(309, 64);
            this.label_desc_to.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_to.Name = "label_desc_to";
            this.label_desc_to.Size = new System.Drawing.Size(93, 23);
            this.label_desc_to.TabIndex = 72;
            this.label_desc_to.Text = "Do kiedy:";
            // 
            // label_desc_mileage
            // 
            this.label_desc_mileage.AutoSize = true;
            this.label_desc_mileage.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_mileage.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_mileage.Location = new System.Drawing.Point(47, 111);
            this.label_desc_mileage.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_mileage.Name = "label_desc_mileage";
            this.label_desc_mileage.Size = new System.Drawing.Size(291, 23);
            this.label_desc_mileage.TabIndex = 71;
            this.label_desc_mileage.Text = "Przebieg przed wypożyczeniem:";
            // 
            // label_desc_from
            // 
            this.label_desc_from.AutoSize = true;
            this.label_desc_from.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_from.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_from.Location = new System.Drawing.Point(307, 18);
            this.label_desc_from.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_from.Name = "label_desc_from";
            this.label_desc_from.Size = new System.Drawing.Size(95, 23);
            this.label_desc_from.TabIndex = 70;
            this.label_desc_from.Text = "Od kiedy:";
            // 
            // label_desc_model
            // 
            this.label_desc_model.AutoSize = true;
            this.label_desc_model.Font = new System.Drawing.Font("Arial", 12F);
            this.label_desc_model.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_model.Location = new System.Drawing.Point(47, 64);
            this.label_desc_model.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_model.Name = "label_desc_model";
            this.label_desc_model.Size = new System.Drawing.Size(70, 23);
            this.label_desc_model.TabIndex = 69;
            this.label_desc_model.Text = "Model:";
            // 
            // label_desc_brand
            // 
            this.label_desc_brand.AutoSize = true;
            this.label_desc_brand.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_desc_brand.ForeColor = System.Drawing.Color.Yellow;
            this.label_desc_brand.Location = new System.Drawing.Point(47, 18);
            this.label_desc_brand.Margin = new System.Windows.Forms.Padding(0);
            this.label_desc_brand.Name = "label_desc_brand";
            this.label_desc_brand.Size = new System.Drawing.Size(72, 23);
            this.label_desc_brand.TabIndex = 68;
            this.label_desc_brand.Text = "Marka:";
            // 
            // UserControl_my_rents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.panel_end_rent);
            this.Controls.Add(this.dataGridView_my_rents);
            this.Controls.Add(this.label_rent);
            this.Name = "UserControl_my_rents";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_my_rents)).EndInit();
            this.panel_end_rent.ResumeLayout(false);
            this.panel_end_rent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_rent;
        private System.Windows.Forms.DataGridView dataGridView_my_rents;
        private System.Windows.Forms.Panel panel_end_rent;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Label label_purpose;
        private System.Windows.Forms.Label label_model;
        private System.Windows.Forms.Label label_brand;
        private System.Windows.Forms.Label label_desc_to;
        private System.Windows.Forms.Label label_desc_mileage;
        private System.Windows.Forms.Label label_desc_from;
        private System.Windows.Forms.Label label_desc_model;
        private System.Windows.Forms.Label label_desc_brand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_confirm_end_rent;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox textBox_mileage;
        private System.Windows.Forms.Label label_other;
        private System.Windows.Forms.Panel panel_other;
        private System.Windows.Forms.TextBox textBox_other;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_all_cost;
        private System.Windows.Forms.TextBox textBox_all_cost;
        private System.Windows.Forms.Label label_all_cost;
        private System.Windows.Forms.Panel panel_litres;
        private System.Windows.Forms.TextBox textBox_litres;
        private System.Windows.Forms.Label label_litres;
        private System.Windows.Forms.ComboBox comboBox_type_cost;
    }
}
