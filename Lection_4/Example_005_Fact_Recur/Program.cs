// Формула вычечления факториала
double Factorial (int n)
{
    // Ветвление факториала
    if(n == 1) return 1;
    else return n * Factorial (n-1);
}
 // цикл для вывода значения кажого факториала
for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine(Factorial(i));
}
