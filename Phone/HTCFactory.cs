using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class HTCFactory : IPhoneFactory
    {
        public ISmart GetISmart()
        {
            return new Titan();
        }

        public IDumb GetIDumb()
        {
            return new Primo();
        }
    }
}
