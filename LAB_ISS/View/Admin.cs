using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAB_ISS.Controller;

namespace LAB_ISS
{
    public partial class Admin : Form, IObserver<Book>, IObserver<BorrowedBook>
    {
        MemoryRepository<Book> repositoryAvailableBooks;
        MemoryRepository<BorrowedBook> repositoryBorrowedBooks;
        LibraryController controller;

        public Admin(MemoryRepository<Book> repo1, MemoryRepository<BorrowedBook> repo2, LibraryController ctrl)
        {
            InitializeComponent();
            this.controller = ctrl;
            this.repositoryAvailableBooks = repo1;
            this.repositoryBorrowedBooks = repo2;
            this.repositoryAvailableBooks.Subscribe(this);
            this.repositoryBorrowedBooks.Subscribe(this);
            this.reloadBookList();
            this.reloadBorrowedBookList();
        }

        private void reloadBookList()
        {
            lstPublicationsInAdminPanel.Items.Clear();
            foreach (Book bk in repositoryAvailableBooks.getAll())
                lstPublicationsInAdminPanel.Items.Add(bk.ToString());
        }

        private void reloadBorrowedBookList()
        {
            lstBorrowedBooks.Items.Clear();
            foreach (BorrowedBook bk in repositoryBorrowedBooks.getAll())
                lstBorrowedBooks.Items.Add(bk.ToString());
        }
        
        private void btnReturnPublication_Click(object sender, EventArgs e)
        {
            if (lstBorrowedBooks.SelectedIndex == -1)
                MessageBox.Show("Select a borrowed publication!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                lblShowStatus.Text = "The publication was successfully returned";
                Timer t = new Timer();
                t.Interval = 3000;
                t.Tick += (s, f) =>
                {
                    lblShowStatus.Hide();
                    t.Stop();
                };
                t.Start();
                controller.returnBorrowedBook(lstBorrowedBooks.SelectedItem.ToString());
            }
        }

        private void btnDeletePublication_Click(object sender, EventArgs e)
        {
            if (lstPublicationsInAdminPanel.SelectedIndex == -1)
                MessageBox.Show("Select a publication!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                controller.deletePublication(lstPublicationsInAdminPanel.SelectedItem.ToString());
                lblShowStatus.Text = "The publication was successfully deleted";
                Timer t = new Timer();
                t.Interval = 3000;
                t.Tick += (s, f) =>
                {
                    lblShowStatus.Hide();
                    t.Stop();
                };
                t.Start();
            }
        }

        private void btnAddPublication_Click(object sender, EventArgs e)
        {
            if (String.Compare(controller.addNewPublication(txtTitle.Text, txtAuthor.Text, txtPublicationCode.Text), String.Empty) != 0)
                MessageBox.Show(controller.addNewPublication(txtTitle.Text, txtAuthor.Text, txtPublicationCode.Text), "Cannot Add Publication", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                txtAuthor.Clear();
                txtPublicationCode.Clear();
                txtTitle.Clear();
                lblShowStatus.Text = "The publication was successfully added";
                Timer t = new Timer();
                t.Interval = 3000;
                t.Tick += (s, f) =>
                    {
                        lblShowStatus.Hide();
                        t.Stop();
                    };
                t.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lstPublicationsInAdminPanel.SelectedIndex == -1)
                MessageBox.Show("Select a publication!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                if(String.Compare(controller.updateExistingPublication(lstPublicationsInAdminPanel.SelectedItem.ToString(), txtNewTitle.Text, txtNewAuthor.Text), String.Empty) != 0)
                    MessageBox.Show(controller.updateExistingPublication(lstPublicationsInAdminPanel.SelectedItem.ToString(), txtNewTitle.Text, txtNewAuthor.Text), "Cannot Update Publication", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    txtNewAuthor.Clear();
                    txtNewTitle.Clear();
                    lblShowStatus.Text = "The publication was successfully updated";
                    Timer t = new Timer();
                    t.Interval = 3000;
                    t.Tick += (s, f) =>
                    {
                        lblShowStatus.Hide();
                        t.Stop();
                    };
                    t.Start();
                }
            }
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }
        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }
        public void OnNext(Book value)
        {
            this.reloadBookList();
        }
        public void OnNext(BorrowedBook value)
        {
            this.reloadBorrowedBookList();
        }
    }
}