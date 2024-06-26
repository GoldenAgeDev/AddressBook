﻿using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BookLibrary
{
    public class ValidationLogic
    {
        public static ValidationModel ValidateForm(ContactModel p)
        {
            ValidationModel fullValidation = new ValidationModel();
            ValidationModel nameValidation = new ValidationModel();
            ValidationModel dateValidation = new ValidationModel();
            ValidationModel phoneValidation = new ValidationModel();

            fullValidation.Message = "";
            fullValidation.Result = true;

            nameValidation = ValidateName(p);
            dateValidation = ValidateDate(p);
            phoneValidation = ValidatePhone(p);

            if (!nameValidation.Result)
            {
                fullValidation.Message = nameValidation.Message;
                fullValidation.Result = nameValidation.Result;
                return fullValidation;
            }

            if (!dateValidation.Result)
            {
                fullValidation.Message = dateValidation.Message;
                fullValidation.Result = dateValidation.Result;
                return fullValidation;
            }

            if (!phoneValidation.Result)
            {
                fullValidation.Message = phoneValidation.Message;
                fullValidation.Result = phoneValidation.Result;
                return fullValidation;
            }

            return fullValidation;
        }
        /// <summary>
        /// Validates First Name and Last Name
        /// </summary>
        /// <returns>
        /// Returns ValidationModel result and message
        /// </returns>
        private static ValidationModel ValidateName(ContactModel p)
        {
            ValidationModel nameCheck = new ValidationModel();
            nameCheck.Message = "";
            nameCheck.Result = true;

            if (p.FirstName.Length == 0 && p.LastName.Length == 0)
            {
                nameCheck.Message = "Enter a name for this contact.";
                nameCheck.Result = false;
                return nameCheck;
            }

            if (p.FirstName.Length == 0)
            {
                nameCheck.Message = "First name is required.";
                nameCheck.Result = false;
                return nameCheck;
            }

            if (p.LastName.Length == 0)
            {
                nameCheck.Message = "Last name is required.";
                nameCheck.Result = false;
                return nameCheck;
            }

            return nameCheck;
        }
        /// <summary>
        /// Validates BirthDate
        /// </summary>
        /// <returns>
        /// Returns ValidationModel result and message
        /// </returns>
        private static ValidationModel ValidateDate(ContactModel p)
        {
            ValidationModel dateCheck = new ValidationModel();
            dateCheck.Message = "";
            dateCheck.Result = true;

            if (p.BirthDate == "  /  /")
            {
                dateCheck.Result = true;
                return dateCheck;
            }

            string digits = CleanNumbers(p.BirthDate);

            if (!CheckNumLen(digits, 8))
            {
                dateCheck.Message = "Valid date example - 01/01/1986";
                dateCheck.Result = false;
                return dateCheck;
            }

            if (p.BirthDate.Length != 0)
            {
                int month = 0;
                int.TryParse(digits.Substring(0, 2), out month);

                int day = 0;
                int.TryParse(digits.Substring(2, 2), out day);

                int year = 0;
                int.TryParse(digits.Substring(4, 4), out year);

                if (!(month >= 1 && month <= 12))
                {
                    dateCheck.Message = "Month must be between 01 and 12.";
                    dateCheck.Result = false;
                    return dateCheck;
                }

                if (!(day >= 1 && day <= 31))
                {
                    dateCheck.Message = "Day must be between 01 and 31.";
                    dateCheck.Result = false;
                    return dateCheck;
                }

                if (!(year >= 1900 && year <= DateTime.Now.Year))
                {
                    dateCheck.Message = "Year must be between 1900 and " + DateTime.Now.Year;
                    dateCheck.Result = false;
                    return dateCheck;
                }

                if (IsLeapYear(year) && month == 2)
                {
                    if (day > 29)
                    {
                        dateCheck.Message = "Leap Year - February has no more than 29 days.";
                        dateCheck.Result = false;
                        return dateCheck;
                    }
                }

                if (!IsLeapYear(year) && month == 2)
                {
                    if (day > 28)
                    {
                        dateCheck.Message = "Non-Leap Year - February has no more than 28 days.";
                        dateCheck.Result = false;
                        return dateCheck;
                    }
                }

                if (IsThirtyDay(month) && day > 30)
                {
                    dateCheck.Message = "This month does not have 31 days.";
                    dateCheck.Result = false;
                    return dateCheck;
                }
            }
            else
            {
                dateCheck.Message = "Valid date example - 01/01/1986";
                dateCheck.Result = false;
                return dateCheck;
            }

            return dateCheck;
        }
        /// <summary>
        /// Validates all PhoneNumber fields
        /// </summary>
        /// <returns>
        /// Returns ValidationModel result and message
        /// </returns>
        private static ValidationModel ValidatePhone(ContactModel p)
        {
            List<string> phoneNums = new List<string>();
            ValidationModel phoneCheck = new ValidationModel();
            phoneCheck.Message = "";
            phoneCheck.Result = true;

            phoneNums = SortPhoneNums(phoneNums, p);

            foreach (string phone in phoneNums)
            {
                if (CleanNumbers(p.CellPhone).Length > 0)
                {
                    if (!CheckNumLen(p.CellPhone, 10))
                    {
                        phoneCheck.Message = "Cell phone number entered did not contain enough digits.";
                        phoneCheck.Result = false;
                        return phoneCheck;
                    }
                }

                if (CleanNumbers(p.HomePhone).Length > 0)
                {
                    if (!CheckNumLen(p.HomePhone, 10))
                    {
                        phoneCheck.Message = "Home phone number entered did not contain enough digits.";
                        phoneCheck.Result = false;
                        return phoneCheck;
                    }
                }

                if (CleanNumbers(p.OfficePhone).Length > 0)
                {
                    if (!CheckNumLen(p.OfficePhone, 10))
                    {
                        phoneCheck.Message = "Office phone number entered did not contain enough digits.";
                        phoneCheck.Result = false;
                        return phoneCheck;
                    }
                }
            }

            return phoneCheck;
        }
        /// <summary>
        /// Adds non-null phone nums to list of string numbers
        /// </summary>
        /// <param name="nums">
        /// List to hold phone nums as strings
        /// </param>
        /// <param name="p">
        /// ContactModel object
        /// </param>
        /// <returns>
        /// Returns completed list of phone number strings, excluding any empty phone numbers
        /// </returns>
        private static List<string> SortPhoneNums(List<string> nums, ContactModel p)
        {
            if (p.CellPhone != "(   )    -")
            {
                nums.Add(p.CellPhone);
            }


            if (p.HomePhone != "(   )    -")
            {
                nums.Add(p.HomePhone);
            }

            if (p.OfficePhone != "(   )    -")
            {
                nums.Add(p.OfficePhone);
            }

            return nums;
        }
        /// <summary>
        /// Runs established algorithm for determining Gregorian Leap Years
        /// </summary>
        /// <param name="year">
        /// Year from BirthDate
        /// </param>
        /// <returns>
        /// True if leap year, false if not
        /// </returns>
        private static bool IsLeapYear(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }

            else if (year % 100 != 0)
            {
                return true;
            }

            else if (year % 400 != 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }
        /// <summary>
        /// Indicates if a month has thirty days
        /// </summary>
        /// <param name="month">
        /// Month from BirthDate
        /// </param>
        /// <returns>
        /// True if thirty day month, false if thirty-one day month
        /// </returns>
        private static bool IsThirtyDay(int month)
        {
            int[] thirty = { 4, 6, 9, 11 };
            if (!InArray(month, thirty))
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Checks an array for a specific number
        /// </summary>
        /// <param name="month">
        /// Passed as num between 1 - 12
        /// </param>
        /// <param name="array">
        /// Array of month nums
        /// </param>
        /// <returns>
        /// True if num in array or false if num not in array
        /// </returns>
        private static bool InArray(int month, int[] array)
        {
            int found = 0;

            for (int i = 0; i < array.Length; i++)
            {
                found = array[i];

                if (found == month)
                {
                    return true;
                }
            }

            return false;
        }
        /// <summary>
        /// Checks length of string of nums
        /// </summary>
        /// <param name="input">
        /// Initial string of nums
        /// </param>
        /// <param name="i">
        /// Goal length of the string of nums
        /// </param>
        /// <returns>
        /// True if num = goal length, false if not goal length
        /// </returns>
        private static bool CheckNumLen(string input, int i)
        {
            string num = CleanNumbers(input);

            if (num.Length != i)
            {
                return false;
            }

            return true;
        }
        /// <summary>
        /// Creates Regex entry
        /// </summary>
        private static readonly Regex rxNonDigits = new Regex(@"[^\d]+");
        /// <summary>
        /// Eliminates special cahracters to return a string of nums
        /// </summary>
        /// <param name="str">
        /// String object including puntuation
        /// </param>
        /// <returns>
        /// String of nums
        /// </returns>
        private static string CleanNumbers(string str)
        {
            if (string.IsNullOrEmpty(str)) return str;
            
            string cleanNum = rxNonDigits.Replace(str, "");
            
            return cleanNum;
        }
    }
}