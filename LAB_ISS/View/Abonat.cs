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
    public partial class Abonat : Form, IObserver<Book>
    {
        MemoryRepository<Book> repositoryAvailableBooks;
        LibraryController controller;

        public Abonat(MemoryRepository<Book> repo, LibraryController ctrl)
        {
            InitializeComponent();
            this.controller = ctrl;
            this.repositoryAvailableBooks = repo;
            this.repositoryAvailableBooks.Subscribe(this);
            reloadBookList();
        }

        private void reloadBookList()
        {
            lstPublicationsInAbonatPanel.Items.Clear();
            foreach (Book bk in repositoryAvailableBooks.getAll())
                lstPublicationsInAbonatPanel.Items.Add(bk.ToString());
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (lstPublicationsInAbonatPanel.SelectedIndex == -1)
                MessageBox.Show("Select a publication!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                controller.borrowBook(lstPublicationsInAbonatPanel.SelectedItem.ToString(), this.Text);
                lblStatus.Text = "The publication was successfully borrowed";
                Timer t = new Timer();
                t.Interval = 3000;
                t.Tick += (s, f) =>
                {
                    lblStatus.Hide();
                    t.Stop();
                };
                t.Start();
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

    }
}
