using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Years_In_Three_Months.Data_Types.Fatih {

    /**
        Write a C# Sharp program that takes userid and password as input (type string). 
        After 3 wrong attempts, user will be rejected.
     */

    class Exercise03 {

        public void RunCode() {

            string userID = "name", password = "tryTohack";
            int failtAttempts = 0;

            while (failtAttempts < 3) {
                Console.WriteLine(failtAttempts);
                Console.Write("User ID ");
                string id = Console.ReadLine();
                Console.Write("Password ");
                string pass = Console.ReadLine();

                if ((!userID.Equals(id) || !password.Equals(pass)) && failtAttempts < 2 ) {
                    failtAttempts++;
                } else if( userID.Equals(id) && password.Equals(pass) ) {
                    Console.Write("Log in succesful");
                    failtAttempts = 0;
                    Console.ReadKey();
                    return;
                } else {
                    Console.Write("You are blocked");
                    Console.ReadKey();
                    return;
                }

            }
        }

        private void Main(string[] args) {
            // Implement code here
        }
    }
}
