// программа принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

double GetDistance()
  {
    Console.WriteLine("Для первой точки введите трехмерные координаты хуz");
        Console.Write("x1= ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y1= ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("z1= ");
        double z1 = Convert.ToDouble(Console.ReadLine());
        
    Console.WriteLine("Для второй точки введите трехмерные координаты хуz");
        Console.Write("x2= ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("y2= ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("z2= ");
        double z2 = Convert.ToDouble(Console.ReadLine());

    double Distance = Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)+(z1-z2)*(z1-z2));
    Console.WriteLine ("Расстояние между заданными точками равно ");
    return Distance;
  }
  try {Console.WriteLine(GetDistance());}
  catch {Console.WriteLine ("Нужно ввести числa, а не что-то другое");
          Console.WriteLine ("! Возможно, при вводе десятичного числа вы отделили десятичную часть точкой, а не запятой !");
        }