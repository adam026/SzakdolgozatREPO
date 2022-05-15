namespace Szakdolgozat
{
    partial class frmUserAdmin
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
            this.btnAddNewUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAction = new System.Windows.Forms.Button();
            this.tbPasswordNew = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbAction = new System.Windows.Forms.GroupBox();
            this.tbPasswordAgain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Felhasznalok = new System.Windows.Forms.ListBox();
            this.gbAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddNewUser
            // 
            this.btnAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddNewUser.Location = new System.Drawing.Point(122, 144);
            this.btnAddNewUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddNewUser.Name = "btnAddNewUser";
            this.btnAddNewUser.Size = new System.Drawing.Size(195, 71);
            this.btnAddNewUser.TabIndex = 0;
            this.btnAddNewUser.Text = "Új felhasználó hozzáadása ";
            this.btnAddNewUser.UseVisualStyleBackColor = true;
            this.btnAddNewUser.Click += new System.EventHandler(this.btnAddNewUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteUser.Location = new System.Drawing.Point(122, 247);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(195, 71);
            this.btnDeleteUser.TabIndex = 1;
            this.btnDeleteUser.Text = "Felhasználó törlése ";
            this.btnDeleteUser.UseVisualStyleBackColor = true;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnChangePassword.Location = new System.Drawing.Point(122, 354);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(195, 71);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Jelszó módosítás";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // tbUserName
            // 
            this.tbUserName.Enabled = false;
            this.tbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUserName.Location = new System.Drawing.Point(37, 88);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(187, 23);
            this.tbUserName.TabIndex = 4;
            // 
            // tbPassword
            // 
            this.tbPassword.Enabled = false;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword.Location = new System.Drawing.Point(37, 155);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(187, 23);
            this.tbPassword.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(8, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(8, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jelszó";
            // 
            // btnAction
            // 
            this.btnAction.Enabled = false;
            this.btnAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAction.Location = new System.Drawing.Point(37, 373);
            this.btnAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(187, 42);
            this.btnAction.TabIndex = 8;
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // tbPasswordNew
            // 
            this.tbPasswordNew.Enabled = false;
            this.tbPasswordNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPasswordNew.Location = new System.Drawing.Point(37, 297);
            this.tbPasswordNew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPasswordNew.Name = "tbPasswordNew";
            this.tbPasswordNew.PasswordChar = '*';
            this.tbPasswordNew.Size = new System.Drawing.Size(187, 23);
            this.tbPasswordNew.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 275);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Új jelszó";
            // 
            // gbAction
            // 
            this.gbAction.Controls.Add(this.Felhasznalok);
            this.gbAction.Controls.Add(this.tbPasswordAgain);
            this.gbAction.Controls.Add(this.label4);
            this.gbAction.Controls.Add(this.label1);
            this.gbAction.Controls.Add(this.label3);
            this.gbAction.Controls.Add(this.tbUserName);
            this.gbAction.Controls.Add(this.tbPasswordNew);
            this.gbAction.Controls.Add(this.label2);
            this.gbAction.Controls.Add(this.btnAction);
            this.gbAction.Controls.Add(this.tbPassword);
            this.gbAction.Location = new System.Drawing.Point(385, 104);
            this.gbAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAction.Name = "gbAction";
            this.gbAction.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbAction.Size = new System.Drawing.Size(573, 432);
            this.gbAction.TabIndex = 11;
            this.gbAction.TabStop = false;
            // 
            // tbPasswordAgain
            // 
            this.tbPasswordAgain.Enabled = false;
            this.tbPasswordAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPasswordAgain.Location = new System.Drawing.Point(37, 213);
            this.tbPasswordAgain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPasswordAgain.Name = "tbPasswordAgain";
            this.tbPasswordAgain.PasswordChar = '*';
            this.tbPasswordAgain.Size = new System.Drawing.Size(187, 23);
            this.tbPasswordAgain.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Jelszó újra";
            // 
            // Felhasznalok
            // 
            this.Felhasznalok.Enabled = false;
            this.Felhasznalok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Felhasznalok.FormattingEnabled = true;
            this.Felhasznalok.ItemHeight = 16;
            this.Felhasznalok.Location = new System.Drawing.Point(316, 34);
            this.Felhasznalok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Felhasznalok.Name = "Felhasznalok";
            this.Felhasznalok.Size = new System.Drawing.Size(229, 308);
            this.Felhasznalok.Sorted = true;
            this.Felhasznalok.TabIndex = 14;
            this.Felhasznalok.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Felhasznalok_MouseDoubleClick);
            this.Felhasznalok.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Felhasznalok_MouseDoubleClick);
            // 
            // frmUserAdmin
            // 
            this.AcceptButton = this.btnAddNewUser;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 697);
            this.ControlBox = false;
            this.Controls.Add(this.gbAction);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.btnAddNewUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUserAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Felhasznalo Adminisztracio";
            this.Load += new System.EventHandler(this.frmUserAdmin_Load);
            this.gbAction.ResumeLayout(false);
            this.gbAction.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddNewUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.TextBox tbPasswordNew;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbAction;
        private System.Windows.Forms.TextBox tbPasswordAgain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Felhasznalok;
    }
}