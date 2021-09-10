using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneTypeChecker phoneChecker = new PhoneTypeChecker(MANUFACTURERS.SAMSUNG);
            phoneChecker.CheckProducts();
        }
    }
}
