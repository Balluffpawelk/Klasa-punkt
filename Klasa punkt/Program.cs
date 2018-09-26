using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasa_punkt
{
    class Program
    {
        public class Punkt
        {
            public int x;
            public int y;
            public void Wyswietl()
            {
                Console.WriteLine("Aktualne współrzędne punktu: x = {0}, y={1}", x, y);
                Console.ReadKey();
            }

        }

            static void Main(string[] args)
        {
            string Aa;
            string Bb;
            string oper;
            int przesun = 0;
            int ile = 0;
            string ile_s;
            
            Punkt start1 = new Punkt();

            Console.WriteLine("Podaj współrzędną x: \n" );
            Aa = Console.ReadLine();
            start1.x = Int32.Parse(Aa);
         
            Console.WriteLine("Podaj współrzędną y: \n");
            Bb = Console.ReadLine();
            start1.y = Int32.Parse(Bb);
            start1.Wyswietl();

            Console.WriteLine("Czy chcesz przesunąć punkt?\n 0- Nie \n 1- W górę\n 2- W dół\n 3- W lewo\n 4- W prawo\n");
            oper = Console.ReadLine();
            przesun = Int32.Parse(oper);
            
            if (przesun>0)
            {
                    Console.WriteLine("O ile chcesz przesunąć punkt\n");
                    ile_s = Console.ReadLine();
                    ile = Int32.Parse(ile_s);
            }
            


            switch (przesun)
            {
                case 0:
                    Console.WriteLine("Współrzędne pozostają bez zmian.\n");
                    break;

                case 1:
                    start1.y = start1.y + ile;
                    break;
                case 2:
                    start1.y = start1.y - ile;
                    break;
                case 3:
                    start1.x = start1.x - ile;
                    break;
                case 4:
                    start1.x = start1.x + ile;
                    break;

            }
            start1.Wyswietl();

        }
    }


    

    
}
