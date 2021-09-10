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
                        SmasungFactory samsung = neww SamsungFactory();
                    }
            }
        }
    }
}
