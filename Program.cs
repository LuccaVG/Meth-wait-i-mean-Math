using System;
using System.Text;
using System.Threading.Tasks;

//i make da name and da class + ststic void main string and write da stuff

namespace calculator_c_sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //i made a string for the value of the equation
            string value;

            //used cmd do to make you type the first and second number while asking you to DEWIT
            do
            {
                //float result = var that gets tthe value of the equation
                float res;
                //cwl enter first number
                Console.Write("Enter first number:");
                float num1 = float.Parse(Console.ReadLine());
                //cwl enter second number
                Console.Write("Enter second number:");
                float num2 = float.Parse(Console.ReadLine());
                //cwl enter ur symbol of the equation
                Console.Write("Enter symbol(/,+,-,*):");
                string symbol = Console.ReadLine();
 
//i make da symbol stuff in a switch case command so u type da symbol to select it and do da meth wait no i mean mathematics
                
                switch (symbol)
                {
                    //you choose + symbol i add yes yes
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("Addition:" + res);
                        break;
                    //you choose to make a subtraction good
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtraction:" + res);
                        break;
                    //you make multiplication very good
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication:" + res);
                        break;
                    //you also dont like dividing ik
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division:" + res);
                        break;
                    //you fuck up that very wrong
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }

                Console.ReadLine();
                //do you want make more meth i mean math
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value=="y" || value=="Y");//this is value tbh i don`t really remember half the stuff i did at this point(ADHD says hello)
        }
    } 
}

//above i ask u if go again yes yes