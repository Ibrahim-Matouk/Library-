using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_S25_HW_IPG203_Library_Management_System_
{
   
    public class EBook : Item //كلاس كتاب الكتروني
    {
        public double FileSize { get; set; }

        public EBook(string title, double size) : base(title)
        {
            FileSize = size;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"EBook: {Title}, Size: {FileSize} MB");
        }
    }
}

