using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand.UI
{
    public static class Animations
    {
        public static void DisplayStartScreen()
        {
            Console.WriteLine(@"      Welcome to");
            Console.WriteLine(@"    Lemonade Stand!!");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write(@"         ___
     .-''   ''-.
   .'           '.
 _/   . -  ;  - . \_
(   ' `-._|_,'_,.-  )
  ',,.--_,|' -; _ ,'
    '-.;   \ _.-'
        '''''                 ");
            Console.WriteLine("\n\nPress enter to begin");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
