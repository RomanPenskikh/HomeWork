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
void PrintArray(string[] col)
{
    int count = col.Length;
    for (int position = 0; position < count; position++)
    {
        if (col[position].Length <= 3)
        {
            Console.WriteLine($" " + col[position]);
        }
    }
}
FillArray(array);
PrintArray(array);