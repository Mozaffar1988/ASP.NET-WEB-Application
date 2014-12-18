using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PLManagementApp.DLL.DAO;
using PLManagementApp.DLL.GateWay;

namespace PLManagementApp.BLL
{
    public class BookBLL
    {
        private BookGateWay aBookGateWay;

        public BookBLL()
        {
            aBookGateWay = new BookGateWay();
            MemberGateWay aMemberGateWay = new MemberGateWay();
        }

        public List<Book> GetAllBooks()
        {
           return aBookGateWay.GetAllBooks();
        }

        public Book GetBookById(int selectedBookId)
        {
           return aBookGateWay.GetBookById(selectedBookId);
        }


        public bool SaveBorrow(Book aBook)
        {
           return aBookGateWay.SaveBorrow(aBook);
        }

        public List<Book> GetAllBorrowedBook(int memberNumber)
        {
           return aBookGateWay.GetAllBorrowedBook(memberNumber);
        }

        public bool GetReturnBook(Book aBook)
        {
           return aBookGateWay.GetReturnBook(aBook);
        }
    }
}