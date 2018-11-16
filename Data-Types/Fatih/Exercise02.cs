using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Years_In_Three_Months.Data_Types.Fatih {

    /**
        Write a C# Sharp program that takes a number and a width also a number, as input 
        and then displays a triangle of that width, using that number.
    
        Test Data
        Enter a number: 6 
        Enter the desired width: 6 
    
        Expected Output :
        666666                                                      
        66666                                                           
        6666                                                                  
        666                                                        
        66                                                                  
        6
    */

    public class Exercise02 {

        public void RunCode() {

            Console.Write("Number to Show ");
            var numToShow = Console.ReadLine();
            Console.Write("width ");
            var width = Convert.ToInt16(Console.ReadLine());

            for(int i = width; i >0; i--) { 
                for(int j = width; j > 0; j--) {

                    Console.Write(numToShow);

                }
                Console.WriteLine();
                width--;
            }
            Console.ReadKey();

        }

    }
}
