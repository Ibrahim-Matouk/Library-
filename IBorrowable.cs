using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIC_S25_HW_IPG203_Library_Management_System_
{
  
    //واجهة للاستعارة والارجاع 
        public interface IBorrowable
        {   void Borrow();
            void Return();
        } 
    }

