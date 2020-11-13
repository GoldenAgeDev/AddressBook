namespace BookUI
{
    partial class AddressBookViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressBookViewerForm));
            this.ViewerFormTitle = new System.Windows.Forms.Label();
            this.ContactListBox = new System.Windows.Forms.ListBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthdateLabel = new System.Windows.Forms.Label();
            this.HomePhoneLabel = new System.Windows.Forms.Label();
            this.CellPhoneLabel = new System.Windows.Forms.Label();
            this.OfficePhoneLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.StreetAddressOneLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.StateLabel = new System.Windows.Forms.Label();
            this.ZipCodeLabel = new System.Windows.Forms.Label();
            this.MailingInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.ZipCodeDisplayLabel = new System.Windows.Forms.Label();
            this.StateDisplayLabel = new System.Windows.Forms.Label();
            this.CityDisplayLabel = new System.Windows.Forms.Label();
            this.StreetAddressTwoDisplayLabel = new System.Windows.Forms.Label();
            this.StreetAddressOneDisplayLabel = new System.Windows.Forms.Label();
            this.StreetAddressTwoLabel = new System.Windows.Forms.Label();
            this.ContactInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.EmailDisplayLabel = new System.Windows.Forms.Label();
            this.OfficePhoneDisplayLabel = new System.Windows.Forms.Label();
            this.CellPhoneDisplayLabel = new System.Windows.Forms.Label();
            this.HomePhoneDisplayLabel = new System.Windows.Forms.Label();
            this.BirthdateDisplayLabel = new System.Windows.Forms.Label();
            this.NameDisplayLabel = new System.Windows.Forms.Label();
            this.AZButton = new System.Windows.Forms.Button();
            this.ZAButton = new System.Windows.Forms.Button();
            this.CreateContactLinkLabel = new System.Windows.Forms.LinkLabel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.editContactBtn = new System.Windows.Forms.Button();
            this.MailingInfoGroupBox.SuspendLayout();
            this.ContactInfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewerFormTitle
            // 
            this.ViewerFormTitle.AutoSize = true;
            this.ViewerFormTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViewerFormTitle.Location = new System.Drawing.Point(12, 9);
            this.ViewerFormTitle.Name = "ViewerFormTitle";
            this.ViewerFormTitle.Size = new System.Drawing.Size(286, 40);
            this.ViewerFormTitle.TabIndex = 0;
            this.ViewerFormTitle.Text = "Address Book Viewer";
            // 
            // ContactListBox
            // 
            this.ContactListBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ContactListBox.FormattingEnabled = true;
            this.ContactListBox.ItemHeight = 30;
            this.ContactListBox.Location = new System.Drawing.Point(12, 109);
            this.ContactListBox.Name = "ContactListBox";
            this.ContactListBox.Size = new System.Drawing.Size(286, 544);
            this.ContactListBox.TabIndex = 1;
            this.ContactListBox.SelectedIndexChanged += new System.EventHandler(this.ContactListBox_SelectedIndexChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(91, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 30);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name:";
            // 
            // BirthdateLabel
            // 
            this.BirthdateLabel.AutoSize = true;
            this.BirthdateLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BirthdateLabel.Location = new System.Drawing.Point(63, 75);
            this.BirthdateLabel.Name = "BirthdateLabel";
            this.BirthdateLabel.Size = new System.Drawing.Size(102, 30);
            this.BirthdateLabel.TabIndex = 2;
            this.BirthdateLabel.Text = "Birthdate:";
            // 
            // HomePhoneLabel
            // 
            this.HomePhoneLabel.AutoSize = true;
            this.HomePhoneLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomePhoneLabel.Location = new System.Drawing.Point(14, 155);
            this.HomePhoneLabel.Name = "HomePhoneLabel";
            this.HomePhoneLabel.Size = new System.Drawing.Size(151, 30);
            this.HomePhoneLabel.TabIndex = 2;
            this.HomePhoneLabel.Text = "Phone (Home):";
            // 
            // CellPhoneLabel
            // 
            this.CellPhoneLabel.AutoSize = true;
            this.CellPhoneLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CellPhoneLabel.Location = new System.Drawing.Point(36, 115);
            this.CellPhoneLabel.Name = "CellPhoneLabel";
            this.CellPhoneLabel.Size = new System.Drawing.Size(129, 30);
            this.CellPhoneLabel.TabIndex = 2;
            this.CellPhoneLabel.Text = "Phone (Cell):";
            // 
            // OfficePhoneLabel
            // 
            this.OfficePhoneLabel.AutoSize = true;
            this.OfficePhoneLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OfficePhoneLabel.Location = new System.Drawing.Point(14, 195);
            this.OfficePhoneLabel.Name = "OfficePhoneLabel";
            this.OfficePhoneLabel.Size = new System.Drawing.Size(151, 30);
            this.OfficePhoneLabel.TabIndex = 2;
            this.OfficePhoneLabel.Text = "Phone (Office):";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(17, 235);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(148, 30);
            this.EmailLabel.TabIndex = 2;
            this.EmailLabel.Text = "Email Address:";
            // 
            // StreetAddressOneLabel
            // 
            this.StreetAddressOneLabel.AutoSize = true;
            this.StreetAddressOneLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StreetAddressOneLabel.Location = new System.Drawing.Point(14, 40);
            this.StreetAddressOneLabel.Name = "StreetAddressOneLabel";
            this.StreetAddressOneLabel.Size = new System.Drawing.Size(151, 30);
            this.StreetAddressOneLabel.TabIndex = 2;
            this.StreetAddressOneLabel.Text = "Street Address:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityLabel.Location = new System.Drawing.Point(112, 120);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(53, 30);
            this.CityLabel.TabIndex = 2;
            this.CityLabel.Text = "City:";
            // 
            // StateLabel
            // 
            this.StateLabel.AutoSize = true;
            this.StateLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StateLabel.Location = new System.Drawing.Point(101, 160);
            this.StateLabel.Name = "StateLabel";
            this.StateLabel.Size = new System.Drawing.Size(64, 30);
            this.StateLabel.TabIndex = 2;
            this.StateLabel.Text = "State:";
            // 
            // ZipCodeLabel
            // 
            this.ZipCodeLabel.AutoSize = true;
            this.ZipCodeLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZipCodeLabel.Location = new System.Drawing.Point(64, 200);
            this.ZipCodeLabel.Name = "ZipCodeLabel";
            this.ZipCodeLabel.Size = new System.Drawing.Size(101, 30);
            this.ZipCodeLabel.TabIndex = 2;
            this.ZipCodeLabel.Text = "Zip Code:";
            // 
            // MailingInfoGroupBox
            // 
            this.MailingInfoGroupBox.Controls.Add(this.ZipCodeDisplayLabel);
            this.MailingInfoGroupBox.Controls.Add(this.StateDisplayLabel);
            this.MailingInfoGroupBox.Controls.Add(this.CityDisplayLabel);
            this.MailingInfoGroupBox.Controls.Add(this.StreetAddressTwoDisplayLabel);
            this.MailingInfoGroupBox.Controls.Add(this.StreetAddressOneDisplayLabel);
            this.MailingInfoGroupBox.Controls.Add(this.StreetAddressTwoLabel);
            this.MailingInfoGroupBox.Controls.Add(this.ZipCodeLabel);
            this.MailingInfoGroupBox.Controls.Add(this.StreetAddressOneLabel);
            this.MailingInfoGroupBox.Controls.Add(this.StateLabel);
            this.MailingInfoGroupBox.Controls.Add(this.CityLabel);
            this.MailingInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MailingInfoGroupBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.MailingInfoGroupBox.Location = new System.Drawing.Point(314, 410);
            this.MailingInfoGroupBox.Name = "MailingInfoGroupBox";
            this.MailingInfoGroupBox.Size = new System.Drawing.Size(488, 243);
            this.MailingInfoGroupBox.TabIndex = 3;
            this.MailingInfoGroupBox.TabStop = false;
            this.MailingInfoGroupBox.Text = "Mailing Information";
            // 
            // ZipCodeDisplayLabel
            // 
            this.ZipCodeDisplayLabel.AutoSize = true;
            this.ZipCodeDisplayLabel.Location = new System.Drawing.Point(174, 200);
            this.ZipCodeDisplayLabel.Name = "ZipCodeDisplayLabel";
            this.ZipCodeDisplayLabel.Size = new System.Drawing.Size(174, 30);
            this.ZipCodeDisplayLabel.TabIndex = 5;
            this.ZipCodeDisplayLabel.Text = "<Zip Code Here>";
            this.ZipCodeDisplayLabel.Visible = false;
            // 
            // StateDisplayLabel
            // 
            this.StateDisplayLabel.AutoSize = true;
            this.StateDisplayLabel.Location = new System.Drawing.Point(174, 160);
            this.StateDisplayLabel.Name = "StateDisplayLabel";
            this.StateDisplayLabel.Size = new System.Drawing.Size(137, 30);
            this.StateDisplayLabel.TabIndex = 5;
            this.StateDisplayLabel.Text = "<State Here>";
            this.StateDisplayLabel.Visible = false;
            // 
            // CityDisplayLabel
            // 
            this.CityDisplayLabel.AutoSize = true;
            this.CityDisplayLabel.Location = new System.Drawing.Point(174, 120);
            this.CityDisplayLabel.Name = "CityDisplayLabel";
            this.CityDisplayLabel.Size = new System.Drawing.Size(126, 30);
            this.CityDisplayLabel.TabIndex = 5;
            this.CityDisplayLabel.Text = "<City Here>";
            this.CityDisplayLabel.Visible = false;
            // 
            // StreetAddressTwoDisplayLabel
            // 
            this.StreetAddressTwoDisplayLabel.AutoSize = true;
            this.StreetAddressTwoDisplayLabel.Location = new System.Drawing.Point(174, 80);
            this.StreetAddressTwoDisplayLabel.Name = "StreetAddressTwoDisplayLabel";
            this.StreetAddressTwoDisplayLabel.Size = new System.Drawing.Size(241, 30);
            this.StreetAddressTwoDisplayLabel.TabIndex = 5;
            this.StreetAddressTwoDisplayLabel.Text = "<Street Address 2 Here>";
            this.StreetAddressTwoDisplayLabel.Visible = false;
            // 
            // StreetAddressOneDisplayLabel
            // 
            this.StreetAddressOneDisplayLabel.AutoSize = true;
            this.StreetAddressOneDisplayLabel.Location = new System.Drawing.Point(174, 40);
            this.StreetAddressOneDisplayLabel.Name = "StreetAddressOneDisplayLabel";
            this.StreetAddressOneDisplayLabel.Size = new System.Drawing.Size(241, 30);
            this.StreetAddressOneDisplayLabel.TabIndex = 5;
            this.StreetAddressOneDisplayLabel.Text = "<Street Address 1 Here>";
            this.StreetAddressOneDisplayLabel.Visible = false;
            // 
            // StreetAddressTwoLabel
            // 
            this.StreetAddressTwoLabel.AutoSize = true;
            this.StreetAddressTwoLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StreetAddressTwoLabel.Location = new System.Drawing.Point(18, 80);
            this.StreetAddressTwoLabel.Name = "StreetAddressTwoLabel";
            this.StreetAddressTwoLabel.Size = new System.Drawing.Size(147, 30);
            this.StreetAddressTwoLabel.TabIndex = 2;
            this.StreetAddressTwoLabel.Text = "Apt / Ste / etc:";
            // 
            // ContactInfoGroupBox
            // 
            this.ContactInfoGroupBox.Controls.Add(this.EmailDisplayLabel);
            this.ContactInfoGroupBox.Controls.Add(this.OfficePhoneDisplayLabel);
            this.ContactInfoGroupBox.Controls.Add(this.CellPhoneDisplayLabel);
            this.ContactInfoGroupBox.Controls.Add(this.HomePhoneDisplayLabel);
            this.ContactInfoGroupBox.Controls.Add(this.BirthdateDisplayLabel);
            this.ContactInfoGroupBox.Controls.Add(this.NameDisplayLabel);
            this.ContactInfoGroupBox.Controls.Add(this.NameLabel);
            this.ContactInfoGroupBox.Controls.Add(this.EmailLabel);
            this.ContactInfoGroupBox.Controls.Add(this.BirthdateLabel);
            this.ContactInfoGroupBox.Controls.Add(this.HomePhoneLabel);
            this.ContactInfoGroupBox.Controls.Add(this.OfficePhoneLabel);
            this.ContactInfoGroupBox.Controls.Add(this.CellPhoneLabel);
            this.ContactInfoGroupBox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactInfoGroupBox.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ContactInfoGroupBox.Location = new System.Drawing.Point(314, 109);
            this.ContactInfoGroupBox.Name = "ContactInfoGroupBox";
            this.ContactInfoGroupBox.Size = new System.Drawing.Size(488, 276);
            this.ContactInfoGroupBox.TabIndex = 4;
            this.ContactInfoGroupBox.TabStop = false;
            this.ContactInfoGroupBox.Text = "Contact Information";
            // 
            // EmailDisplayLabel
            // 
            this.EmailDisplayLabel.AutoSize = true;
            this.EmailDisplayLabel.Location = new System.Drawing.Point(174, 235);
            this.EmailDisplayLabel.Name = "EmailDisplayLabel";
            this.EmailDisplayLabel.Size = new System.Drawing.Size(141, 30);
            this.EmailDisplayLabel.TabIndex = 5;
            this.EmailDisplayLabel.Text = "<Email Here>";
            this.EmailDisplayLabel.Visible = false;
            // 
            // OfficePhoneDisplayLabel
            // 
            this.OfficePhoneDisplayLabel.AutoSize = true;
            this.OfficePhoneDisplayLabel.Location = new System.Drawing.Point(174, 195);
            this.OfficePhoneDisplayLabel.Name = "OfficePhoneDisplayLabel";
            this.OfficePhoneDisplayLabel.Size = new System.Drawing.Size(212, 30);
            this.OfficePhoneDisplayLabel.TabIndex = 5;
            this.OfficePhoneDisplayLabel.Text = "<Office Phone Here>";
            this.OfficePhoneDisplayLabel.Visible = false;
            // 
            // CellPhoneDisplayLabel
            // 
            this.CellPhoneDisplayLabel.AutoSize = true;
            this.CellPhoneDisplayLabel.Location = new System.Drawing.Point(174, 115);
            this.CellPhoneDisplayLabel.Name = "CellPhoneDisplayLabel";
            this.CellPhoneDisplayLabel.Size = new System.Drawing.Size(190, 30);
            this.CellPhoneDisplayLabel.TabIndex = 5;
            this.CellPhoneDisplayLabel.Text = "<Cell Phone Here>";
            this.CellPhoneDisplayLabel.Visible = false;
            // 
            // HomePhoneDisplayLabel
            // 
            this.HomePhoneDisplayLabel.AutoSize = true;
            this.HomePhoneDisplayLabel.Location = new System.Drawing.Point(174, 155);
            this.HomePhoneDisplayLabel.Name = "HomePhoneDisplayLabel";
            this.HomePhoneDisplayLabel.Size = new System.Drawing.Size(212, 30);
            this.HomePhoneDisplayLabel.TabIndex = 5;
            this.HomePhoneDisplayLabel.Text = "<Home Phone Here>";
            this.HomePhoneDisplayLabel.Visible = false;
            // 
            // BirthdateDisplayLabel
            // 
            this.BirthdateDisplayLabel.AutoSize = true;
            this.BirthdateDisplayLabel.Location = new System.Drawing.Point(174, 75);
            this.BirthdateDisplayLabel.Name = "BirthdateDisplayLabel";
            this.BirthdateDisplayLabel.Size = new System.Drawing.Size(175, 30);
            this.BirthdateDisplayLabel.TabIndex = 5;
            this.BirthdateDisplayLabel.Text = "<Birthdate Here>";
            this.BirthdateDisplayLabel.Visible = false;
            // 
            // NameDisplayLabel
            // 
            this.NameDisplayLabel.AutoSize = true;
            this.NameDisplayLabel.Location = new System.Drawing.Point(174, 35);
            this.NameDisplayLabel.Name = "NameDisplayLabel";
            this.NameDisplayLabel.Size = new System.Drawing.Size(220, 30);
            this.NameDisplayLabel.TabIndex = 5;
            this.NameDisplayLabel.Text = "<Combo Name Here>";
            this.NameDisplayLabel.Visible = false;
            // 
            // AZButton
            // 
            this.AZButton.BackColor = System.Drawing.Color.White;
            this.AZButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.AZButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AZButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.AZButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AZButton.Location = new System.Drawing.Point(12, 65);
            this.AZButton.Name = "AZButton";
            this.AZButton.Size = new System.Drawing.Size(80, 38);
            this.AZButton.TabIndex = 1;
            this.AZButton.Text = "A to Z";
            this.AZButton.UseVisualStyleBackColor = false;
            this.AZButton.Click += new System.EventHandler(this.AZButton_Click);
            // 
            // ZAButton
            // 
            this.ZAButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ZAButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ZAButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ZAButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ZAButton.Location = new System.Drawing.Point(102, 65);
            this.ZAButton.Name = "ZAButton";
            this.ZAButton.Size = new System.Drawing.Size(81, 38);
            this.ZAButton.TabIndex = 2;
            this.ZAButton.Text = "Z to A";
            this.ZAButton.UseVisualStyleBackColor = true;
            this.ZAButton.Click += new System.EventHandler(this.ZAButton_Click);
            // 
            // CreateContactLinkLabel
            // 
            this.CreateContactLinkLabel.AutoSize = true;
            this.CreateContactLinkLabel.Location = new System.Drawing.Point(603, 69);
            this.CreateContactLinkLabel.Name = "CreateContactLinkLabel";
            this.CreateContactLinkLabel.Size = new System.Drawing.Size(199, 30);
            this.CreateContactLinkLabel.TabIndex = 4;
            this.CreateContactLinkLabel.TabStop = true;
            this.CreateContactLinkLabel.Text = "Create New Contact";
            this.CreateContactLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CreateContactLinkLabel_LinkClicked);
            // 
            // RemoveButton
            // 
            this.RemoveButton.BackColor = System.Drawing.Color.White;
            this.RemoveButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RemoveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.RemoveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveButton.Location = new System.Drawing.Point(415, 65);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(105, 38);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = false;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // editContactBtn
            // 
            this.editContactBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.editContactBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.editContactBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.editContactBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editContactBtn.Location = new System.Drawing.Point(314, 65);
            this.editContactBtn.Name = "editContactBtn";
            this.editContactBtn.Size = new System.Drawing.Size(86, 38);
            this.editContactBtn.TabIndex = 5;
            this.editContactBtn.Text = "Edit";
            this.editContactBtn.UseVisualStyleBackColor = true;
            this.editContactBtn.Click += new System.EventHandler(this.editContactBtn_Click);
            // 
            // AddressBookViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(823, 666);
            this.Controls.Add(this.editContactBtn);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.CreateContactLinkLabel);
            this.Controls.Add(this.ZAButton);
            this.Controls.Add(this.AZButton);
            this.Controls.Add(this.ContactInfoGroupBox);
            this.Controls.Add(this.MailingInfoGroupBox);
            this.Controls.Add(this.ContactListBox);
            this.Controls.Add(this.ViewerFormTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "AddressBookViewerForm";
            this.Text = "Address Book";
            this.MailingInfoGroupBox.ResumeLayout(false);
            this.MailingInfoGroupBox.PerformLayout();
            this.ContactInfoGroupBox.ResumeLayout(false);
            this.ContactInfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ViewerFormTitle;
        private System.Windows.Forms.ListBox ContactListBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BirthdateLabel;
        private System.Windows.Forms.Label HomePhoneLabel;
        private System.Windows.Forms.Label CellPhoneLabel;
        private System.Windows.Forms.Label OfficePhoneLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label StreetAddressOneLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.Label StateLabel;
        private System.Windows.Forms.Label ZipCodeLabel;
        private System.Windows.Forms.GroupBox MailingInfoGroupBox;
        private System.Windows.Forms.Label StreetAddressTwoLabel;
        private System.Windows.Forms.GroupBox ContactInfoGroupBox;
        private System.Windows.Forms.Label ZipCodeDisplayLabel;
        private System.Windows.Forms.Label StateDisplayLabel;
        private System.Windows.Forms.Label CityDisplayLabel;
        private System.Windows.Forms.Label StreetAddressTwoDisplayLabel;
        private System.Windows.Forms.Label StreetAddressOneDisplayLabel;
        private System.Windows.Forms.Label EmailDisplayLabel;
        private System.Windows.Forms.Label OfficePhoneDisplayLabel;
        private System.Windows.Forms.Label CellPhoneDisplayLabel;
        private System.Windows.Forms.Label HomePhoneDisplayLabel;
        private System.Windows.Forms.Label BirthdateDisplayLabel;
        private System.Windows.Forms.Label NameDisplayLabel;
        private System.Windows.Forms.Button AZButton;
        private System.Windows.Forms.Button ZAButton;
        private System.Windows.Forms.LinkLabel CreateContactLinkLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button editContactBtn;
    }
}

