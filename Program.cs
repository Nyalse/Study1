internal class Program
{
    private static void Main(string[] args)
    {
        User user = new User();
        Console.WriteLine("Ваша анкета");
        Console.WriteLine("Введите ваше имя: ");
        user.Name = Console.ReadLine();
        Console.WriteLine("Введите вашу фамилию: ");
        user.Surname= Console.ReadLine();
        Console.WriteLine("Введите ваш возраст: ");
        user.Age=Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Введите ваш пол: ");
        user.Male=Console.ReadLine();
        Console.WriteLine($"Я,{user.Name} {user.Surname} мне {user.Age}, и мой пол {user.Male}");
        //MyMethod1();
        //MyMethod();

    }
    //public static void MyMethod()
    //{ Console.WriteLine("!рим,тевирП"); }
    //private static void MyMethod1()
    //{
    //    Console.WriteLine("Привет,мир!");
    //}
    class User
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Male;
    }
}
