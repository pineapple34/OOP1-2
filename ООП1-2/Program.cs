using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ООП1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Abonent abonent1 = new Abonent();
            Console.WriteLine("Заполните информацию об абоненте:");
            Console.WriteLine("Идентификационный номер - "); abonent1.ID = int.Parse(Console.ReadLine());
            Console.WriteLine("ФИО - "); abonent1.Names = Console.ReadLine().Split(' ');
            Console.WriteLine("Номер карты - "); abonent1.CardNum = Console.ReadLine();
            Console.WriteLine("Время городских разговоров - "); abonent1.InCityCallsTime = Console.ReadLine();
            Console.WriteLine("Время междугородних разговоров - "); abonent1.OutCitiesCallsTime = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Абонент 1:");
            Console.WriteLine("Идентификационный номер - " + abonent1.ID);
            Console.WriteLine("ФИО - {0} {1} {2}", abonent1.Names[0], abonent1.Names[1], abonent1.Names[2]);
            Console.WriteLine("Номер карты - " + abonent1.CardNum);
            Console.WriteLine("Время городских разговоров - " + abonent1.InCityCallsTime);
            Console.WriteLine("Время междугородних разговоров - " + abonent1.OutCitiesCallsTime);

            Console.ReadKey();
        }
    }

    class Abonent
    {
        public int ID;
        public string[] Names;
        public string CardNum, InCityCallsTime, OutCitiesCallsTime;
    }
}
