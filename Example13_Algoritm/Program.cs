// Рекурсия
using static System.Console;
Clear();

//double Factorial(int n)
//{//1!=1 0!=1
 //   if(n==1) return 1;
 //   else return n*Factorial(n-1);
//}
//WriteLine(Factorial(3));

//Фебоначи

//f(1)=1
//f(2)=1
//F(n)=f(n-1)+f(n-2)

double Fibonacci(int n)
{
    if(n==1||n==2) return 1;
    else return Fibonacci(n-1)+Fibonacci(n-2);
}
for (int i=1;i<40;i++)
{
    WriteLine(Fibonacci(i));

}