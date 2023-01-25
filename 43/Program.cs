//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();
String [] arrayName = {"k1", "b1", "k2", "b2"};
double[] arrayData = new double[arrayName.Length];

for (int i=0; i< arrayName.Length; i++ ){
Console.WriteLine($"Введите коэффициент {arrayName[i]}: ");
    arrayData[i]= Convert.ToInt32(Console.ReadLine());
}

 double   x = (arrayData[3]-arrayData[1])/(arrayData[0]-arrayData[2]);
 double   y = arrayData[0] * x +arrayData[1];

Console.WriteLine($"Введите коэффициент ({x}; {y}) ");