using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MiniProject___Budgetting_App.Classes
{

    public class User
    {
        // Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }


        // Dictionary to store user credentials
        private static Dictionary<string, string> userCredentials = new Dictionary<string, string>
        {
            { "admin", "admin" }
        };

        // Constructor
        public User(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
        }

        // Method to verify email format
        public bool IsValidEmail()
        {
            string pattern = @"^[\w\.-]+@(gmail\.com|yahoo\.com|outlook\.com)$";
            return Regex.IsMatch(Email, pattern);
        }


        // Method to add user to dictionary
        public bool AddUser()
        {
            if (IsValidEmail() && !userCredentials.ContainsKey(Email))
            {
                userCredentials.Add(Email, Password);
                return true;
            }
            return false;
        }

        // Method to validate login credentials
        public static bool ValidateLogin(string email, string password)
        {
            return userCredentials.ContainsKey(email) && userCredentials[email] == password;
        }
    }
}