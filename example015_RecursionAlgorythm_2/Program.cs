//..................Basic Factorial
// 5!=5*4*3*2*1

// double Factorial(int n)
// {
//     if (n == 1) return 1;
//     else return n * Factorial(n - 1);
// }
// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

//..................Fibonacci sequence
// f(n)=f(n-1) + f(n-2)

double F(int n)
{
    if (n == 1 || n ==2) return 1;
    else return F(n-1) + F(n-2);
}
for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f({i}) = {F(i)}");
}