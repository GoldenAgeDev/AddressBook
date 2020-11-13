using BookLibrary;
using BookLibrary.Models;
using System;
using System.Windows.Forms;

namespace BookUI
{
    public partial class EditContactForm : Form
    {
        private IContactRequestor contactForm;
        public ContactModel ContactEdit { get; set; }
        /// <summary>
        /// Constructor for Edit Contact form
        /// </summary>
        /// <param name="contact">
        /// Takes in requestor interface object
        /// </param>
        public EditContactForm(IContactRequestor contact)
        {
            InitializeComponent();
            contactForm = contact;
        }
        /// <summary>
        /// Loads form while filling fields with information
        /// </summary>
        private void EditContactForm_Load(object sender, EventArgs e)
        {
            LoadFields(ContactEdit);
        }
        /// <summary>
        /// Enters information into textboxes on the form
        /// </summary>
        /// <param name="contact">
        /// ContactModel object
        /// </param>
        private void LoadFields(ContactModel contact)
        {
            firstNameValue.Text = contact.FirstName;
            lastNameValue.Text = contact.LastName;
            birthDateValue.Text = contact.BirthDate;
            cellPhoneValue.Text = contact.CellPhone;
            homePhoneValue.Text = contact.HomePhone;
            officePhoneValue.Text = contact.OfficePhone;
            emailAddressValue.Text = contact.EmailAddress;
            streetAddressOneValue.Text = contact.StreetAddressOne;
            streetAddressTwoValue.Text = contact.StreetAddressTwo;
            cityValue.Text = contact.City;
            stateValue.Text = contact.State;
            zipCodeValue.Text = contact.ZipCode;
        }
        /// <summary>
        /// Creates contact record in database
        /// </summary>
        private void EditContactButton_Click(object sender, EventArgs e)
        {
            ContactModel p = ContactEdit;
            ValidationModel validated = new ValidationModel();

            p.FirstName = firstNameValue.Text;
            p.LastName = lastNameValue.Text;
            p.BirthDate = birthDateValue.Text;
            p.CellPhone = cellPhoneValue.Text;
            p.HomePhone = homePhoneValue.Text;
            p.OfficePhone = officePhoneValue.Text;
            p.EmailAddress = emailAddressValue.Text;
            p.StreetAddressOne = streetAddressOneValue.Text;
            p.StreetAddressTwo = streetAddressTwoValue.Text;
            p.City = cityValue.Text;
            p.State = stateValue.Text;
            p.ZipCode = zipCodeValue.Text;

            validated = ValidationLogic.ValidateForm(p);

            if (validated.Result)
            {
                // TODO: Connect to SQLite instead of SQL Server/Text
                SqliteDataAccess.EditContact(p);
                contactForm.ContactComplete(p);
                this.Close();
            }
            else
            {
                messageLbl.Visible = true;
                messageLbl.Text = validated.Message;
            }
        }
        /// <summary>
        /// Closes Create Contact Form
        /// </summary>
        private void CancelExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Resets all fields to empty
        /// </summary>
        private void ClearEditContactForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            firstNameValue.Text = "";
            lastNameValue.Text = "";
            birthDateValue.Text = "";
            cellPhoneValue.Text = "";
            homePhoneValue.Text = "";
            officePhoneValue.Text = "";
            emailAddressValue.Text = "";
            streetAddressOneValue.Text = "";
            streetAddressTwoValue.Text = "";
            cityValue.Text = "";
            stateValue.Text = "";
            zipCodeValue.Text = "";
        }
    }
}
