using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using BookClassLibrary;

namespace DisplayBooks
{
    public partial class DisplayBooksForm : Form
    {
        public DisplayBooksForm()
        {
            InitializeComponent();
        }


        private void DisplayBooksForm_Load(object sender, EventArgs e)
        {
            comboBoxQuery.SelectedIndex = -1;
        }

        private void comboBoxQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            BooksEntities dbcontext = new BooksEntities();

            txtQueryResult.Clear(); // clear the current content of the textbox

            switch (comboBoxQuery.SelectedIndex)
            {
                case 0:
                    // get authors of each book they co-authored, sorted by title
                    var booksAndAuthorsOrderedByTitle = from book in dbcontext.Titles
                                                        from author in book.Authors
                                                        orderby book.Title1
                                                        select new { book.Title1, Name = author.LastName + " " + author.FirstName };
                    txtQueryResult.AppendText("TITLES AND AUTHORS (sorted by title): ");
                    foreach (var element in booksAndAuthorsOrderedByTitle)
                    {
                        txtQueryResult.AppendText($"\r\n\r\n\t \"{element.Title1,-10}\", "
                            + $"co-authored by {element.Name,-10}");
                    }
                    break;

                case 1:
                    // get authors of each book they co-authored, sorted by title, author's last name, author's first name
                    var booksAndAuthorsOrderedByTitleLastFirst = from book in dbcontext.Titles
                                                                 from author in book.Authors
                                                                 orderby book.Title1, author.LastName, author.FirstName
                                                                 select new { book.Title1, Name = author.LastName + " " + author.FirstName };
                    txtQueryResult.AppendText("TITLES AND AUTHORS (sorted by title, author's last name, author's first name): ");
                    foreach (var element in booksAndAuthorsOrderedByTitleLastFirst)
                    {
                        txtQueryResult.AppendText($"\r\n\r\n\t \"{element.Title1,-10}\""
                            + $"co-authored by {element.Name,-10}");
                    }
                    break;

                case 2:
                    // get authors of each book, group them by the book title - sorted by title, author's last name, author's first name
                    var authorsGroupedByBookOrderedByTitleLastFirst = from book in dbcontext.Titles
                                                                      orderby book.Title1
                                                                      select new
                                                                      {
                                                                          book.Title1,
                                                                          ItsAuthorsLastName = (from author in book.Authors
                                                                                                orderby author.LastName, author.LastName
                                                                                                select new { author.LastName, author.FirstName })
                                                                      };
                    txtQueryResult.AppendText("TITLES AND AUTHORS "
                        + "(sorted and grouped by title; sorted by author's last name, then author's first name): ");
                    foreach (var element in authorsGroupedByBookOrderedByTitleLastFirst)
                    {
                        txtQueryResult.AppendText($"\r\n\r\n\t \"{element.Title1}\", by");

                        foreach (var author in element.ItsAuthorsLastName)
                            txtQueryResult.AppendText($"\r\n\r\n\t\t {author.LastName} {author.FirstName}");
                    }
                    break;
            }
        }
    }
}
