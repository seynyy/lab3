using System.Text;

namespace lab3
{
    class Program
    {
        static void Main(string[] args) {
            Console.OutputEncoding = Encoding.UTF8;
            //task1
            {
                Console.WriteLine("Введіть натуральне число n:");
                int n = int.Parse(Console.ReadLine());
                if (n <= 0)
                    Console.WriteLine("Не натуральне число");
                Console.WriteLine("Введіть дійсне число x:");
                double x = double.Parse(Console.ReadLine());

                double result = 0;
                int i = 1;
                while(i <= n) {
                    result += Math.Pow(x, i)/i;
                    i++;
                }
                Console.WriteLine("Відповідь: " + result);
            }

            //task2
            {
                double x = Math.PI/8;
                double e = Math.Pow(10, -4);
                
                double accuracy = 1;

                double sum = 0;
                int iteration = 1;
                double current = 0;

                do {
                    current = Math.Pow(-1, iteration)*(1/(Math.Pow(2, iteration) + iteration*x));

                    sum += current;
                    
                    accuracy = Math.Abs(current/sum);

                    iteration ++;
                }
                while (accuracy > e);

                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("Номер ітерації: " + iteration);
                Console.WriteLine("Величина поточного члену ряду: " + current);
                Console.WriteLine("Величина накопиченої суми ряду: " + sum);
                Console.WriteLine("Похибка: " + accuracy);
            }

            //task3
            {
                double x1 = 0.5d;
                double x2 = 11;
                double h = 0.3d;
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("|   x   |    sin(x)/x^2   |    cos(x)/x    |");
                Console.WriteLine("-------------------------------------------");
                for (double i = x1; i < x2; i+=h) {
                    double y1 = Math.Sin(i)/Math.Pow(i, 2); 
                    double y2 = Math.Cos(i)/i;

                    Console.WriteLine($"|{i,6:F2} |{y1,12:F6}     | {y2,10:F6}     |");
                }
                Console.WriteLine("-------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}