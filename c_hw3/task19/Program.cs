// Программа принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

string GetPalindrom()
  {
    Console.WriteLine("Введите пятизначное число:");
    int x = int.Parse(Console.ReadLine());
    int a = x/10000;
    int c = x/1000;
    int d = x/10;
    string res = "";
    if (a%10>0 && a<10)
     {
        if (a%10 == x%10) 
        {
            if (c%10 == d%10) res = "-> палиндром"; 
            else {res = " -> не является палиндромом";}
        }
        else {res = " -> не является палиндромом";}
    }
    else {res = " -> введено НЕ пятизначное число";}
    return res;
  }
try {Console.Write (GetPalindrom());}
catch {Console.WriteLine ("нужно ввести хотя бы целое число, а не что-то другое");}