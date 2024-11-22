using DLL;

internal class Program
{
    private static void Main(string[] args)
    {
<<<<<<< Updated upstream
        myclass myClass = new myclass();
        myClass.Method1();
        myClass.Method2();
        Console.WriteLine(myClass.Method3());
        Console.WriteLine(myClass.Method4());
        Console.WriteLine(myClass.Method5());
        //User user = new User();
        //Console.WriteLine("Ваша анкета");
        //Console.WriteLine("Введите ваше имя: ");
        //user.Name = Console.ReadLine();
        //Console.WriteLine("Введите вашу фамилию: ");
        //user.Surname= Console.ReadLine();
        //Console.WriteLine("Введите ваш возраст: ");
        //user.Age=Convert.ToInt32( Console.ReadLine());
        //Console.WriteLine("Введите ваш пол: ");
        //user.Male=Console.ReadLine();
        //Console.WriteLine($"Я,{user.Name} {user.Surname} мне {user.Age}, и мой пол {user.Male}");
        //MyMethod1();
=======
        //myclass myClass = new myclass();
        //myClass.Method1();
        //myClass.Method2();
        //Console.WriteLine(myClass.Method3());
        //Console.WriteLine(myClass.Method4());
        //Console.WriteLine(myClass.Method5()); Тут код DLL
 
        //MyMethod1(); тут код методов
>>>>>>> Stashed changes
        //MyMethod();

        try { User user = new User();
            Console.WriteLine("Ваша анкета");
            Console.WriteLine("Введите ваше имя: ");
            user.Name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию: ");
            user.Surname = Console.ReadLine();
            Console.WriteLine("Введите ваш возраст: ");
            user.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите ваш пол: ");
            user.Male = Console.ReadLine();
            Console.WriteLine($"Я,{user.Name} {user.Surname} мне {user.Age}, и мой пол {user.Male}");
        }
        catch(System.FormatException) { Console.WriteLine("Неверно задан возраст");
            Console.WriteLine("Если у вас были какие то ошибки то, начните регистрацию сначала и проверьте корректность введенных данных");
        }
        finally { Console.WriteLine("Приятного дня!");  }

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
