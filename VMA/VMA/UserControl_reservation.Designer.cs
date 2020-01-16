﻿namespace VMA
{
    partial class UserControl_reservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl_reservation));
            this.textBox_mileage = new System.Windows.Forms.TextBox();
            this.textBox_version = new System.Windows.Forms.TextBox();
            this.textBox_equipment = new System.Windows.Forms.TextBox();
            this.textBox_model = new System.Windows.Forms.TextBox();
            this.textBox_brand = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_veh_DB = new System.Windows.Forms.DataGridView();
            this.label_reservation = new System.Windows.Forms.Label();
            this.dateTimePicker_from_date_reserv = new System.Windows.Forms.DateTimePicker();
            this.label_from_date = new System.Windows.Forms.Label();
            this.label_to_date_reserv = new System.Windows.Forms.Label();
            this.dateTimePicker_to_date_reserv = new System.Windows.Forms.DateTimePicker();
            this.button_reserv = new System.Windows.Forms.Button();
            this.button_check_available_cars = new System.Windows.Forms.Button();
            this.comboBox_purpose_of_reservation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox_help = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_veh_DB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_mileage
            // 
            this.textBox_mileage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox_mileage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_mileage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_mileage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_mileage.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_mileage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.textBox_mileage.Location = new System.Drawing.Point(531, 23);
            this.textBox_mileage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_mileage.MaximumSize = new System.Drawing.Size(133, 25);
            this.textBox_mileage.MinimumSize = new System.Drawing.Size(5, 15);
            this.textBox_mileage.Name = "textBox_mileage";
            this.textBox_mileage.Size = new System.Drawing.Size(120, 19);
            this.textBox_mileage.TabIndex = 11;
            this.textBox_mileage.Text = "Typ paliwa";
            this.textBox_mileage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_mileage.Enter += new System.EventHandler(this.textBox_mileage_Enter);
            this.textBox_mileage.Leave += new System.EventHandler(this.textBox_mileage_Leave);
            // 
            // textBox_version
            // 
            this.textBox_version.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_version.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_version.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_version.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.textBox_version.Location = new System.Drawing.Point(404, 23);
            this.textBox_version.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_version.MaximumSize = new System.Drawing.Size(133, 25);
            this.textBox_version.MinimumSize = new System.Drawing.Size(5, 15);
            this.textBox_version.Name = "textBox_version";
            this.textBox_version.Size = new System.Drawing.Size(120, 19);
            this.textBox_version.TabIndex = 10;
            this.textBox_version.Text = "Wersja";
            this.textBox_version.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_version.Enter += new System.EventHandler(this.textBox_version_Enter);
            this.textBox_version.Leave += new System.EventHandler(this.textBox_version_Leave);
            // 
            // textBox_equipment
            // 
            this.textBox_equipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_equipment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_equipment.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_equipment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.textBox_equipment.Location = new System.Drawing.Point(277, 23);
            this.textBox_equipment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_equipment.MaximumSize = new System.Drawing.Size(133, 25);
            this.textBox_equipment.MinimumSize = new System.Drawing.Size(5, 15);
            this.textBox_equipment.Name = "textBox_equipment";
            this.textBox_equipment.Size = new System.Drawing.Size(120, 19);
            this.textBox_equipment.TabIndex = 9;
            this.textBox_equipment.Text = "Spalanie";
            this.textBox_equipment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_equipment.Enter += new System.EventHandler(this.textBox_equipment_Enter);
            this.textBox_equipment.Leave += new System.EventHandler(this.textBox_equipment_Leave);
            // 
            // textBox_model
            // 
            this.textBox_model.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox_model.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_model.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_model.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_model.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_model.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.textBox_model.Location = new System.Drawing.Point(151, 23);
            this.textBox_model.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_model.MaximumSize = new System.Drawing.Size(133, 25);
            this.textBox_model.MinimumSize = new System.Drawing.Size(5, 15);
            this.textBox_model.Name = "textBox_model";
            this.textBox_model.Size = new System.Drawing.Size(120, 19);
            this.textBox_model.TabIndex = 8;
            this.textBox_model.Text = "Model";
            this.textBox_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_model.Enter += new System.EventHandler(this.textBox_model_Enter);
            this.textBox_model.Leave += new System.EventHandler(this.textBox_model_Leave);
            // 
            // textBox_brand
            // 
            this.textBox_brand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox_brand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_brand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBox_brand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_brand.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_brand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(0)))));
            this.textBox_brand.Location = new System.Drawing.Point(24, 23);
            this.textBox_brand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_brand.MaximumSize = new System.Drawing.Size(133, 25);
            this.textBox_brand.MinimumSize = new System.Drawing.Size(5, 15);
            this.textBox_brand.Name = "textBox_brand";
            this.textBox_brand.Size = new System.Drawing.Size(120, 19);
            this.textBox_brand.TabIndex = 7;
            this.textBox_brand.Text = "Marka";
            this.textBox_brand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_brand.Enter += new System.EventHandler(this.textBox_brand_Enter);
            this.textBox_brand.Leave += new System.EventHandler(this.textBox_brand_Leave);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Yellow;
            this.panel6.Location = new System.Drawing.Point(531, 47);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(120, 1);
            this.panel6.TabIndex = 15;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Yellow;
            this.panel5.Location = new System.Drawing.Point(404, 47);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(120, 1);
            this.panel5.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Yellow;
            this.panel4.Location = new System.Drawing.Point(277, 47);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(120, 1);
            this.panel4.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(151, 47);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 1);
            this.panel2.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.Location = new System.Drawing.Point(24, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 1);
            this.panel1.TabIndex = 14;
            // 
            // dataGridView_veh_DB
            // 
            this.dataGridView_veh_DB.AllowUserToAddRows = false;
            this.dataGridView_veh_DB.AllowUserToDeleteRows = false;
            this.dataGridView_veh_DB.AllowUserToResizeColumns = false;
            this.dataGridView_veh_DB.AllowUserToResizeRows = false;
            this.dataGridView_veh_DB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView_veh_DB.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_veh_DB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_veh_DB.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView_veh_DB.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_veh_DB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_veh_DB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_veh_DB.Cursor = System.Windows.Forms.Cursors.Arrow;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_veh_DB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_veh_DB.EnableHeadersVisualStyles = false;
            this.dataGridView_veh_DB.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_veh_DB.Location = new System.Drawing.Point(33, 135);
            this.dataGridView_veh_DB.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_veh_DB.MultiSelect = false;
            this.dataGridView_veh_DB.Name = "dataGridView_veh_DB";
            this.dataGridView_veh_DB.ReadOnly = true;
            this.dataGridView_veh_DB.RowHeadersVisible = false;
            this.dataGridView_veh_DB.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_veh_DB.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_veh_DB.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView_veh_DB.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Yellow;
            this.dataGridView_veh_DB.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Yellow;
            this.dataGridView_veh_DB.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_veh_DB.RowTemplate.Height = 24;
            this.dataGridView_veh_DB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_veh_DB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_veh_DB.Size = new System.Drawing.Size(888, 246);
            this.dataGridView_veh_DB.TabIndex = 20;
            // 
            // label_reservation
            // 
            this.label_reservation.AutoSize = true;
            this.label_reservation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_reservation.ForeColor = System.Drawing.Color.Yellow;
            this.label_reservation.Location = new System.Drawing.Point(33, 406);
            this.label_reservation.Margin = new System.Windows.Forms.Padding(0);
            this.label_reservation.Name = "label_reservation";
            this.label_reservation.Size = new System.Drawing.Size(297, 29);
            this.label_reservation.TabIndex = 21;
            this.label_reservation.Text = "REZERWACJA POJAZDU";
            // 
            // dateTimePicker_from_date_reserv
            // 
            this.dateTimePicker_from_date_reserv.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_from_date_reserv.CalendarForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker_from_date_reserv.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_from_date_reserv.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_from_date_reserv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_from_date_reserv.Location = new System.Drawing.Point(73, 71);
            this.dateTimePicker_from_date_reserv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_from_date_reserv.MinDate = new System.DateTime(2019, 12, 9, 0, 0, 0, 0);
            this.dateTimePicker_from_date_reserv.Name = "dateTimePicker_from_date_reserv";
            this.dateTimePicker_from_date_reserv.Size = new System.Drawing.Size(299, 26);
            this.dateTimePicker_from_date_reserv.TabIndex = 26;
            this.dateTimePicker_from_date_reserv.ValueChanged += new System.EventHandler(this.dateTimePicker_from_date_reserv_ValueChanged);
            this.dateTimePicker_from_date_reserv.Leave += new System.EventHandler(this.dateTimePicker_from_date_reserv_Leave);
            // 
            // label_from_date
            // 
            this.label_from_date.AutoSize = true;
            this.label_from_date.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_from_date.ForeColor = System.Drawing.Color.Yellow;
            this.label_from_date.Location = new System.Drawing.Point(33, 74);
            this.label_from_date.Margin = new System.Windows.Forms.Padding(0);
            this.label_from_date.Name = "label_from_date";
            this.label_from_date.Size = new System.Drawing.Size(37, 23);
            this.label_from_date.TabIndex = 28;
            this.label_from_date.Text = "Od";
            // 
            // label_to_date_reserv
            // 
            this.label_to_date_reserv.AutoSize = true;
            this.label_to_date_reserv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_to_date_reserv.ForeColor = System.Drawing.Color.Yellow;
            this.label_to_date_reserv.Location = new System.Drawing.Point(380, 74);
            this.label_to_date_reserv.Margin = new System.Windows.Forms.Padding(0);
            this.label_to_date_reserv.Name = "label_to_date_reserv";
            this.label_to_date_reserv.Size = new System.Drawing.Size(35, 23);
            this.label_to_date_reserv.TabIndex = 30;
            this.label_to_date_reserv.Text = "Do";
            // 
            // dateTimePicker_to_date_reserv
            // 
            this.dateTimePicker_to_date_reserv.CalendarFont = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_to_date_reserv.CalendarForeColor = System.Drawing.Color.Yellow;
            this.dateTimePicker_to_date_reserv.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dateTimePicker_to_date_reserv.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_to_date_reserv.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_to_date_reserv.Location = new System.Drawing.Point(420, 71);
            this.dateTimePicker_to_date_reserv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker_to_date_reserv.MinDate = new System.DateTime(2019, 12, 9, 0, 0, 0, 0);
            this.dateTimePicker_to_date_reserv.Name = "dateTimePicker_to_date_reserv";
            this.dateTimePicker_to_date_reserv.Size = new System.Drawing.Size(299, 26);
            this.dateTimePicker_to_date_reserv.TabIndex = 29;
            this.dateTimePicker_to_date_reserv.Leave += new System.EventHandler(this.dateTimePicker_to_date_reserv_Leave);
            // 
            // button_reserv
            // 
            this.button_reserv.BackColor = System.Drawing.Color.Yellow;
            this.button_reserv.FlatAppearance.BorderSize = 0;
            this.button_reserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reserv.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_reserv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_reserv.Location = new System.Drawing.Point(377, 566);
            this.button_reserv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_reserv.Name = "button_reserv";
            this.button_reserv.Size = new System.Drawing.Size(187, 42);
            this.button_reserv.TabIndex = 31;
            this.button_reserv.Text = "Rezerwuj";
            this.button_reserv.UseVisualStyleBackColor = false;
            this.button_reserv.Visible = false;
            this.button_reserv.Click += new System.EventHandler(this.button_reserv_Click);
            // 
            // button_check_available_cars
            // 
            this.button_check_available_cars.BackColor = System.Drawing.Color.Yellow;
            this.button_check_available_cars.FlatAppearance.BorderSize = 0;
            this.button_check_available_cars.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_check_available_cars.Font = new System.Drawing.Font("Arial", 12F);
            this.button_check_available_cars.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_check_available_cars.Location = new System.Drawing.Point(733, 64);
            this.button_check_available_cars.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_check_available_cars.Name = "button_check_available_cars";
            this.button_check_available_cars.Size = new System.Drawing.Size(187, 42);
            this.button_check_available_cars.TabIndex = 32;
            this.button_check_available_cars.Text = "Sprawdź";
            this.button_check_available_cars.UseVisualStyleBackColor = false;
            this.button_check_available_cars.Click += new System.EventHandler(this.button_check_available_cars_Click);
            // 
            // comboBox_purpose_of_reservation
            // 
            this.comboBox_purpose_of_reservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.comboBox_purpose_of_reservation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_purpose_of_reservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_purpose_of_reservation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox_purpose_of_reservation.ForeColor = System.Drawing.Color.Yellow;
            this.comboBox_purpose_of_reservation.Items.AddRange(new object[] {
            "Delegacja",
            "Służbowy",
            "Prywatny"});
            this.comboBox_purpose_of_reservation.Location = new System.Drawing.Point(377, 494);
            this.comboBox_purpose_of_reservation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_purpose_of_reservation.Name = "comboBox_purpose_of_reservation";
            this.comboBox_purpose_of_reservation.Size = new System.Drawing.Size(185, 31);
            this.comboBox_purpose_of_reservation.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.label2.Location = new System.Drawing.Point(193, 497);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "Cel rezerwacji";
            // 
            // pictureBox_help
            // 
            this.pictureBox_help.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_help.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_help.Image")));
            this.pictureBox_help.Location = new System.Drawing.Point(895, 23);
            this.pictureBox_help.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox_help.Name = "pictureBox_help";
            this.pictureBox_help.Size = new System.Drawing.Size(25, 23);
            this.pictureBox_help.TabIndex = 36;
            this.pictureBox_help.TabStop = false;
            this.pictureBox_help.Click += new System.EventHandler(this.pictureBox_help_Click);
            // 
            // UserControl_reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.pictureBox_help);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_purpose_of_reservation);
            this.Controls.Add(this.button_check_available_cars);
            this.Controls.Add(this.button_reserv);
            this.Controls.Add(this.label_to_date_reserv);
            this.Controls.Add(this.dateTimePicker_to_date_reserv);
            this.Controls.Add(this.label_from_date);
            this.Controls.Add(this.dateTimePicker_from_date_reserv);
            this.Controls.Add(this.label_reservation);
            this.Controls.Add(this.dataGridView_veh_DB);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_mileage);
            this.Controls.Add(this.textBox_version);
            this.Controls.Add(this.textBox_equipment);
            this.Controls.Add(this.textBox_model);
            this.Controls.Add(this.textBox_brand);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UserControl_reservation";
            this.Size = new System.Drawing.Size(941, 656);
            this.Load += new System.EventHandler(this.UserControl_reservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_veh_DB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_help)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_mileage;
        private System.Windows.Forms.TextBox textBox_version;
        private System.Windows.Forms.TextBox textBox_equipment;
        private System.Windows.Forms.TextBox textBox_model;
        private System.Windows.Forms.TextBox textBox_brand;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView_veh_DB;
        private System.Windows.Forms.Label label_reservation;
        private System.Windows.Forms.DateTimePicker dateTimePicker_from_date_reserv;
        private System.Windows.Forms.Label label_from_date;
        private System.Windows.Forms.Label label_to_date_reserv;
        private System.Windows.Forms.DateTimePicker dateTimePicker_to_date_reserv;
        private System.Windows.Forms.Button button_reserv;
        private System.Windows.Forms.Button button_check_available_cars;
        private System.Windows.Forms.ComboBox comboBox_purpose_of_reservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox_help;
    }
}
