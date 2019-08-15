using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resistor_checker
{
    class Checker
    {
        

        static void Main(string[] args)
        {
            string first;
            string second;
            string multi;
            string tolerance;


            string[] FirstBand = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
            string[] SecondBand = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
            string[] Multiplier = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white", "gold", "silver" };
            for (; ; )
            {
                InputColour(out first, out second, out multi, out tolerance);

                Console.WriteLine("Your choice: " + first + " " + second + " " + multi + " " + tolerance);
                Console.Write("The resistance of this resistor is: ");
                Console.Write(Array.IndexOf(FirstBand, first));
                Console.Write(Array.IndexOf(SecondBand, second));

                int multindex = Array.IndexOf(Multiplier, multi);
                for (int index = multindex; index > 0; index--)
                {
                    Console.Write("0");
                }

                CalcTolerate(tolerance);

                Console.WriteLine(" ohms.");



                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void InputColour(out string first, out string second, out string multi, out string tolerance)
        {
            

            string[] FirstBand = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
            string[] SecondBand = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };
            string[] Multiplier = new string[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white", "gold", "silver" };
            string[] Tolerance = new string[] { "grey", "violet", "blue", "green", "brown", "red", "gold", "silver" };

            int checkfirst;
            int checksecond;
            int checkmulti;
            int checktol;
           
            do
            {

                Console.WriteLine("Colour of the first band?: ");
                first = Console.ReadLine();
                first = first.Trim();
                first = first.ToLower();
                checkfirst = Array.IndexOf(FirstBand, first);
                if (checkfirst < 0)
                {
                    Console.WriteLine("Invalid colour. Please, try again.");
                }
            } while (checkfirst < 0);

            do
            {
                Console.WriteLine("Colour of the second band?: ");
                second = Console.ReadLine();
                second = second.Trim();
                second = second.ToLower();
                checksecond = Array.IndexOf(SecondBand, second);
                if (checksecond < 0)
                {
                    Console.WriteLine("Invalid colour. Please, try again.");
                }
            } while (checksecond < 0);
            do
            {
                Console.WriteLine("Colour of the third band?: ");
                multi = Console.ReadLine();
                multi = multi.Trim();
                multi = multi.ToLower();
                checkmulti = Array.IndexOf(Multiplier, multi);
                if (checkfirst < 0)
                {
                    Console.WriteLine("Invalid colour. Please, try again.");
                }
            } while (checkmulti < 0);
            do
            {
                Console.WriteLine("Colour of the fourth band?: ");
                tolerance = Console.ReadLine();
                tolerance.Trim();
                tolerance.ToLower();
                checktol = Array.IndexOf(Tolerance, tolerance);
                if (checktol < 0)
                {
                    Console.WriteLine("Invalid colour. Please, try again.");
                }
            } while (checktol < 0);
        }
        public static void CalcTolerate(string EnteredTolerance)
        {
            string[] Tolerance = new string[] { "grey", "violet", "blue", "green", "brown", "red", "gold", "silver"};
            
            int TolIndex = Array.IndexOf(Tolerance, EnteredTolerance);

            Tolerance[0] = " +- 0,05%";
            Tolerance[1] = " +- 0,1%";
            Tolerance[2] = " +- 0,25%";
            Tolerance[3] = " +- 0,5%";
            Tolerance[4] = " +- 1%";
            Tolerance[5] = " +- 2%";
            Tolerance[6] = " +- 5%";
            Tolerance[7] = " +- 10%";

            Console.Write(Tolerance[TolIndex]);
        }
    }
}
