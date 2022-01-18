using System;
using System.Collections.Generic;
namespace Delegate 
{
    
    internal class Program
    {
       //define delegate
        public delegate int Additionn(int x,int y);

        static void Main(string[] args)
        {
            Option opt = new Option();
            Delegatee dege = new Delegatee();

            Console.WriteLine("Enter number 1 for calculation");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second Number for Calculation");
            int B = Convert.ToInt32(Console.ReadLine());

            //delegate of same signature && method as paramatere
            Additionn add = new Additionn(dege.AddNumber);
            Additionn sub = new Additionn(dege.Subtraction);
            Additionn div = new Additionn(dege.Division);
            Additionn mul = new Additionn(dege.Multiplication);

            bool Value = false;
            while(!Value)
            
            {
                opt.Optionss();
                int Choice = Convert.ToInt32(Console.ReadLine());

                #region Switch
                switch(Choice)
                
                {
                    case 1:

                        Console.WriteLine($"THe result of addition is {add(A,B)}");
                        Console.WriteLine("---------------------");
                        break;

                    case 2:

                        Console.WriteLine($"The result of subtraction is {sub(A,B)}");
                        Console.WriteLine("---------------------");
                        break;

                    case 3:

                        Console.WriteLine($"The result of multiplication is {mul(A,B)}");
                        Console.WriteLine("---------------------");
                        break;
                    
                    case 4:

                        Console.WriteLine($"The result division is {div(A,B)}");
                        Console.WriteLine("---------------------");
                        break;

                    case 5:

                        Console.WriteLine("press 5 again to exit");
                        if(Convert.ToInt32(Console.ReadLine())==5)
                        {
                            Value=true;
                        }
                        else{
                            Value=false;
                        }
                        break;
                    
                    case 6:
                        Console.WriteLine("Nothing enter number properly from option given above");
                        break;
                }
                 #endregion
            }
        } 
    }
     
}