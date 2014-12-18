using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PLManagementApp.BLL;
using PLManagementApp.DLL.DAO;

namespace PLManagementApp.UI
{
    public partial class BorrowUI : System.Web.UI.Page
    {
        BookBLL aBookBll = new BookBLL();
        MemberBLL aMemberBll = new MemberBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Book> books = aBookBll.GetAllBooks();
                books.Insert(0, new Book() { BookId = -99, BookTitle = "Selected Book" });
                titleDropDownList.DataSource = books;
                titleDropDownList.DataTextField = "BookTitle";
                titleDropDownList.DataValueField = "BookId";
                titleDropDownList.DataBind();
            }
           

        }

        protected void borrowButton_Click(object sender, EventArgs e)
        {
            Book aBook = new Book();
           // aBook.Member.MemberNumber = Convert.ToInt32(memberTexBox.Text);
            aBook.Member.MemberId = Convert.ToInt32(memberTexBox.Text);
            aBook.BookId = Convert.ToInt32(titleDropDownList.SelectedValue);
            aBook.BookTitle = titleDropDownList.SelectedItem.Text;
            aBook.BookAuthor = authorTexBox.Text;
            aBook.BookPublisher = publisherTextBox.Text;
            bool FindMember = aMemberBll.FindMemberById(aBook.Member.MemberId);
            

            if (FindMember)
            {
                messageconfirm.Text = "This book is borrowed by member whose number is :" + aBook.Member.MemberNumber;
                bool Save = aBookBll.SaveBorrow(aBook);
                if (Save)
                {
                    messageconfirm.Text = "This book is borrowed by member whose number is :" + aBook.Member.MemberId;
                }
                else
                {
                    messageconfirm.Text = "Not Save";
                }
             
            }
            else
            {
                messageconfirm.Text = "Sorry,member number doesn't exits";
            }
        }

        protected void titleDropDownList_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedBookId = Convert.ToInt32(titleDropDownList.SelectedValue);
            Book aBook = aBookBll.GetBookById(selectedBookId);
            if (aBook != null)
            {
                authorTexBox.Text = aBook.BookAuthor;
                publisherTextBox.Text = aBook.BookPublisher;
            }
            else
            {
                authorTexBox.Text = "Select Book...";
                publisherTextBox.Text = "Select Book....";
            }
          
        }
    }
}