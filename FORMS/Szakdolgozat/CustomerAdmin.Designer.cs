﻿namespace Szakdolgozat
{
    partial class frmCustomerAdmin
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
            this.btnAddNewCustomer = new System.Windows.Forms.Button();
            this.btnCustomerEditor = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.tbSearchName = new System.Windows.Forms.TextBox();
            this.dgvCustomerList = new System.Windows.Forms.DataGridView();
            this.Nev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ujUgyfelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujUgyfelFelveteleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfelTorleseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewCustomer.Location = new System.Drawing.Point(94, 223);
            this.btnAddNewCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(295, 58);
            this.btnAddNewCustomer.TabIndex = 0;
            this.btnAddNewCustomer.Text = "Új ügyfél felvétele";
            this.btnAddNewCustomer.UseVisualStyleBackColor = true;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // btnCustomerEditor
            // 
            this.btnCustomerEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCustomerEditor.Location = new System.Drawing.Point(94, 299);
            this.btnCustomerEditor.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomerEditor.Name = "btnCustomerEditor";
            this.btnCustomerEditor.Size = new System.Drawing.Size(295, 58);
            this.btnCustomerEditor.TabIndex = 1;
            this.btnCustomerEditor.Text = "Szerkesztés";
            this.btnCustomerEditor.UseVisualStyleBackColor = true;
            this.btnCustomerEditor.Click += new System.EventHandler(this.btnCustomerEditor_Click);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(94, 374);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(295, 58);
            this.btnDeleteCustomer.TabIndex = 2;
            this.btnDeleteCustomer.Text = "Ügyfél törlése";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClose.Location = new System.Drawing.Point(94, 481);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(295, 58);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Bezár / Kiválaszt ";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.tbSearchName);
            this.groupBox1.Controls.Add(this.dgvCustomerList);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(458, 157);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(521, 441);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ügyfelek listája";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(136, 53);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(136, 17);
            this.lbl1.TabIndex = 7;
            this.lbl1.Text = "Név szerinti keresés";
            // 
            // tbSearchName
            // 
            this.tbSearchName.Location = new System.Drawing.Point(276, 53);
            this.tbSearchName.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearchName.Name = "tbSearchName";
            this.tbSearchName.Size = new System.Drawing.Size(232, 23);
            this.tbSearchName.TabIndex = 6;
            this.tbSearchName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearchName_KeyUp);
            // 
            // dgvCustomerList
            // 
            this.dgvCustomerList.AllowUserToAddRows = false;
            this.dgvCustomerList.AllowUserToDeleteRows = false;
            this.dgvCustomerList.AllowUserToResizeColumns = false;
            this.dgvCustomerList.AllowUserToResizeRows = false;
            this.dgvCustomerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nev,
            this.ZipCode,
            this.City,
            this.Address,
            this.Id,
            this.Telefon,
            this.Email});
            this.dgvCustomerList.Location = new System.Drawing.Point(20, 96);
            this.dgvCustomerList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCustomerList.MultiSelect = false;
            this.dgvCustomerList.Name = "dgvCustomerList";
            this.dgvCustomerList.ReadOnly = true;
            this.dgvCustomerList.RowHeadersVisible = false;
            this.dgvCustomerList.RowHeadersWidth = 62;
            this.dgvCustomerList.RowTemplate.Height = 28;
            this.dgvCustomerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomerList.Size = new System.Drawing.Size(488, 326);
            this.dgvCustomerList.TabIndex = 0;
            // 
            // Nev
            // 
            this.Nev.HeaderText = "Név";
            this.Nev.MinimumWidth = 8;
            this.Nev.Name = "Nev";
            this.Nev.ReadOnly = true;
            this.Nev.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ZipCode
            // 
            this.ZipCode.HeaderText = "Irányítószám";
            this.ZipCode.MinimumWidth = 8;
            this.ZipCode.Name = "ZipCode";
            this.ZipCode.ReadOnly = true;
            // 
            // City
            // 
            this.City.HeaderText = "Helység";
            this.City.MinimumWidth = 8;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.HeaderText = "Cím";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Telefon
            // 
            this.Telefon.HeaderText = "Telefon";
            this.Telefon.MinimumWidth = 8;
            this.Telefon.Name = "Telefon";
            this.Telefon.ReadOnly = true;
            this.Telefon.Visible = false;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ujUgyfelToolStripMenuItem,
            this.kilepesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ujUgyfelToolStripMenuItem
            // 
            this.ujUgyfelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ujUgyfelFelveteleToolStripMenuItem,
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem,
            this.ugyfelTorleseToolStripMenuItem});
            this.ujUgyfelToolStripMenuItem.Name = "ujUgyfelToolStripMenuItem";
            this.ujUgyfelToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.ujUgyfelToolStripMenuItem.Text = "Opciók";
            // 
            // ujUgyfelFelveteleToolStripMenuItem
            // 
            this.ujUgyfelFelveteleToolStripMenuItem.Name = "ujUgyfelFelveteleToolStripMenuItem";
            this.ujUgyfelFelveteleToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.ujUgyfelFelveteleToolStripMenuItem.Text = "Új ügyfél felvétele";
            this.ujUgyfelFelveteleToolStripMenuItem.Click += new System.EventHandler(this.btnAddNewCustomer_Click);
            // 
            // meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem
            // 
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem.Name = "meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem";
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem.Text = "Meglévő ügyfél adatainak szerkesztése";
            this.meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem.Click += new System.EventHandler(this.btnCustomerEditor_Click);
            // 
            // ugyfelTorleseToolStripMenuItem
            // 
            this.ugyfelTorleseToolStripMenuItem.Name = "ugyfelTorleseToolStripMenuItem";
            this.ugyfelTorleseToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.ugyfelTorleseToolStripMenuItem.Text = "Ügyfél törlése";
            this.ugyfelTorleseToolStripMenuItem.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
            this.kilepesToolStripMenuItem.Text = "Bezár";
            this.kilepesToolStripMenuItem.Click += new System.EventHandler(this.kilepesToolStripMenuItem_Click);
            // 
            // frmCustomerAdmin
            // 
            this.AcceptButton = this.btnAddNewCustomer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1098, 697);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnCustomerEditor);
            this.Controls.Add(this.btnAddNewCustomer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCustomerAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ügyféladatok kezelése";
            this.Load += new System.EventHandler(this.frmCustomerAdmin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerList)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewCustomer;
        private System.Windows.Forms.Button btnCustomerEditor;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCustomerList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ujUgyfelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ujUgyfelFelveteleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem meglevoUgyfelAdatainakSzerkeszteseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugyfelTorleseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox tbSearchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nev;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}