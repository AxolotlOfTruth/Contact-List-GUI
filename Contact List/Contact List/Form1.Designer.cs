namespace Contact_List
{
    partial class ContactList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactList));
            this.imgProfile = new System.Windows.Forms.PictureBox();
            this.btnNewContact = new System.Windows.Forms.Button();
            this.grpNewContact = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.rbtnProfessional = new System.Windows.Forms.RadioButton();
            this.rbtnPersonal = new System.Windows.Forms.RadioButton();
            this.grpContacts = new System.Windows.Forms.GroupBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lstContacts = new System.Windows.Forms.ListBox();
            this.btnPicture = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblNameNumber = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbtnByNumber = new System.Windows.Forms.RadioButton();
            this.rbtnByName = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).BeginInit();
            this.grpNewContact.SuspendLayout();
            this.grpContacts.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgProfile
            // 
            this.imgProfile.Image = global::Contact_List.Properties.Resources.rhodes;
            this.imgProfile.Location = new System.Drawing.Point(13, 31);
            this.imgProfile.Name = "imgProfile";
            this.imgProfile.Size = new System.Drawing.Size(179, 181);
            this.imgProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgProfile.TabIndex = 1;
            this.imgProfile.TabStop = false;
            // 
            // btnNewContact
            // 
            this.btnNewContact.Location = new System.Drawing.Point(13, 217);
            this.btnNewContact.Name = "btnNewContact";
            this.btnNewContact.Size = new System.Drawing.Size(178, 23);
            this.btnNewContact.TabIndex = 2;
            this.btnNewContact.Text = "Add New Contact";
            this.btnNewContact.UseVisualStyleBackColor = true;
            this.btnNewContact.Click += new System.EventHandler(this.btnNewContact_Click);
            // 
            // grpNewContact
            // 
            this.grpNewContact.Controls.Add(this.btnAdd);
            this.grpNewContact.Controls.Add(this.btnCancel);
            this.grpNewContact.Controls.Add(this.lblNumber);
            this.grpNewContact.Controls.Add(this.lblName);
            this.grpNewContact.Controls.Add(this.txtNumber);
            this.grpNewContact.Controls.Add(this.txtName);
            this.grpNewContact.Controls.Add(this.rbtnProfessional);
            this.grpNewContact.Controls.Add(this.rbtnPersonal);
            this.grpNewContact.Enabled = false;
            this.grpNewContact.Location = new System.Drawing.Point(12, 247);
            this.grpNewContact.Name = "grpNewContact";
            this.grpNewContact.Size = new System.Drawing.Size(179, 156);
            this.grpNewContact.TabIndex = 3;
            this.grpNewContact.TabStop = false;
            this.grpNewContact.Text = "New Contact";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(53, 124);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(57, 26);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(116, 124);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(57, 26);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Enabled = false;
            this.lblNumber.Location = new System.Drawing.Point(4, 94);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(44, 13);
            this.lblNumber.TabIndex = 5;
            this.lblNumber.Text = "Number";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Enabled = false;
            this.lblName.Location = new System.Drawing.Point(6, 59);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // txtNumber
            // 
            this.txtNumber.Enabled = false;
            this.txtNumber.Location = new System.Drawing.Point(62, 91);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 3;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(62, 56);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // rbtnProfessional
            // 
            this.rbtnProfessional.AutoSize = true;
            this.rbtnProfessional.Enabled = false;
            this.rbtnProfessional.Location = new System.Drawing.Point(80, 20);
            this.rbtnProfessional.Name = "rbtnProfessional";
            this.rbtnProfessional.Size = new System.Drawing.Size(82, 17);
            this.rbtnProfessional.TabIndex = 1;
            this.rbtnProfessional.TabStop = true;
            this.rbtnProfessional.Text = "Professional";
            this.rbtnProfessional.UseVisualStyleBackColor = true;
            // 
            // rbtnPersonal
            // 
            this.rbtnPersonal.AutoSize = true;
            this.rbtnPersonal.Enabled = false;
            this.rbtnPersonal.Location = new System.Drawing.Point(7, 20);
            this.rbtnPersonal.Name = "rbtnPersonal";
            this.rbtnPersonal.Size = new System.Drawing.Size(66, 17);
            this.rbtnPersonal.TabIndex = 0;
            this.rbtnPersonal.TabStop = true;
            this.rbtnPersonal.Text = "Personal";
            this.rbtnPersonal.UseVisualStyleBackColor = true;
            // 
            // grpContacts
            // 
            this.grpContacts.Controls.Add(this.btnGoBack);
            this.grpContacts.Controls.Add(this.btnModify);
            this.grpContacts.Controls.Add(this.btnDelete);
            this.grpContacts.Controls.Add(this.lstContacts);
            this.grpContacts.Location = new System.Drawing.Point(197, 12);
            this.grpContacts.Name = "grpContacts";
            this.grpContacts.Size = new System.Drawing.Size(257, 332);
            this.grpContacts.TabIndex = 4;
            this.grpContacts.TabStop = false;
            this.grpContacts.Text = "Contacts";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(112, 289);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(66, 38);
            this.btnModify.TabIndex = 3;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(184, 289);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lstContacts
            // 
            this.lstContacts.FormattingEnabled = true;
            this.lstContacts.Location = new System.Drawing.Point(6, 19);
            this.lstContacts.Name = "lstContacts";
            this.lstContacts.Size = new System.Drawing.Size(245, 264);
            this.lstContacts.TabIndex = 1;
            this.lstContacts.SelectedIndexChanged += new System.EventHandler(this.lstContacts_SelectedIndexChanged);
            // 
            // btnPicture
            // 
            this.btnPicture.Enabled = false;
            this.btnPicture.Location = new System.Drawing.Point(36, 189);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(131, 23);
            this.btnPicture.TabIndex = 5;
            this.btnPicture.Text = "Click to Insert Image";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Visible = false;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.lblNameNumber);
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.rbtnByNumber);
            this.grpSearch.Controls.Add(this.rbtnByName);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Location = new System.Drawing.Point(197, 345);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(257, 58);
            this.grpSearch.TabIndex = 6;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // lblNameNumber
            // 
            this.lblNameNumber.AutoSize = true;
            this.lblNameNumber.Location = new System.Drawing.Point(80, 16);
            this.lblNameNumber.Name = "lblNameNumber";
            this.lblNameNumber.Size = new System.Drawing.Size(38, 13);
            this.lblNameNumber.TabIndex = 4;
            this.lblNameNumber.Text = "Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(83, 30);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // rbtnByNumber
            // 
            this.rbtnByNumber.AutoSize = true;
            this.rbtnByNumber.Location = new System.Drawing.Point(6, 35);
            this.rbtnByNumber.Name = "rbtnByNumber";
            this.rbtnByNumber.Size = new System.Drawing.Size(77, 17);
            this.rbtnByNumber.TabIndex = 2;
            this.rbtnByNumber.Text = "By Number";
            this.rbtnByNumber.UseVisualStyleBackColor = true;
            this.rbtnByNumber.CheckedChanged += new System.EventHandler(this.rbtnByNumber_CheckedChanged);
            // 
            // rbtnByName
            // 
            this.rbtnByName.AutoSize = true;
            this.rbtnByName.Checked = true;
            this.rbtnByName.Location = new System.Drawing.Point(6, 18);
            this.rbtnByName.Name = "rbtnByName";
            this.rbtnByName.Size = new System.Drawing.Size(68, 17);
            this.rbtnByName.TabIndex = 1;
            this.rbtnByName.TabStop = true;
            this.rbtnByName.Text = "By Name";
            this.rbtnByName.UseVisualStyleBackColor = true;
            this.rbtnByName.CheckedChanged += new System.EventHandler(this.rbtnByName_CheckedChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(189, 26);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 26);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.SystemColors.Menu;
            this.btnGoBack.Location = new System.Drawing.Point(40, 289);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(66, 38);
            this.btnGoBack.TabIndex = 4;
            this.btnGoBack.Text = "Go Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Visible = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // ContactList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 406);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.btnPicture);
            this.Controls.Add(this.grpContacts);
            this.Controls.Add(this.grpNewContact);
            this.Controls.Add(this.btnNewContact);
            this.Controls.Add(this.imgProfile);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContactList";
            this.Text = "Contact List";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgProfile)).EndInit();
            this.grpNewContact.ResumeLayout(false);
            this.grpNewContact.PerformLayout();
            this.grpContacts.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgProfile;
        private System.Windows.Forms.Button btnNewContact;
        private System.Windows.Forms.GroupBox grpNewContact;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.RadioButton rbtnProfessional;
        private System.Windows.Forms.RadioButton rbtnPersonal;
        private System.Windows.Forms.GroupBox grpContacts;
        private System.Windows.Forms.ListBox lstContacts;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.RadioButton rbtnByNumber;
        private System.Windows.Forms.RadioButton rbtnByName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblNameNumber;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnGoBack;
    }
}

