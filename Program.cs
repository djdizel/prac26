using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICUM26
{
    internal class Program
    {
        static void Main(string[] args)
        {   //Экземпляры классов
            Avto avto1 = new Avto("Пижо",1999);
            Avto avto2 = new Avto("БМВ",2007);
            Avto avto3 = new Avto("Москвич",1998);
            Avto avto4 = new Avto("ahg",1999);

            Console.WriteLine(avto1.Name,avto1.Release_date);
            Console.WriteLine(avto2.Name, avto2.Release_date);
            Console.WriteLine(avto3.Name, avto3.Release_date);

            Console.WriteLine(Avto.summary);

            Console.ReadLine();
        }
    }
}
