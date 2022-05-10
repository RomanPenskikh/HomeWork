/* Написать программу, которая . из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа.*/
string[] array = new string[4];

void FillArray(string[] collection)
{
    int length = collection.Length;
    for (int index = 0; index < length; index++)
    {
        Console.WriteLine("Задайте данные для массива");
        collection[index] = Convert.ToString(Console.ReadLine());
    }
}
