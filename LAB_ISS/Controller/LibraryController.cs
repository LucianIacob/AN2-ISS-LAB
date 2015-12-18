using LAB_ISS.Model;
using LAB_ISS.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_ISS.Controller
{
    public class LibraryController
    {
        private MemoryRepository<Administrator> adminRepository;
        private MemoryRepository<Costumer> costumerRepository;
        private MemoryRepository<Book> booksRepository;
        private MemoryRepository<BorrowedBook> borrowedBooksRepository;
        private DataBaseInterraction dataBaseInterraction;
        private Validator validator;

        public LibraryController()
        {
            costumerRepository = new MemoryRepository<Costumer>();
            adminRepository = new MemoryRepository<Administrator>();
            booksRepository = new MemoryRepository<Book>();
            borrowedBooksRepository = new MemoryRepository<BorrowedBook>();
            dataBaseInterraction = new DataBaseInterraction();
            loadDataFromDataBase();
            validator = new Validator(dataBaseInterraction);
        }

        private void loadDataFromDataBase()
        {
            foreach (Administrator ad in dataBaseInterraction.loadAdminsFromDataBase())
                adminRepository.addObject(ad);
            foreach (Costumer c in dataBaseInterraction.loadCostumersFromDataBase())
                costumerRepository.addObject(c);
            foreach (Book bk in dataBaseInterraction.loadBooksFromDataBase())
                booksRepository.addObject(bk);
            foreach (BorrowedBook bk in dataBaseInterraction.loadBorrowedBooksFromDataBase())
                borrowedBooksRepository.addObject(bk);
        }

        public string adminLogIn(string p1, string p2)
        {
            Administrator adm = new Administrator();
            adm.username = p1;
            adm.password = p2;
            if (adminRepository.findObject(adm) == true)
            {
                Admin admin = new Admin(booksRepository, borrowedBooksRepository, this);
                admin.Text = "Admin session: " + p1;
                admin.Show();
                return String.Empty;
            }
            return " ";
        }

        public string costumerLogIn(string p)
        {
            if (dataBaseInterraction.searchForCostumer(p) == true)
            {
                Abonat ab = new Abonat(booksRepository, this);
                ab.Text = "Customer session: " + p;
                ab.Show();
                return String.Empty;
            }
            return " ";
        }

        public void borrowBook(string bookToBorrow, string customerID)
        {
            string[] line = bookToBorrow.Split(';');
            BorrowedBook newBorrowed = new BorrowedBook();
            Book book = new Book();
            book.titlu = newBorrowed.titlu = line[0];
            book.autor = newBorrowed.autor = line[1];
            book.cod_carte = newBorrowed.cod_carte = line[2];
            newBorrowed.cod_abonat = customerID.Split(' ')[2];

            borrowedBooksRepository.addObject(newBorrowed);
            booksRepository.removeObject(book);
            dataBaseInterraction.borrowBookSaveChanges(book, newBorrowed);
        }

        public void returnBorrowedBook(string book)
        {
            string[] line = book.Split(';');
            BorrowedBook borr = new BorrowedBook();
            Book bk = new Book();
            bk.titlu = borr.titlu = line[0];
            bk.autor = borr.autor = line[1];
            bk.cod_carte = borr.cod_carte = line[2];
            borr.cod_abonat = line[3];

            booksRepository.addObject(bk);
            borrowedBooksRepository.removeObject(borr);
            dataBaseInterraction.returnBookSaveChanges(bk, borr);
        }

        public void deletePublication(string book)
        {
            String[] lines = book.Split(';');
            Book bk = new Book();
            bk.titlu = lines[0];
            bk.autor = lines[1];
            bk.cod_carte = lines[2];
            booksRepository.removeObject(bk);
            dataBaseInterraction.removeBook(bk);
        }

        public string addNewPublication(string title, string author, string publicationCode)
        {
            if (String.Compare(validator.validateNewBook(title, author, publicationCode), "Passed") == 0)
            {
                Book bk = new Book();
                bk.titlu = title;
                bk.autor = author;
                bk.cod_carte = publicationCode;
                booksRepository.addObject(bk);
                dataBaseInterraction.addNewPublication(bk);
                return String.Empty;
            }
            return validator.validateNewBook(title, author, publicationCode);
        }

        public string updateExistingPublication(string book, string newTitle, string newAuthor)
        {
            string[] lines = book.Split(';');
            if (String.Compare(validator.validateUpdateBook(newTitle, newAuthor), "Passed") == 0)
            {
                Book auxBook = new Book();
                auxBook.autor = lines[1];
                auxBook.titlu = lines[0];
                auxBook.cod_carte = lines[2];
                booksRepository.removeObject(auxBook);
                auxBook.autor = newAuthor;
                auxBook.titlu = newTitle;
                booksRepository.addObject(auxBook);
                dataBaseInterraction.updatePublication(auxBook);
                return String.Empty;
            }
            return validator.validateUpdateBook(newTitle, newAuthor);
        }
    }
}