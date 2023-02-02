// Составить алгоритм: на входе есть числовой массив, 
// необходимо вывести элементы массива кратные 3

Console.WriteLine("Ввести колличество элементов: ");
int Count = Convert.ToInt32(Console.ReadLine());
int[] mass = new int[Count];
Console.WriteLine("Ввести элементы массива: ");
for (int i=0; i<mass.Length; i++)
{
    mass[i]=Convert.ToInt32(Console.ReadLine());  
 }
Console.WriteLine("Числа кратные 3: ");
for (int i=0; i<mass.Length; i++)
{
    if (mass[i] % 3 == 0) 
    {
        Console.WriteLine(mass[i]+" "); 
    }
}
