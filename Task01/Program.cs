//Задача: Написать программу, которая из имеющегося массива целых чисел формирует массив из четных чисел. 
//Первоначальный массив можно ввести с клавиатуры, либо сгенерировать случайным образом. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.WriteLine("Введите кол-во элементов массива:");
int count = int.Parse(Console.ReadLine());
int[] array1 = new int[count];
int[] array2 = new int[count];
Random rand = new Random();
void FillArray(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-10, 10);
    }
}
void PrintArray(int[] array, int length)
{
    for (int i = 0; i < length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
bool EvenNumbered(int num)
{
    if(num % 2 == 0) return true;
    else return false;
}
int From1To2ArrayWithIF(int[] array1, int[] array2)
{
    int counter = 0;                     
    for (int i = 0; i < array1.Length; i++)
    {
        if (EvenNumbered(array1[i]))
        {
            array2[counter] = array1[i];  
            counter++;
        }
    }
    return counter;

}
FillArray(array1);
Console.WriteLine("Начальный массив:");
PrintArray(array1, array1.Length);
int counter = From1To2ArrayWithIF(array1, array2);
if (counter == 0)
{
    Console.WriteLine("В массиве нету четных элементов!");
}
else
{
    Console.WriteLine("Массив с четными элементами:");
    PrintArray(array2, counter);
}