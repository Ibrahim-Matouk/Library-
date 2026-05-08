using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_S25_HW_IPG203_Library_Management_System_
{             //كلاس للتحقق من صحة البيانات
    public static class Validator
    {
        public static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }
    }
}

