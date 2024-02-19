string[] array = new string[] {"Hello", "2", "world", ":-)"};// Задаем массив

int size (string[] arr) // Функция определения размере нового массива
{
    int s = 0;
    for(int i = 0; i < array.Length; i++)
    {
    if(array[i].Length<=3)
        s += 1;
    }
    return s;
}
void NewArray(string[] arr) // Создаем новый массив и выводим
{
    string[] NewArr = new string[size(arr)];
    int j = 0;
    for(int i = 0; i < arr.Length; i++)
    {
    if(arr[i].Length<=3)
    {
        NewArr[j] = arr[i];
        Console.Write($"{NewArr[j]} ");
    }
    }
}
NewArray(array);
