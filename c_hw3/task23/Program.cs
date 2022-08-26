// Программа принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

double PrintKub()
{
Console.WriteLine("Введите число N:");
double N = Convert.ToDouble(Console.ReadLine());
if (N<0) {N=-1*N;}
for (int i=0; i < (N+1); i++)
Console.Write($" {i*i*i} ,");
return N;
}
try {PrintKub();}
catch {Console.WriteLine ("Что-то пошло не так.");}
