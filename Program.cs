namespace lab3
{
    class Program
    {
        static void Main(string[] args) {
            //task1
            {
                Console.WriteLine("Введіть ціле число n:");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine("Введіть натуральне число x:");
                double x = double.Parse(Console.ReadLine());
                double result = 1;
                for (int i = 1; i < n; i++) {
                    result += Math.Pow(x, i)/i;
                }
                Console.WriteLine("Відповідь: " + result);
            }

            //task2
            {
                int k = 7;
                double x = Math.PI/8;
                double e = 0.0001;
                


                double sum = 0;

                for (int i = 0; i < k; i++) {
                    double current = Math.Pow(-1, i)*1/(Math.Pow(2, i) + i*x);
                    
                    sum += current;

                    double accuracy = current/sum;

                    Console.WriteLine("-------------------------------------------");
                    Console.WriteLine("Номер ітерації: " + i);
                    Console.WriteLine("Величина поточного члену ряду: " + current);
                    Console.WriteLine("Величина накопиченої суми ряду: " + sum);
                    Console.WriteLine("Похибка: " + accuracy);

                }
            }

            //task3
            {
                double x1 = 0.5d;
                double x2 = 11;

                double h = 0.3d;
                Console.WriteLine("-------------------------------------------");
                Console.WriteLine("|   x   |    sin(x)/x^2   |    cos(x)/x   |");
                Console.WriteLine("-------------------------------------------");
                for (double i = x1; i < x2; i+=h) {
                    double y1 = Math.Sin(i)/Math.Pow(i, 2); 
                    double y2 = Math.Cos(i)/i;

                    Console.WriteLine("|  " + Math.Round(i, 2) + "    " + y1 + "     " + y2 + "   |");
                }
                Console.WriteLine("-------------------------------------------");
            }
        }
    }
}