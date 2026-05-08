using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_S25_HW_IPG203_Library_Management_System_
{        //كلاس مجلة
    public class Magazine : Item
    {
        public int IssueNumber { get; set; }

        public Magazine(string title, int issue) : base(title)
        {
            IssueNumber = issue;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Magazine: {Title}, Issue: {IssueNumber}");
        }
    }
}

