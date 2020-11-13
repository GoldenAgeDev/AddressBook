using System;
using System.Collections.Generic;
using System.Text;

namespace BookLibrary.Models
{
    public class ContactModel
    {
        /// <summary>
        /// Specific identifier for person
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
        /// Specific cell phone number for person
        /// </summary>
        public string CellPhone { get; set; }
        /// <summary>
        /// Specific home phone number for person
        /// </summary>
        public string HomePhone { get; set; }
        /// <summary>
        /// Specific office phone number for person
        /// </summary>
        public string OfficePhone { get; set; }
        /// <summary>
        /// Specific email address for person
        /// </summary>
        public string EmailAddress { get; set; }
        /// <summary>
        /// Specific first line of street address for person
        /// </summary>
        public string StreetAddressOne { get; set; }
        /// <summary>
        /// Specific second line of street address for person
        /// </summary>
        public string StreetAddressTwo { get; set; }
        /// <summary>
        /// Specific city for person
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// Specific state for person
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// Specific zip code for person
        /// </summary>
        public string ZipCode { get; set; }
        /// <summary>
        /// Combination of FirstName and LastName
        /// </summary>
        public string FullNameFirst
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
        /// <summary>
        /// Combination of LastName and FirstName
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
