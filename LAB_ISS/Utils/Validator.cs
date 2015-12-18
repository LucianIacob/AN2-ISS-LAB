using LAB_ISS.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_ISS.Utils
{
    public class Validator
    {
        DataBaseInterraction database;

        public Validator(DataBaseInterraction db)
        {
            database = db;
        }

        /// <summary>
        /// Validate a new book
        /// </summary>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="publicationCode"></param>
        /// <returns></returns>
        public string validateNewBook(string title, string author, string publicationCode)
        {
            String status = String.Empty;
            if (Regex.IsMatch(title, @"^[a-zA-Z0-9 ]+$") == false)
                status = status + "The title is not in correct format! (only letters and numbers)\n\r";
            if (Regex.IsMatch(author, @"^[a-zA-Z ]+$") == false)
                status = status + "The author is not in the correct format! (only letters)\n\r";
            if (database.searchPublicationCode(publicationCode) == false)
                status = status + "The publication code must be unique! (check in publication list or borrowed publication list)\n\r";

            if (String.Compare(status, String.Empty) == 0)
                return "Passed";
            else
                return status;
        }

        /// <summary>
        /// Validate data for existing book
        /// </summary>
        /// <param name="newTitle"></param>
        /// <param name="newAuthor"></param>
        /// <returns></returns>
        public string validateUpdateBook(string newTitle, string newAuthor)
        {
            String status = String.Empty;
            if (Regex.IsMatch(newTitle, @"^[a-zA-Z0-9 ]+$") == false)
                status = status + "The title is not in correct format! (only letters and numbers)\n\r";
            if (Regex.IsMatch(newAuthor, @"^[a-zA-Z ]+$") == false)
                status = status + "The author is not in the correct format! (only letters)\n\r";

            if (String.Compare(status, String.Empty) == 0)
                return "Passed";
            else
                return status;
        }
    }
}
