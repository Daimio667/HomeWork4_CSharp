// Task 29 : Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33

Console.WriteLine("Enter the number of array elements : ");
int count = Convert.ToInt32(Console.ReadLine());
int[] GetArray(int count)
{
   int[] array = new int[count]; 
   for (int i = 0; i < array.Length; i++)
   {
        Console.WriteLine($"Enter array element at index {i} : ");
        array[i] = Convert.ToInt32(Console.ReadLine());
   }
   return array;
}
int[] resultArray = GetArray(count);
Console.WriteLine
($"Result array: [ {String.Join("; ", resultArray)} ]");
int[] resultArrayA = GetArray(8);
Console.WriteLine
($"Result array: [ {String.Join("; ", resultArrayA)} ]");