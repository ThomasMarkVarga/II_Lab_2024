using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MeanCAlculator calc = new MeanCAlculator();

            int noOfNo = 0;
            Console.WriteLine("How many numbers do you want to insert?");
            noOfNo = int.Parse(Console.ReadLine());

            int[] array = new int[noOfNo];
            Console.WriteLine("Insert {0:0} numbers, each number should pe followed by ENTER:", noOfNo);
            for(int i = 0; i < noOfNo; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            calc.setNumberArray(array);
            calc.arithmetic();
            calc.geometrical();
            calc.display();

            Console.ReadKey();
        }
    }
    public class MeanCAlculator
    {
        int[] numberArray;

        float arMean = 0.0f;
        float geoMean = 1.0f;

        public void setNumberArray(int[] numberArray)
        {
            this.numberArray = new int[numberArray.Length];
            this.numberArray = numberArray;
        }

        public void arithmetic()
        {
            for (int i = 0; i < this.numberArray.Length; i++)
            {
                this.arMean += this.numberArray[i];
            }

            this.arMean /= this.numberArray.Length;
        }

        public void geometrical()
        {
            for (int i = 0; i < this.numberArray.Length; i++)
            {
                this.geoMean *= this.numberArray[i];
            }

            this.geoMean = (float)Math.Pow(geoMean, 1.0f / this.numberArray.Length);
        }

        public void display()
        {
            Console.WriteLine("Arithmetical Mean: {0:0.0#}", arMean);
            Console.WriteLine("Geometrical Mean: {0:0.0#}", geoMean);
        }
    }
}


