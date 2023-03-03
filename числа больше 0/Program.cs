/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/
Console.Clear();
Console.WriteLine("Введите ваши числа через пробел");
string elements = Console.ReadLine();
int[]array = GetArrayFromString(elements);
int count=0;
Console.WriteLine($"Количество чисел больше 0  - {CountElements(array)}");
int[] GetArrayFromString(string stringarray)
{
    string[]nums = stringarray.Split(" ",StringSplitOptions.RemoveEmptyEntries);
    int[]res = new int[nums.Length];
    for (int i =0;i<nums.Length;i++)
    {res[i]=int.Parse(nums[i]);}
    return res;
}
int CountElements(int[]array)
{
    for(int i = 0;i<array.Length;i++)
    {
        if(array[i]>0)
        {
            count++;
        }
    }
    return count;
}