using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NagarjunaConsoleApp
{
    internal class Generics
    {
        public bool AreEqual <T>(T a, T b)
        {
            if(a.Equals(b))
            {
                return true;
            }
            return false;
        }
    }
    internal class GenericTest
    {
        static void Main(string[] args)
        {
            Generics g = new Generics();
            bool res = g.AreEqual<string>("Apple", "Aple");
            bool res2 = g.AreEqual<float>(5.5f, 6.5f);
            Console.WriteLine(res);
            Console.WriteLine(res2);
        }
    }

}
