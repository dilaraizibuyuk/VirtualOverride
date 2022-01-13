using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    class İkinciElTelefon:Telefon
    {
       
        public override double Fiyat()
        {
            return alisfiyat - 400;
        }
    }
}
