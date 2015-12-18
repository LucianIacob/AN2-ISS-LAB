using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_ISS.Controller
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public class DataBaseInterraction
    {
        private numeEntities database;

        public DataBaseInterraction()
        {
            database = new numeEntities();
        }

        public List<Administrator> loadAdminsFromDataBase()
        {
            return database.Administrator.ToList();
        }
        public List<Costumer> loadCostumersFromDataBase()
        {
            return database.Costumer.ToList();
        }
        public List<Book> loadBooksFromDataBase()
        {
            return database.Book.ToList();
        }
        public List<BorrowedBook> loadBorrowedBooksFromDataBase()
        {
            return database.BorrowedBook.ToList();
        }

        /// <summary>
        /// Borrow a book. Save it to BorrowedBook Table and delete it from Book Table.
        /// </summary>
        /// <param name="book"></param>
        /// <param name="newBorrowed"></param>
        public void borrowBookSaveChanges(Book book, BorrowedBook newBorrowed)
        {
            foreach (Book bk in database.Book.ToList())
                if (String.Compare(bk.ToString(), book.ToString()) == 0)
                    database.Book.Remove(bk);
            database.BorrowedBook.Add(newBorrowed);
            database.SaveChanges();
        }

        /// <summary>
        /// Search a customer by his code
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public bool searchForCostumer(string code)
        {
            IQueryable<Costumer> iq = database.Costumer.Where(c => c.cod_unic == code);
            return iq.ToList().Count == 0 ? false : true;
        }

        /// <summary>
        /// Return a borrowed book. Save it to Book table and delete it from Borrowed Book Table.
        /// </summary>
        /// <param name="bk"></param>
        /// <param name="borr"></param>
        public void returnBookSaveChanges(Book bk, BorrowedBook borr)
        {
            foreach (BorrowedBook bo in database.BorrowedBook.ToList())
                if (String.Compare(bo.ToString(), borr.ToString()) == 0)
                    database.BorrowedBook.Remove(bo);
            database.Book.Add(bk);
            database.SaveChanges();
        }

        /// <summary>
        /// Remove a book from book table.
        /// </summary>
        /// <param name="bk"></param>
        public void removeBook(Book bk)
        {
            foreach (Book b in database.Book.ToList())
                if (String.Compare(b.ToString(), bk.ToString()) == 0)
                    database.Book.Remove(b);
            database.SaveChanges();
        }

        /// <summary>
        /// Search a publication by its code.
        /// </summary>
        /// <param name="publicationCode"></param>
        /// <returns></returns>
        public bool searchPublicationCode(string publicationCode)
        {
            IQueryable<Book> iq = database.Book.Where(c => c.cod_carte == publicationCode);
            IQueryable<BorrowedBook> iqu = database.BorrowedBook.Where(c => c.cod_carte == publicationCode);
            return iq.ToList().Count == 0 && iqu.ToList().Count == 0 ? true : false;
        }

        /// <summary>
        /// Add new book - bk
        /// </summary>
        /// <param name="bk"></param>
        public void addNewPublication(Book bk)
        {
            database.Book.Add(bk);
            database.SaveChanges();
        }

        /// <summary>
        /// Update a book by setting a new title and a new author
        /// </summary>
        /// <param name="bk"></param>
        public void updatePublication(Book bk)
        {
            Book b = database.Book.First(i => i.cod_carte == bk.cod_carte);
            b.autor = bk.autor;
            b.titlu = bk.titlu;
            database.SaveChanges();
        }
    }
}