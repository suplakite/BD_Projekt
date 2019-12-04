﻿namespace VMA
{
    partial class UserControl_addKeeper
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
            this.dataGridView_Worker = new System.Windows.Forms.DataGridView();
            this.dataGridView_veh = new System.Windows.Forms.DataGridView();
            this.button_add_keeper = new System.Windows.Forms.Button();
            this.dataGridView_Keepers = new System.Windows.Forms.DataGridView();
            this.add_care = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Worker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_veh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Keepers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Worker
            // 
            this.dataGridView_Worker.AllowUserToAddRows = false;
            this.dataGridView_Worker.AllowUserToDeleteRows = false;
            this.dataGridView_Worker.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_Worker.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Worker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Worker.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_Worker.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_Worker.Location = new System.Drawing.Point(22, 28);
            this.dataGridView_Worker.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_Worker.Name = "dataGridView_Worker";
            this.dataGridView_Worker.ReadOnly = true;
            this.dataGridView_Worker.RowTemplate.Height = 24;
            this.dataGridView_Worker.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Worker.Size = new System.Drawing.Size(496, 167);
            this.dataGridView_Worker.TabIndex = 46;
            // 
            // dataGridView_veh
            // 
            this.dataGridView_veh.AllowUserToAddRows = false;
            this.dataGridView_veh.AllowUserToDeleteRows = false;
            this.dataGridView_veh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_veh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_veh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_veh.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_veh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_veh.Location = new System.Drawing.Point(518, 42);
            this.dataGridView_veh.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_veh.Name = "dataGridView_veh";
            this.dataGridView_veh.ReadOnly = true;
            this.dataGridView_veh.RowTemplate.Height = 24;
            this.dataGridView_veh.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_veh.Size = new System.Drawing.Size(401, 385);
            this.dataGridView_veh.TabIndex = 47;
            // 
            // button_add_keeper
            // 
            this.button_add_keeper.BackColor = System.Drawing.Color.Yellow;
            this.button_add_keeper.FlatAppearance.BorderSize = 0;
            this.button_add_keeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_add_keeper.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_add_keeper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.button_add_keeper.Location = new System.Drawing.Point(189, 213);
            this.button_add_keeper.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_add_keeper.Name = "button_add_keeper";
            this.button_add_keeper.Size = new System.Drawing.Size(173, 31);
            this.button_add_keeper.TabIndex = 81;
            this.button_add_keeper.Text = "Dodaj opiekuna";
            this.button_add_keeper.UseVisualStyleBackColor = false;
            this.button_add_keeper.Click += new System.EventHandler(this.button_add_keeper_Click);
            // 
            // dataGridView_Keepers
            // 
            this.dataGridView_Keepers.AllowUserToAddRows = false;
            this.dataGridView_Keepers.AllowUserToDeleteRows = false;
            this.dataGridView_Keepers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_Keepers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_Keepers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Keepers.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridView_Keepers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataGridView_Keepers.Location = new System.Drawing.Point(0, 260);
            this.dataGridView_Keepers.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView_Keepers.Name = "dataGridView_Keepers";
            this.dataGridView_Keepers.ReadOnly = true;
            this.dataGridView_Keepers.RowTemplate.Height = 24;
            this.dataGridView_Keepers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView_Keepers.Size = new System.Drawing.Size(496, 167);
            this.dataGridView_Keepers.TabIndex = 82;
            // 
            // add_care
            // 
            this.add_care.BackColor = System.Drawing.Color.Yellow;
            this.add_care.FlatAppearance.BorderSize = 0;
            this.add_care.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_care.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.add_care.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.add_care.Location = new System.Drawing.Point(114, 477);
            this.add_care.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_care.Name = "add_care";
            this.add_care.Size = new System.Drawing.Size(173, 31);
            this.add_care.TabIndex = 83;
            this.add_care.Text = "Przypisz auto";
            this.add_care.UseVisualStyleBackColor = false;
            this.add_care.Click += new System.EventHandler(this.add_care_Click);
            // 
            // UserControl_addKeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Controls.Add(this.add_care);
            this.Controls.Add(this.dataGridView_Keepers);
            this.Controls.Add(this.button_add_keeper);
            this.Controls.Add(this.dataGridView_veh);
            this.Controls.Add(this.dataGridView_Worker);
            this.Name = "UserControl_addKeeper";
            this.Size = new System.Drawing.Size(941, 656);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Worker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_veh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Keepers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Worker;
        private System.Windows.Forms.DataGridView dataGridView_veh;
        private System.Windows.Forms.Button button_add_keeper;
        private System.Windows.Forms.DataGridView dataGridView_Keepers;
        private System.Windows.Forms.Button add_care;
    }
}
