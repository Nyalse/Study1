using System.Globalization;
string date = "05/07/2023";
string format = "M/d/yyyy";
DateTime dateTime; 
dateTime = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
 Console.WriteLine("Преобразованная дата  с помощью ParseExact " + dateTime);
dateTime = DateTime.Parse(date);
Console.WriteLine("Преобразованная дата с помощью Parse " + dateTime);
bool result = DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime);
if (result)
{
    Console.WriteLine("Преобразованная дата  с помощью TryParseExact: " + dateTime); 
}
else
{
    Console.WriteLine("Invalid date format.");
}
