using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_4_Assignment
{
    internal interface IUserPermission
    {
        void BorrowBook(int bookId);
        void ReserveBook(int bookId);
        void AddBook(int bookId, string bookTitle);
        void RemoveBook(int bookId);
    }
}
