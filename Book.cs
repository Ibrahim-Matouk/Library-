using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_S25_HW_IPG203_Library_Management_System_
{
    public class Book : Item
    {
        private int v;

        public string Author { get; set; }

        public Book(string title, string author) : base(title)
        {
            Author = author;
        }

        public Book(string title, string author, int v) : this(title, author)
        {
            this.v = v;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Book: {Title}, Author: {Author}");
        }
    }
}
