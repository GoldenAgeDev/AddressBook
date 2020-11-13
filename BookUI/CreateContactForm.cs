using BookLibrary;
using BookLibrary.Models;
using System;
using System.Windows.Forms;

namespace BookUI
{
    public partial class CreateContactForm : Form
    {
        private IContactRequestor contactForm;
        /// <summary>
        /// Constructor for Create Contact form
        /// </summary>
        /// <param name="contact">
        /// Takes in requestor interface object
        /// </param>
        public CreateContactForm(IContactRequestor contact)
        {
            InitializeComponent();
            contactForm = contact;
        }
        /// <summary>
        /// Creates contact record in database
        /// </summary>
        private void CreateContactButton_Click(object sender, EventArgs e)
        {
            ContactModel p = new ContactModel();
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
                SqliteDataAccess.SaveContact(p);
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
        private void ClearCreateContactForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
