using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcLib;

namespace BasicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Day 1");

            //string input1 = Console.ReadLine();
            //string input2 = Console.ReadLine();

            //int value1 = Convert.ToInt32(input1);
            //int value2 = Convert.ToInt32(input2);

            //int sum = value1 + value2;

            int asci = Console.Read();
            Console.WriteLine(asci);
            Console.WriteLine(Convert.ToChar(asci));

            //if(sum % 2>0)
            //{
            //    Console.WriteLine("Its Odd");
            //}
            //else
            //{
            //    Console.WriteLine("Its Even");
            //}



            //1. Simple Interest calc
            //2 Data type convertion srting - double -float/dec
            //Cons. 20.20
            //Cons.reAD FLOAT/DEC

            // Value type
            int cou, cout2;

            decimal dc1;
            float dc2;
            cou = 10;
            cout2 = 100;

            int count = 10000000;
            short sCount = 32765;
            long lCount =1000000000000000000;

            long temp = cou + sCount;
            temp = sCount;

            //Float - 32 bit(7 digits)
            //Double - 64 bit(15 - 16 digits)
            //Decimal - 128 bit(28 - 29 significant digits)
            string output = Console.ReadLine();
            if (output == "d")
            {
                double cost = Convert.ToDouble(123);
            } 
            else if (output == "f")
            {
                float cost = (float)Convert.ToDecimal(123);
            }
            float fCost = 10.2110f;
            decimal dCost = Convert.ToDecimal(fCost);
            //decimal output = dCost / lCount;
            
            DateTime currentDate = DateTime.Now;


            //String to Date
            String sampleCha = Console.ReadLine();
            int sampleCha1 = Console.Read();
            int sampleCha2 = Console.Read();
            
            string sampleString = "Hello";
            //
            for(int coun=0; coun < sampleString.Length; coun++)
            {
                Console.WriteLine(sampleString[coun]);
            }
            Console.WriteLine("------------");
            for (int coun = sampleString.Length-1; coun >=0; coun--)
            {
                Console.Write(sampleString[coun]);
            }
            Console.WriteLine("------------");


            string sampleDate = "05/05/2005";

            //Datetime
            DateTime tempDate = Convert.ToDateTime(sampleDate);
            Console.WriteLine(tempDate);
            tempDate = DateTime.Now;
            Console.WriteLine(tempDate);
            

            //Interst Amount Calcu
            //Input Loan Amount and Interest Rate

            //Data Type Convertion of double to decimial/float

            //String
            //Check given string is palindrome or not

            CalcLib.Calc calObj = new Calc();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(calObj.Add(2, 3));
            Console.ReadLine();

        }
    }
}
