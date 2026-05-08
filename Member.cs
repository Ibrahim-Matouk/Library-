using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_S25_HW_IPG203_Library_Management_System_
{
    public class Member // كلاس يمثل المستخدم 
    {
        public string Name { get; private set; }

        public Member(string name)
        {
            if (!Validator.IsValidName(name))
                throw new Exception("Invalid Name");

            Name = name;
        }
    }
}
