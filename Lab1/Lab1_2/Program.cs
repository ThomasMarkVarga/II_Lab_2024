using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Lab1_2
    {
        static void Main(String[] args)
        {
            float a = 0.0f;
            float b = 0.0f;
            char operation;

            Console.WriteLine("Insert 2 numers:");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            Console.WriteLine(a + " " + b);

            Console.WriteLine("Enter operation:");
            operation = Console.ReadLine()[0];
            Console.WriteLine("Operation choosen: " + operation);

            Calculator result = new Calculator(a, b);

            switch (operation)
            {
                case '+':
                    result.add();
                    result.display();
                    break;
                case '-':
                    result.substract();
                    result.display();
                    break;
                case '*':
                    result.multiply();
                    result.display();
                    break;
                case '/':
                    result.divide();
                    result.display();
                    break;
                default:
                    Console.WriteLine("Error! Unrecognized operation!");
                    break;
            }

            Console.ReadKey();
        }

        class Calcuslator
        {
            float a = 0;
            float b = 0;
            float result = 0;

            public Calculator(float a, float b)
            {
                this.a = a;
                this.b = b;
            }

            public void add()
            {
                this.result = this.a + this.b;
            }

            public void substract()
            {
                this.result = this.a - this.b;
            }

            public void multiply()
            {
                this.result = this.a * this.b;
            }

            public void divide()
            {
                this.result = this.a / this.b;
            }

            public void display()
            {
                Console.WriteLine("The result of the operation is: " + result);
            }
        }
    }
}
