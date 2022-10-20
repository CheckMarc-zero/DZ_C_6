Console.WriteLine("Введите через пробел ваш набор чисел:");
int [] needMassiv = GetArrayFromString (Console.ReadLine());

int result = plusNumbersCount(needMassiv);

Console.WriteLine($"Число положительных членов массива: {result}");


//Перевод строкового массива в числовой
int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

//Определение колличества положительных членов массива
int plusNumbersCount (int [] mass)
{
    int count = 0;
    for ( int i = 0; i < mass.Length; i++) if (mass[i]>0) count++;
    return count;    
}