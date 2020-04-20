using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9
{
    class Program
    {//Converts a binary to hexadecimal
        static void Main(string[] args)
        {
            string binary = "";

            Console.Write("Enter a binary number: ");
            binary = Console.ReadLine();

            char[] b = new char [binary.Length];
            b = binary.ToCharArray();

            int init = 0;
            string fourDigit = "";
            while(init < b.Length - 3)
            {
                for (int i = init; i < init + 4; i++)
                {
                    fourDigit = fourDigit + b[i];
                }
                init = init + 4;
                char character = ' ';
                switch(fourDigit)
                {
                    case "0000":
                        character = '0';
                        break;
                    case "0001":
                        character = '1';
                        break;
                    case "0010":
                        character = '2';
                        break;
                    case "0011":
                        character = '3';
                        break;
                    case "0100":
                        character = '4';
                        break;
                    case "0101":
                        character = '5';
                        break;
                    case "0110":
                        character = '6';
                        break;
                    case "0111":
                        character = '7';
                        break;
                    case "1000":
                        character = '8';
                        break;
                    case "1001":
                        character = '9';
                        break;
                    case "1010":
                        character = 'A';
                        break;
                    case "1011":
                        character = 'B';
                        break;
                    case "1100":
                        character = 'C';
                        break;
                    case "1101":
                        character = 'D';
                        break;
                    case "1110":
                        character = 'E';
                        break;
                    default: 
                        character = 'F';
                        break;
                }
                Console.Write("{0}",character);
                fourDigit = "";
            }

            Console.ReadKey();
            
        
        }
    }
}
