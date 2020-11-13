using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Models
{
    public class ContactModel
    {
        /// <summary>
        /// Specific identifier for use in the database.
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Specific first name for person
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Specific last name for person
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Specific birthdate for person
        /// </summary>
        public string BirthDate { get; set; }
        /// <summary>
        /// Specific cell phone number found within the contact information entry
        /// </summary>
        public string CellPhone { get; set; }
        /// <summary>
        /// Specific home phone number found within the contact information entry
        /// </summary>
        public string HomePhone { get; set; }
        /// <summary>
        /// Specific office phone number found within the contact information entry
        /// </summary>
        public string OfficePhone { get; set; }
        /// <summary>
        /// Specific email address found within the contact information entry
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Specific first line of street address found within the mailing information entry
        /// </summary>
        public string StreetAddressOne { get; set; }
        /// <summary>
        /// Specific second line of street address found within the mailing information entry
        /// </summary>
        public string StreetAddressTwo { get; set; }
        /// <summary>
        /// Specific city found within the mailing information entry
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Specific state found within the mailing information entry
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Specific zip code found within the mailing information entry
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// Combination of First and Last name properties
        /// </summary>
        public string FullNameFirst
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
        /// <summary>
        /// Combination of Last and First name properties
        /// </summary>
        public string FullNameLast
        {
            get
            {
                return $"{ LastName } { FirstName }";
            }
        }
    }
}
