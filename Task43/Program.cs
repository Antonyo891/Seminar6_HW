//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double [] StringToInt() //возвращает введенные b и k через пробел в массив с проверкой необходимого количества чисел
{
    System.Console.WriteLine("Введите b1 k1 b2 k2 через пробел");
    string line = Console.ReadLine();
    string[] ArrayString = line.Split(" ");
    while (ArrayString.Length < 4 || ArrayString.Length > 4) // проверяет правильное количество введеннх чисел
    {
        System.Console.WriteLine($"Вы ввели неправильное количество чисел. Введите b1 k1 b2 k2 через пробел");
        line = Console.ReadLine();
        ArrayString = line.Split(" ");
    }
    double [] result = new double[ArrayString.Length];
    for (int i = 0; i < 4; i++) result[i] = double.Parse(ArrayString[i]);
    return result;
}
double [] crossing (double [] array)
{
    double [] result2 = new double [2];
    result2 [0] = (array[2]-array[0])/(array[1]-array[3]);
    result2 [1] = array[1]*result2[0]+array[0];
    return result2; 
}
Console.Clear();
System.Console.WriteLine("hi");
double [] array1 = StringToInt(); 
double [] result1 = crossing(array1);
System.Console.WriteLine($"y = {array1[1]:f2}*x + {array1[0]:f2}");
System.Console.WriteLine($"y = {array1[3]:f2}*x + {array1[2]:f2}");
System.Console.WriteLine($"точка пересечения уравнений: x = {result1[0]:f2}; y = {result1[1]:f2} ");

