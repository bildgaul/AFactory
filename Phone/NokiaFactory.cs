using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone
{
    class NokiaFactory : IPhoneFactory
    {
        public ISmart GetISmart()
        {
            return new Lumia();
        }
        
        public IDumb GetIDumb()
        {
            return new Asha();
        }
    }
}
