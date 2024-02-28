using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeightCalculator calc = new WeightCalculator();
            Console.WriteLine("Insert height: ");
            calc.setHeight(float.Parse(Console.ReadLine()));
            Console.WriteLine("Insert age:");
            calc.setAge(int.Parse(Console.ReadLine()));
            Console.WriteLine("Insert gender:");
            calc.setGender(Console.ReadLine());

            if(String.Equals(calc.getGender(), "male"))
            {
                calc.maleWeight();
                calc.display();
            }
            else if(String.Equals(calc.getAge(), "female"))
            {
                calc.femaleWeight();
                calc.display();
            }
            Console.ReadKey();
        }

        public class WeightCalculator
        {
            public float idealWeight;
            public float height;
            public int age;
            public String gender;

            public void setHeight(float height)
            {
                this.height = height;
            }
            
            public float getHeight()
            {
                return this.height;
            }

            public void setAge(int age)
            {
                this.age = age;
            }

            public int getAge()
            {
                return this.age;
            }

            public void setGender(String gender)
            {
                this.gender = gender;
            }

            public String getGender()
            {
                return this.gender;
            }

            public void maleWeight()
            {
                this.idealWeight = (this.height - 100 - ((this.height - 150) / 4)) + ((this.age - 20) / 4);
            }

            public void femaleWeight()
            {
                this.idealWeight = (this.height - 100 - ((this.height - 150) / 2.5f)) + ((this.age - 20) / 6);
            }

            public void display()
            {
                Console.WriteLine("Ideal weight: {0:0.00#}", this.idealWeight);
            }
        }
    }
}
