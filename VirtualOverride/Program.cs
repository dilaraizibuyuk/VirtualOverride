using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Telefon tel = new Telefon();
            İkinciElTelefon ikincitel = new İkinciElTelefon();

            Console.WriteLine("Sıfır Telefon:"+tel.Fiyat());
            Console.WriteLine("İkinci el telefon:"+ikincitel.Fiyat());
            Console.ReadLine();
        }
    }
}
