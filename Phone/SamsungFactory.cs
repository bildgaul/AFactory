using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class SamsungFactory : IPhoneFactory
    {
        public ISmart GetISmart()
        {
            return new GalaxyS2();
        }
        
        public IDumb GetIDumb()
        {
            return new Genie();
        }
    }
}
