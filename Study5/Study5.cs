using System.ComponentModel.Design;
Console.WriteLine("Введите первое значение");
string str1 = Console.ReadLine();
Console.WriteLine("Введите второе значение");
string str2 = Console.ReadLine();
int result = string.Compare(str1, str2);
if (result < 0)
{
    Console.WriteLine(str1);
}
else if(result > 0) 
{ Console.WriteLine(str2); }
else
{
   Console.WriteLine("Это одинаковые слова");
}
bool result2 =str1.Equals(str2);
if (result2 == true)
{
    Console.WriteLine("Строки равны метод Equals");
}
else
{
    Console.WriteLine("Строки неравны метод Equals");
}
int result3 = string.CompareOrdinal(str1, str2);
if (result3 < 0)
{
    Console.WriteLine("Первая строка больше");
}
else if (result3 > 0)
{ Console.WriteLine("Вторая строка больше"); }
else
{
    Console.WriteLine("Строки равны");
}
Console.WriteLine("Введите текст:");
string str3 = Console.ReadLine();
Console.WriteLine("Введите символ, который нужно найти:");
char ch= Convert.ToChar(Console.ReadLine());
int number = str3.IndexOf(ch);
number += 1;
Console.WriteLine($"Порядковый номер первого появления вашего символа:{number}");
string[] people = { "Алекс", "Дарья", "Анна", "Виктор" };
Console.WriteLine("Введите имя:");
bool result4 = people.Contains(Console.ReadLine()); 
if (result4 == true)
{
    Console.WriteLine("Это имя есть в списке");
}
else 
{
    Console.WriteLine("Этого имени нет в списке");
}



