using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TemperatureConverter converter = new TemperatureConverter();
            Console.WriteLine("Insert temperature:");
            converter.setTemp(float.Parse(Console.ReadLine()));
            Console.WriteLine("Insert temperature type C/F:");
            converter.setType(Console.ReadLine()[0]);
            if(converter.getType() == 'F')
            {
                Console.WriteLine("Temperature in Celsius is: {0:0.00#}", converter.toCelsius());
            }
            else if(converter.getType() == 'C')
            {
                Console.WriteLine("Temperature in Fahrenheit is: {0:0.00#}", converter.toFahrenheit());
            }
            Console.ReadKey();
        }
    }

    public class TemperatureConverter
    {
        public float temp = 0.0f;
        public char type;

        public void setTemp(float temp)
        {
            this.temp = temp;
        }

        public float getTemp()
        {
            return this.temp;
        }

        public void setType(char type)
        {
            this.type = type;
        }

        public char getType()
        {
            return this.type;
        }

        public float toFahrenheit()
        {
            return (temp * 9 / 5) + 32;
        }

        public float toCelsius()
        {
            return (temp - 32) * 5 / 9;
        }
    }
}
