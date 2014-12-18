using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PLManagementApp.DLL.DAO
{
    public class Book
    {
        public Book()
        {
            Member = new Member();
        }

        public int BookId { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string BookPublisher { get; set; }
        public Member Member { get; set; }

    }
}