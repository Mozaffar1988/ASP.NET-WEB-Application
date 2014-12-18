using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using PLManagementApp.DLL.DAO;

namespace PLManagementApp.DLL.GateWay
{
    public class BookGateWay
    {
        private SqlConnection aConnection;
        public BookGateWay()
        {
            string conn = @"server=WIN-APF1B7L3NAT; database=PLManagementDB;integrated security=true";
            aConnection = new SqlConnection();
            aConnection.ConnectionString = conn;
        }

        public List<Book> GetAllBooks()
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_book");
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Book> books = new List<Book>();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Book aBook = new Book();
                    aBook.BookId = (int)aReader[0];
                    aBook.BookTitle = aReader[1].ToString();
                    aBook.BookAuthor = aReader[2].ToString();
                    aBook.BookPublisher = aReader[3].ToString();
                    books.Add(aBook);
                }
            }
            aConnection.Close();
            return books;
        }

        public Book GetBookById(int selectedBookId)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_book WHERE id={0}", selectedBookId);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Book> books = new List<Book>();
            Book aBook = null;
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    aBook = new Book();
                    aBook.BookId = (int)aReader[0];
                    aBook.BookTitle = aReader[1].ToString();
                    aBook.BookAuthor = aReader[2].ToString();
                    aBook.BookPublisher = aReader[3].ToString();
                }
            }
            aReader.Close();
            aConnection.Close();
            return aBook;
        }

        public bool SaveBorrow(Book aBook)
        {
            aConnection.Open();
            string quary = string.Format("INSERT INTO t_record_member_book VALUES ({0},{1},'{2}')", aBook.Member.MemberId,aBook.BookId,aBook.BookTitle);
            SqlCommand aCommand = new SqlCommand(quary, aConnection);
            int total = aCommand.ExecuteNonQuery();
            aConnection.Close();
            if (total > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Book> GetAllBorrowedBook(int memberNumber)
        {
            aConnection.Open();
            string query = string.Format("SELECT * FROM t_record_member_book WHERE member_id = " +memberNumber);
            SqlCommand aCommand = new SqlCommand(query, aConnection);
            SqlDataReader aReader = aCommand.ExecuteReader();
            List<Book> books = new List<Book>();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Book aBook = new Book();
                   
                    aBook.BookTitle = aReader[3].ToString();
                  
                    books.Add(aBook);
                }
            }
            aConnection.Close();
            return books;
        }

        public bool GetReturnBook(Book aBook)
        {
            aConnection.Open();
            string quary = string.Format("DELETE FROM dbo.t_record_member_book  WHERE id={0}", aBook.BookId);
            SqlCommand aCommand = new SqlCommand(quary, aConnection);
            int total = aCommand.ExecuteNonQuery();
            
            if (total > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            aConnection.Close();
        }
    }
}