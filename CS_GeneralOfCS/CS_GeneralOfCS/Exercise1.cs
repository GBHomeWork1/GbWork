using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CS_GeneralOfCS
{
    class Exercise1
    {
        void Main(string[] args)
        {
            
            
            //Анкета
            /*Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();
            Console.Write("Введите свою фамилию: ");
            string firstname = Console.ReadLine();
            Console.Write("Введите свой возраст: ");
            string year = Console.ReadLine();
            Console.Write("Введите свой рост в метрах: ");
            string height = Console.ReadLine();
            Console.Write("Введите свой вес: ");
            string weight = Console.ReadLine();
            Console.Write("Введите свой город проживания: ");
            string city = Console.ReadLine();
            Console.WriteLine("Name: " + name + " Firstname: " + firstname + " Year: " + year + " Height: " + height + " Weight: " + weight);
            Console.WriteLine("Name: {0}, Firstname: {1}, Year: {2}, Height: {3}, Weight: {4}.", name, firstname, year, height, weight);
            Console.WriteLine($"Name: {name}, Firstname: {firstname}, Year: {year}, Height: {height}, Weight: {weight}. ");
            double intweight = double.Parse(weight);
            double intheight = double.Parse(height);
           
            if(intheight > 4)
            {
                var x= intheight / 100;
                double index = intweight / (x * x);
                Console.WriteLine($"Индекс массы составляет: {Math.Round(index,2)}");
            }
            else
            {
                double index1 = intweight / Math.Pow(intheight, 2);
                Console.WriteLine($"Индекс массы составляет: {Math.Round(index1, 2)}");
                
            }

            ClassOfMethod.Print($"Имя: {name} , Фамилия: {firstname}, Город: {city} ", 50, 10);

            ClassOfMethod.Pause();*/
            
            #region lenght 
            //Расстояние
            /*
            Console.WriteLine("Введите первую координату x: ");
            string strx1 = Console.ReadLine();
            double x1 = double.Parse(strx1);
            Console.WriteLine("Введите первую координату y: ");
            string stry1 = Console.ReadLine();
            double y1 = double.Parse(stry1);
            Console.WriteLine("Введите вторую координату x: ");
            string strx2 = Console.ReadLine();
            double x2 = double.Parse(strx2);
            Console.WriteLine("Введите вторую координату y: ");
            string stry2 = Console.ReadLine();
            double y2 = double.Parse(stry1);
            Console.WriteLine("Расстояние между двумя точками равна:" + Math.Round(Lenght(x1, y1, x2, y2), 3));
            Console.ReadKey();
            */
            #endregion
            #region convert
            //Обмен значении  
            /*
            Console.Write("Введите первое число: ");
            string strnumber1 = Console.ReadLine();
            double number1 = Convert.ToDouble(strnumber1);
            Console.Write("Введите второе число: ");
            string strnumber2 = Console.ReadLine();
            double number2 = Convert.ToDouble(strnumber2);
            Console.WriteLine($"Первое число: {number1}, а второе: {number2}");
            Console.ReadKey();
            //С 3 переменной
            double a = 0;
            a = number1;
            number1 = number2;
            number2 = a;
            // Без 3 переменной
            
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            
            
            Console.WriteLine($"Первое число: {number1}, а второе: {number2}");
            Console.ReadKey();*/
            #endregion
            

        }

        static double Lenght(double x1, double y1, double x2, double y2)
        {
            
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }


        
    }
}
