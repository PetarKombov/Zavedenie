namespace Petur_Zavedenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolko gosti ? ");
            int gosti = int.Parse(Console.ReadLine());

            Console.Write("Masa za pushachi ili ne pushachi?");
            string pushaci = (Console.ReadLine());
            //vuprosi za gostite


            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");


            for (int i = 0; i < 1; i++)
            {
                Console.Write("Колко Салати?");
                int salati = int.Parse(Console.ReadLine());
                Console.Write("Колко овчарски салати");
                int ovcharski = int.Parse(Console.ReadLine());
                Console.Write("Колко троший ");
                int troshiq = int.Parse(Console.ReadLine());
                Console.Write("Колко млечни салати");
                int mlecni = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");

            
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Колко основни ястия?");
                int osnvni = int.Parse(Console.ReadLine());
                Console.Write("Колко кебапчета");
                int ovcharski = int.Parse(Console.ReadLine());
                Console.Write("Колко кюфтета ");
                int kebap4eta = int.Parse(Console.ReadLine());
                Console.Write("Колко Пържени картофи");
                int Kartof = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");

            Console.Write("Колко напитки?");
            int drink = int.Parse(Console.ReadLine());
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Колко Топли напитки?");
                int toplinapitki = int.Parse(Console.ReadLine());
                Console.WriteLine("Колко Студени напитки?");
                int stydeninapitkii = int.Parse(Console.ReadLine());
                if  (toplinapitki >0)
                {
                    Console.Write("Колко Ракий");
                    int rakij = int.Parse(Console.ReadLine());
                    Console.Write("Колко Кафета  ");
                    int kafe = int.Parse(Console.ReadLine());
                    Console.Write("Колко чайове? ");
                    int chai = int.Parse(Console.ReadLine());
                }
                else
                {

                }
                if(stydeninapitkii> 0)
                {
                    Console.Write("Колко Кока Коли  ");
                    int kola = int.Parse(Console.ReadLine());
                    Console.Write("Колко Води ");
                    int vodi = int.Parse(Console.ReadLine());
                    Console.Write("Колко Бири  ");
                    int bira = int.Parse(Console.ReadLine());
                }
                else
                {

                }
                
            }

            Console.WriteLine("");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Колко Десерти?");
            int deserti = int.Parse(Console.ReadLine());
            for (int i = 0; i < 1; i++)
            {

                Console.Write("Колко Торти");
                int Torta = int.Parse(Console.ReadLine());
                Console.Write("Колко Сладоледи ");
                int sladoled = int.Parse(Console.ReadLine());
                Console.Write("Колко Крем карамели");
                int kremkaramel = int.Parse(Console.ReadLine());
            }

        }
    }
}