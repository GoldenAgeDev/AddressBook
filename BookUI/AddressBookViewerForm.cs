using BookLibrary;
using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BookUI
{
    public partial class AddressBookViewerForm : Form, IContactRequestor
    {
        /// <summary>
        /// knownContacts list filled by FillListBox() method; sortedContacts list holds temporary data
        /// </summary>
        private List<ContactModel> knownContacts = new List<ContactModel>();
        private List<ContactModel> sortedContacts = new List<ContactModel>();
        /// <summary>
        /// Form constructor, loads contacts into list box
        /// </summary>
        public AddressBookViewerForm()
        {
            InitializeComponent();
            FillListBox();
        }
        /// <summary>
        /// Populates contact listbox with knownContacts
        /// </summary>
        private void FillListBox()
        {
            knownContacts = SqliteDataAccess.LoadContacts();
            ContactListBox.DataSource = null;
            ContactListBox.DataSource = knownContacts;
            ContactListBox.DisplayMember = "FullNameLast";
        }
        /// <summary>
        /// Sorting method displays ascending entries, fills listbox
        /// </summary>
        private void AscSortListBox()
        {
            sortedContacts = knownContacts.OrderBy(x => x.FullNameLast).ToList();
            ContactListBox.DataSource = null;
            ContactListBox.DataSource = sortedContacts;
            ContactListBox.DisplayMember = "FullNameLast";
            sortedContacts.Clear();
        }
        /// <summary>
        /// Sorting method displays descending entries, fills listbox
        /// </summary>
        private void DesSortListBox()
        {
            sortedContacts = knownContacts.OrderByDescending(x => x.FullNameLast).ToList();
            ContactListBox.DataSource = null;
            ContactListBox.DataSource = sortedContacts;
            ContactListBox.DisplayMember = "FullNameLast";
            sortedContacts.Clear();
        }
        /// <summary>
        /// Launches Create Contact form, passes current instance of the viewer form
        /// </summary>
        private void CreateContactLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateContactForm frm = new CreateContactForm(this);
            frm.Show();
        }
        /// <summary>
        /// When listbox item is selected, contact information is displayed
        /// </summary>
        private void ContactListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayContactInfo();
            LoadContactInfo((ContactModel)ContactListBox.SelectedItem);
        }
        /// <summary>
        /// Displays form labels
        /// </summary>
        private void DisplayContactInfo() 
        {
            bool isVisible = (knownContacts.Count > 0);

            NameDisplayLabel.Visible = isVisible;
            BirthdateDisplayLabel.Visible = isVisible;
            CellPhoneDisplayLabel.Visible = isVisible;
            HomePhoneDisplayLabel.Visible = isVisible;
            OfficePhoneDisplayLabel.Visible = isVisible;
            EmailDisplayLabel.Visible = isVisible;
            StreetAddressOneDisplayLabel.Visible = isVisible;
            StreetAddressTwoDisplayLabel.Visible = isVisible;
            CityDisplayLabel.Visible = isVisible;
            StateDisplayLabel.Visible = isVisible;
            ZipCodeDisplayLabel.Visible = isVisible;
        }
        /// <summary>
        /// Displays information contained in a contact model object
        /// </summary>
        /// <param name="model">
        /// Contact model object
        /// </param>
        private void LoadContactInfo(ContactModel model)
        {
            if (model != null)
            {
                NameDisplayLabel.Text = model.FullNameFirst;
                BirthdateDisplayLabel.Text = model.BirthDate;
                CellPhoneDisplayLabel.Text = model.CellPhone;
                HomePhoneDisplayLabel.Text = model.HomePhone;
                OfficePhoneDisplayLabel.Text = model.OfficePhone;
                EmailDisplayLabel.Text = model.EmailAddress;
                StreetAddressOneDisplayLabel.Text = model.StreetAddressOne;
                StreetAddressTwoDisplayLabel.Text = model.StreetAddressTwo;
                CityDisplayLabel.Text = model.City;
                StateDisplayLabel.Text = model.State;
                ZipCodeDisplayLabel.Text = model.ZipCode;

                if (BirthdateDisplayLabel.Text == "  /  /")
                {
                    BirthdateDisplayLabel.Visible = false;
                }
                if (CellPhoneDisplayLabel.Text == "(   )    -")
                {
                    CellPhoneDisplayLabel.Visible = false;
                }
                if (HomePhoneDisplayLabel.Text == "(   )    -")
                {
                    HomePhoneDisplayLabel.Visible = false;
                }
                if (OfficePhoneDisplayLabel.Text == "(   )    -")
                {
                    OfficePhoneDisplayLabel.Visible = false;
                }
            }
        }
        /// <summary>
        /// Adds contact to the list of contacts
        /// </summary>
        /// <param name="contact">
        /// ContactModel object
        /// </param>
        public void ContactComplete(ContactModel contact)
        {
            knownContacts.Add(contact);
            FillListBox();
        }
        /// <summary>
        /// Deletes listbox record from database
        /// </summary>
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            ContactModel contact = (ContactModel)ContactListBox.SelectedItem;
            if (contact != null)
            {
                SqliteDataAccess.DeleteContact(contact);
                knownContacts = SqliteDataAccess.LoadContacts();
                FillListBox();
            }
            else
            {
                MessageBox.Show("Select a contact first!");
            }

        }
        /// <summary>
        /// Calls AscSortListBox()
        /// </summary>
        private void AZButton_Click(object sender, EventArgs e)
        {
            AscSortListBox();
        }
        /// <summary>
        /// Calls DescSortListBox()
        /// </summary>
        private void ZAButton_Click(object sender, EventArgs e)
        {
            DesSortListBox();
        }
        /// <summary>
        /// Launches Edit Contact form for selected contact
        /// </summary>
        private void editContactBtn_Click(object sender, EventArgs e)
        {
            EditContactForm frm = new EditContactForm(this);
            ContactModel contact = (ContactModel)ContactListBox.SelectedItem;
            if (contact != null)
            {
                frm.ContactEdit = contact;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Select a contact first!");
            }
        }
    }
}