using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_S25_HW_IPG203_Library_Management_System_
{
    // للحدثDelegate
    public delegate void ItemAction(string message);

    public class Library
    {
        public List<Item> Items = new List<Item>();
        public List<Member> Members = new List<Member>();

        //عند الاستعارة Event
        public event ItemAction OnItemBorrowed;

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void AddMember(Member member)
        {
            Members.Add(member);
        }

        public void BorrowItem(Item item)
        {
            item.Borrow();

            // تشغيل الحدث
            OnItemBorrowed?.Invoke($"{item.Title} was borrowed!");
        }

        public void ShowAllItems()
        {
            foreach (var item in Items)
            {
                item.DisplayInfo();
            }
        }
    }
}

