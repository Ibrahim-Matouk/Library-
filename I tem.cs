using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_S25_HW_IPG203_Library_Management_System_
{       //كلاس مجرد يمثل عنصر عام في المكتبة
    public abstract class Item : IBorrowable
    {
        private static int counter = 0;

        public int Id { get; }
        public string Title { get; private set; }

        public Item(string title)
        {
            Id = ++counter;
            Title = title;
        }
        //دالة مجردة لعرض المعلومات 
        public abstract void DisplayInfo();

        public virtual void Borrow() //استعارة العنصر 
        {
            Console.WriteLine($"{Title} has been borrowed.");
        }

        public virtual void Return() // ارجاع العنصر
        {
            Console.WriteLine($"{Title} has been returned.");
        }
    }
}
