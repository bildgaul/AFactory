using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    enum MANUFACTURERS { SAMSUNG, HTC, NOKIA };
    class PhoneTypeChecker
    {
        public MANUFACTURERS manu;
        public IPhoneFactory factory;

        public PhoneTypeChecker(MANUFACTURERS m)
        {
            manu = m;
        }

        public void CheckProducts()
        {
            switch (manu)
            {
                case MANUFACTURERS.SAMSUNG:
                    {
                        SamsungFactory samsung = new SamsungFactory();
                        Console.WriteLine(samsung.GetISmart());
                        Console.WriteLine(samsung.GetIDumb());
                        break;
                    }
                case MANUFACTURERS.HTC:
                    {
                        HTCFactory htc = new HTCFactory();
                        Console.WriteLine(htc.GetISmart());
                        Console.WriteLine(htc.GetIDumb());
                        break;
                    }
                case MANUFACTURERS.NOKIA:
                    {
                        NokiaFactory nokia = new NokiaFactory();
                        Console.WriteLine(nokia.GetISmart());
                        Console.WriteLine(nokia.GetIDumb());
                        break;
                    }
            }
        }
    }
}
