using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_S25_HW_IPG203_Library_Management_System_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // لتجنب مشاكل اللغة
            Console.OutputEncoding = System.Text.Encoding.UTF8;
             Console.WriteLine("══════════════════════════════════════════");
            Console.WriteLine(" Welcome to the library management system    ");
            Console.WriteLine("══════════════════════════════════════════");
            Library lib = new Library();

           // ربط الحدث
            lib.OnItemBorrowed += (msg) =>
            {
                Console.WriteLine("EVENT: " + msg);
            };

            // إنشاء كتب (إنكليزي لتجنب مشاكل العرض)
            Book b1 = new Book("CSharp Basics", "Osama Deeb", 30);
            Book b2 = new Book("C Language Guide", "Khalil Onis", 40);
            Book b3 = new Book("OOP Programming", "Abdelbari Dawood", 25);

            // إضافة الكتب
            lib.AddItem(b1);
            lib.AddItem(b2);
            lib.AddItem(b3);

            // عرض العناصر
            lib.ShowAllItems();

            // استعارة كتاب
            lib.BorrowItem(b1);

            Console.ReadLine();
        }
    }
}

                
              
