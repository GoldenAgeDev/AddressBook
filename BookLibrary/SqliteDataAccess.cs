using BookLibrary.Models;
using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace BookLibrary
{
    public class SqliteDataAccess
	{
		/// <summary>
		/// Initialize SQLite connection
		/// </summary>
		/// <param name="id">
		/// id found in App.Config connection string
		/// </param>
		/// <returns>
		/// Relative path of database file
		/// </returns>
		private static string LoadConnectionString(string id = "Default")
		{
			return ConfigurationManager.ConnectionStrings[id].ConnectionString;
		}
		/// <summary>
		/// Calls database with select statement, ordered by LastName property
		/// </summary>
		/// <returns>
		/// List of contact records
		/// </returns>
		public static List<ContactModel> LoadContacts()
		{
			using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
			{
				var output = connection.Query<ContactModel>("select cont.* from Contacts cont order by LastName", new DynamicParameters());
				return output.ToList();
			}
		}
		/// <summary>
		/// Calls database with insert statement to save ContactModel object properties
		/// </summary>
		/// <param name="contact">
		/// ContactModel object
		/// </param>
		public static void SaveContact(ContactModel contact)
		{
			using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
			{
				connection.Execute("insert into Contacts (FirstName, LastName, BirthDate, CellPhone, HomePhone, OfficePhone, EmailAddress, StreetAddressOne, StreetAddressTwo, City, State, ZipCode) " +
								   "values (@FirstName, @LastName, @BirthDate, @CellPhone, @HomePhone, @OfficePhone, @EmailAddress, @StreetAddressOne, @StreetAddressTwo, @City, @State, @ZipCode)", 
								   contact);
			}
		}
		/// <summary>
		/// Calls database with remove statement
		/// </summary>
		/// <param name="contact">
		/// ContactModel object
		/// </param>
		public static void DeleteContact(ContactModel contact)
        {
			using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
			{
				var output = connection.Query<ContactModel>("delete from Contacts where id = @id", contact);
			}
		}
		/// <summary>
		/// Calls database with update statement
		/// </summary>
		/// <param name="contact">
		/// ContactModel object
		/// </param>
		public static void EditContact(ContactModel contact)
        {
			using (IDbConnection connection = new SQLiteConnection(LoadConnectionString()))
			{
                connection.Execute(@"update Contacts
									 set FirstName = @FirstName,
										 LastName = @LastName, 
										 BirthDate = @BirthDate, 
										 CellPhone = @CellPhone, 
										 HomePhone = @HomePhone, 
										 OfficePhone = @OfficePhone, 
										 EmailAddress = @EmailAddress,
										 StreetAddressOne = @StreetAddressOne,
										 StreetAddressTwo = @StreetAddressTwo,
										 City = @City,
										 State = @State,
										 ZipCode = @ZipCode
									 where id = @id;", contact);
            }
		}
	}
}
