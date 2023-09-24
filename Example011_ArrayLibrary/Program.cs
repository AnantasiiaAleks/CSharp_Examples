void FillArray(int[] collection) //метод заполнения массива
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10); //положить
        // в массив новое случайное число из диапазона
        // от 1 до 10
        index++;
    }
}
void PrintArray(int[] col) //метод чтобы массив распечатать
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 1);
Console.WriteLine(pos);