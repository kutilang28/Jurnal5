using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_MODUL5_103022400129
{
    public class HaloGeneric
    {
        // Method SapaUser dengan generic parameter T
        public void SapaUser<T>(T input)
        {
            Console.WriteLine($"Halo user {input}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            string nama = "Fidel";
            halo.SapaUser(nama);
        }
    }
}
