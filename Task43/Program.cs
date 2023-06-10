//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
int[] StringToInt() //возвращает введенные b и k через пробел в массив с проверкой необходимого количества чисел
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
    int[] result = new int[ArrayString.Length];
    for (int i = 0; i < 4; i++) result[i] = int.Parse(ArrayString[i]);
    return result;
}
int [] crossing (int [] array)
{
    int [] result2 = new int [2];
    result2 [1] = (array[3]-array[1])/(array[2]-array[4]);
    result2 [2] = array[2]*result2[1]+array[1];
    return result2; 
}
Console.ReadLine();
System.Console.WriteLine("hi");
int [] array1 = StringToInt(); 
int [] result1 = crossing(array1);
System.Console.WriteLine($"y = {array1[2]}*x + {array1[1]}");
System.Console.WriteLine($"y = {array1[4]}*x + {array1[3]}");
System.Console.WriteLine($"точка пересечения уравнений: x = {result1[1]}; y = {result1[2]} ");

