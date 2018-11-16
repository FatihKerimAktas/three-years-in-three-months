using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Years_In_Three_Months.Data_Types.Fatih {

    /**
        Write a C# Sharp program that takes three letters as input and display them in reverse order.
        
        Test Data
        Enter letter: b 
        Enter letter: a
        Enter letter: t
        
        Expected Output :
        t a b
    */

    class Exercise01 {

        public void RunCode() {

            Console.Write("Letter 1 ");
            var letter1 = Console.ReadLine();
            Console.Write("Letter 2 ");
            var letter2 = Console.ReadLine();
            Console.Write("Letter 3 ");
            var letter3 = Console.ReadLine();

            var allChars = letter1 + letter2 + letter3;

            Console.WriteLine(String.Concat(allChars.OrderBy(c => c)));

            Console.ReadKey();

        }

    }


}
