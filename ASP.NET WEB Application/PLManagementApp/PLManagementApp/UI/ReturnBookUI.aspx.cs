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
    public partial class ReturnBookUI : System.Web.UI.Page
    {
        private MemberBLL aMemberBll = new MemberBLL();
        BookBLL aBookBll = new BookBLL();
        private Book aBook;

        protected void Page_Load(object sender, EventArgs e)
        {
            ViewState["Book"] = aBook;
        }

        protected void borrowButton_Click(object sender, EventArgs e)
        {
            Member aMember = new Member();
            aBook = new Book();
            aMember.MemberNumber = Convert.ToInt32(memberTextBox.Text);
            bool isBorrowed = aMemberBll.GetMemberNumber(aMember.MemberNumber);        
            if (isBorrowed)
            {
                if (IsPostBack)
                {
                    aBook.Member.MemberNumber = aMember.MemberNumber;
                   // List<Book> books = aBookBll.GetAllBorrowedBook(aBook.Member.MemberNumber);
                    bookDropDownList.DataSource = aBookBll.GetAllBorrowedBook(aBook.Member.MemberNumber);
                    bookDropDownList.DataTextField = "BookTitle";
                    bookDropDownList.DataValueField = "BookId";
                    bookDropDownList.DataBind();
                   
                    
                    aBook.BookId = Convert.ToInt32(bookDropDownList.SelectedValue);


                }
            }
            else
            {
                messageLabel.Text = "This Member is not borrowed any book..";
            }

        }

        protected void returnButton_Click(object sender, EventArgs e)
        {
            ViewState["Book"] = aBook;
            //Book aBook = new Book();
            aBook.BookId = Convert.ToInt32(bookDropDownList.SelectedValue);
            bool Return = aBookBll.GetReturnBook(aBook);
            if (Return)
            {
                messageLabel.Text = "Return Success";
            }
            else
            {
                messageLabel.Text = "Not Return";
            }
        }     
    }
}