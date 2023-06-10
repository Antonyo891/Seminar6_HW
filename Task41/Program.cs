/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
int Enter(string query)
{
    System.Console.WriteLine(query);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int[] StringToInt(int number) //возвращает введенные числа через пробел в массив с проверкой необходимого количества чисел
{
    System.Console.WriteLine($"Введите {number} числа(-сел, -сло) через пробел");
    string line = Console.ReadLine();
    string[] ArrayString = line.Split(" ");
    while (ArrayString.Length < number || ArrayString.Length > number) // проверяет правильное количество введеннх чисел
    {
        System.Console.WriteLine($"Вы ввели неправильное количество чисел. Введите {number} числа(-сел, -сло) через пробел");
        line = Console.ReadLine();
        ArrayString = line.Split(" ");
    }
    int[] result = new int[ArrayString.Length];
    for (int i = 0; i < result.Length; i++) result[i] = int.Parse(ArrayString[i]);
    return result;
}
int number(int[] array) // считает сколько чисел больше 0 в массиве
{
    int count = 0;
    foreach (int el in array) count += el > 0 ? 1 : 0;
    return count;
}
Console.Clear();
int numbers= Enter("Сколько чисел нужно ввести?");
int [] array = StringToInt(numbers);
System.Console.WriteLine($"Среди введенных чисел {number(array)} больше 0 ");