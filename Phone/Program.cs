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
            PhoneTypeChecker samsungChecker = new PhoneTypeChecker(MANUFACTURERS.SAMSUNG);
            samsungChecker.CheckProducts();

            PhoneTypeChecker htcChecker = new PhoneTypeChecker(MANUFACTURERS.HTC);
            htcChecker.CheckProducts();

            PhoneTypeChecker nokiaChecker = new PhoneTypeChecker(MANUFACTURERS.NOKIA);
            nokiaChecker.CheckProducts();
        }
    }
}
