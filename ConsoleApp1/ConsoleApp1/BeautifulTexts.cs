using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    
    public static class BeautifulTexts
    {
        public static void PrintHelloText()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("____              ___       ___ ");
            Console.WriteLine("`Mb(      db      )d'       `MM ");
            Console.WriteLine(" YM.     ,PM.     ,P         MM     ");
            Console.WriteLine(" `Mb     d'Mb     d'  ____   MM   ____     _____  ___  __    __     ____");
            Console.WriteLine("  YM.   ,P YM.   ,P  6MMMMb  MM  6MMMMb.  6MMMMMb `MM 6MMb  6MMb   6MMMMb  ");
            Console.WriteLine("  `Mb   d' `Mb   d' 6M'  `Mb MM 6M'   Mb 6M'   `Mb MM69 `MM69 `Mb 6M'  `Mb ");
            Console.WriteLine("   YM. ,P   YM. ,P  MM    MM MM MM    `' MM     MM MM'   MM'   MM MM    MM ");
            Console.WriteLine("   `Mb d'   `Mb d'  MMMMMMMM MM MM       MM     MM MM    MM    MM MMMMMMMM ");
            Console.WriteLine("    YM,P     YM,P   MM       MM MM       MM     MM MM    MM    MM MM ");
            Console.WriteLine("    `MM'     `MM'   YM    d9 MM YM.   d9 YM.   ,M9 MM    MM    MM YM    d9 ");
            Console.WriteLine("     YP       YP     YMMMM9 _MM_ YMMMM9   YMMMMM9 _MM_  _MM_  _MM_ YMMMM9  ");
            Console.WriteLine("###########################################################################");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static int PrintMenuText()
        {
            Console.WriteLine("______________________________   M E N U   ________________________________");
            Console.WriteLine("|                                                                         |");
            Console.WriteLine("|        # 1 - Print Array On Screen ( Beautiful )                        |");
            Console.WriteLine("|        # 2 - Print Largest & Smallest Values                            |");
            Console.WriteLine("|        # 3 - Print Array -> Ascending Order                             |");
            Console.WriteLine("|        # 0 - EXIT APP                                                   |");
            Console.WriteLine("|_________________________________________________________________________|");
            Console.WriteLine();
            Console.Write("  Your Choice : ");

            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {             
                Console.Write("  Your Choice : ");

            }
            return userInput;
        }
    }
}
