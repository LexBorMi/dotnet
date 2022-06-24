Console.WriteLine("Ввидите первое число");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ввидите третье число");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b > a)
    max = b;
if (c > max)
    max = c;

Console.WriteLine("{0} наибольшее число", max);
