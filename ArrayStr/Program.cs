Console.WriteLine("Введите значение:");
var a = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введите значение:");
var b = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введите значение:");
var c = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введите значение:");
var d = Convert.ToString(Console.ReadLine());
Console.WriteLine("Введите значение:");
var e = Convert.ToString(Console.ReadLine());
string[] array = new string[5];
array[0] = a;
array[1] = b;
array[2] = c;
array[3] = d;
array[4] = e;
/* string [] arr = new string[5]; */ //новый массив на тоже кол во элементов

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

void Sorting(string[] array) // или тип метода string[]
{
    for (int i = 0; i < array.Length; i++)
    {
        /* for(int j = 0; j < arr.Length; j++) */
        //{
        // if(array[i].Length <= 3) 
        // array[i] = arr[j]; // вот так не работает
        if (array[i].Length <= 3)
        {

            Console.WriteLine($"{array[i]} ");
        }

        //}
    }


    /* return arr; */
}

PrintArray(array);
Sorting(array);
/* PrintArray(arr); */
