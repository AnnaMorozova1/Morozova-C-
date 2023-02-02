// Составить алгоритм: если введенное имя совпадает с Вячеслав, 
// то вывести “Привет, Вячеслав”, если нет, то вывести "Нет такого имени"

Console.WriteLine("Введите имя: ");
string name1=Console.ReadLine();
string name="Вячеслав";
if (name1 == name)
{
    Console.WriteLine("Привет, Вячеслав");
}
else
{
    Console.WriteLine("Нет такого имени");
}
