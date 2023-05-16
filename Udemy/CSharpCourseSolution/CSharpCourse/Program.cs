using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Не та консоль");
        }

        static void HomeWork03()
        {
            Console.WriteLine("Введите вашу фамилию:");
            string family = Console.ReadLine();
            Console.WriteLine("Введите ваше имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш возвраст, лет:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш вес, кг:");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост, cм:");
            double height = double.Parse(Console.ReadLine());
            height = height / 100;
            double bmi = weight / (height * height);
            string result = string.Format("{0:f}", bmi);

            string profile =
                  $"Your profile:{Environment.NewLine}"
                + $"Full Name: {family}, {name}{Environment.NewLine}"
                + $"Age: {age} years old{Environment.NewLine}"
                + $"Weight: {weight} kg"
                + $"Height: {height} m"
                + $"Body Mass Index: {result}";

            Console.WriteLine(profile);

            //Console.WriteLine("Your profile:");
            //Console.WriteLine($"Full Name: {family}, {name}");
            //Console.WriteLine($"Age: {age} years old");
            //Console.WriteLine($"Weight: {weight} kg");
            //Console.WriteLine($"Height: {height} m");
            //Console.WriteLine($"Body Mass Index: {result}");
        }

        static void HomeWork02()
        {
            Console.WriteLine("Введите 1 длину стороны треугольника A");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите 2 длину стороны треугольника B");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите 3 длину стороны треугольника C");
            double c = double.Parse(Console.ReadLine());

            double p = 0.5 * (a + b + c);
            double s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            string result = string.Format("{0:f}", s);
            Console.WriteLine($"Результат: {result}");
        }

        static void HomeWork01()
        {
            // 1
            Console.WriteLine("Введите ваше имя!");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}.");

            // 2
            Console.WriteLine("Введите целое число для x");
            int x  = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите целое число еще раз для y");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"x = {x}, y = {y}");
            x = x + y;
            y = y - x;
            y = -y;
            x = x - y;
            Console.WriteLine($"После замены: x = {x}, y = {y}");

            //3
            Console.WriteLine("Введите число!");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine($"Кол-во цифр: {q.ToString().Length}");
        }

        static void DateTimeType()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now.ToString()); // 11.04.2023 17:16:02

            Console.WriteLine($"It's {now.Date}, {now.Hour}:{now.Minute}"); // It's 11.04.2023 00:00:00, 17:17

            DateTime dt = new DateTime(2016, 2, 28);
            Console.WriteLine(dt); // 28.02.2016 00:00:00

            DateTime newDt = dt.AddDays(1); // Прибавляем один день
            Console.WriteLine(newDt); // 29.02.2016 00:00:00 + 1 day


            // Тип длительности времени
            TimeSpan ts = now - dt;
            Console.WriteLine(ts.Days); // 2599 - получаем только дату
            ts = now.Subtract(dt); // тоже самое
            Console.WriteLine(ts); // 2599.17:25:33.3597960
        }

        static void IntroToArray()
        {
            int[] a1;
            a1 = new int[10];

            int[] a2 = new int[5];

            int[] a3 = new int[5] { 1, 3, -2, 5, 10 };

            int[] a4 = { 1, 3, 2, 4, 5 };

            Console.WriteLine(a1[9]); // 0
            Console.WriteLine(a4[0]); // 1

            int number = a4[4];
            Console.WriteLine(number); // 5

            a4[4] = 6; // перезаписываем значение
            Console.WriteLine(a4[4]); // 6

            Console.WriteLine(a4.Length); // 5 - получаем длину массива
            Console.WriteLine(a4[a4.Length - 1]); // 6 - получаем последний элемент массива

            string s1 = "abcdefgh";
            char first = s1[0];
            char last = s1[s1.Length - 1];

            Console.WriteLine($"First:{first}. Last:{last}");

            // Строку защищены от модификации через запись массива
            // s1[0] = 'z';
        }

        static void MathDemo()
        {
            Console.WriteLine(Math.Pow(2, 3)); // 8
            Console.WriteLine(Math.Sqrt(9)); // 3
            Console.WriteLine(Math.Sqrt(8)); // 2,8284271247461903

            Console.WriteLine(Math.Round(1.7)); // 2
            Console.WriteLine(Math.Round(1.4)); // 1
            Console.WriteLine(Math.Round(1.5)); // 2

            Console.WriteLine();

            Console.WriteLine(Math.Round(2.5)); // 2
            Console.WriteLine(Math.Round(2.5, MidpointRounding.AwayFromZero)); // 3
            Console.WriteLine(Math.Round(2.5, MidpointRounding.ToEven)); // 2
        }

        static void Comments()
        {
            // a single comment

            /*
             * Multi-line comment
             * We can write here many words
             */

            // describe hows and whys! not whats!

            int a = 1;

            // increment a by 1 - bad comment, this code is self-evident

            // we need to tweak the index to match the expected outcome
            a++;
        }

        static void CastingAndParsing()
        {
            byte b = 3; // 0000 0011
            int i = b; // 0000 0000 0000 0000 0000 0000 0000 0011
            long l = i; // 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0000 0011

            float f = i; // 3.0

            Console.WriteLine(f); // 3

            b = (byte)i; // явное приведение типов
            Console.WriteLine(b); // 3

            i = (int)f; // опять же явное приведение

            f = 3.1f;
            i = (int)f;
            Console.WriteLine(i); // 3

            string str = "1";
            i = int.Parse(str); // "неявное" приведение типов, парсим строку к определенному типу данных
            Console.WriteLine(i); // 1

            int x = 5;
            int result = x / 2;
            Console.WriteLine(result); // 2, т.к. указан тип int и было округление

            double result2 = (double)x / 2;
            // Приведение типов более приоритетная операция, чем умножение и деление
            Console.WriteLine(result2); // 2.5
        }

        static void ConsoleBasics()
        {
            //Console.WriteLine("Hi, please tell me your name");

            //string name = Console.ReadLine();
            //string sentence = $"Your name is {name}";
            //Console.WriteLine(sentence);

            Console.WriteLine("Hi, please tell me your age");
            string input = Console.ReadLine();
            int age = int.Parse(input); // Преобразуем строку к числу

            string sentence = $"Your age is {age}.";
            Console.WriteLine(sentence);

            Console.Clear(); // очищаем консоль
            Console.BackgroundColor = ConsoleColor.Cyan; // цвет фона
            Console.ForegroundColor = ConsoleColor.Yellow; // цвет текста

            Console.Write("New Style "); // Write как WriteLine, только на новую строчку нет отступа
            Console.Write("New Style\n");
        }

        static void ComparingsStrings()
        {
            string str1 = "abcde";
            string str2 = "abcde";

            bool areEqual = str1 == str2;
            Console.WriteLine(areEqual); // True

            areEqual = string.Equals(str1, str2, StringComparison.Ordinal);
            Console.WriteLine(areEqual); // True

            string s1 = "Strasse";
            string s2 = "Straße";

            areEqual = string.Equals(s1, s2, StringComparison.Ordinal); // простое сравнение - работает быстрее всего и этого достаточно
            Console.WriteLine(areEqual); // False
            areEqual = string.Equals(s1, s2, StringComparison.InvariantCulture); // понимание лингвистических правил, избегаем
            Console.WriteLine(areEqual); // True
            areEqual = string.Equals(s1, s2, StringComparison.CurrentCulture); // четкий учет относительно нужной культуры
            Console.WriteLine(areEqual); // True
        }

        static void StringFormat()
        {
            string name = "John";
            int age = 30;
            string str1 = string.Format("My name is {0} and I'm {1}", name, age);
            string str2 = "My name is " + name + " and I'm " + age; // То же самое
            string str3 = $"My name is {name} and I'm {age}";

            Console.WriteLine(str1); // My name is John and I'm 30
            Console.WriteLine(str2); // My name is John and I'm 30
            Console.WriteLine(str3); // My name is John and I'm 30

            string str4 = "My name is \nJohn";
            Console.WriteLine(str4); // My name is
                                     // John

            // Данный способ перевода строки самый оптимальный, т.к. работает на все операционные системы
            str4 = $"My name is {Environment.NewLine} John";
            Console.WriteLine(str4); // My name is
                                     //  John

            string str5 = "I'm \t30";
            Console.WriteLine(str5); // I'm     30

            // Экранируем ковычки
            string str6 = "I'm John and I'm \"good\" programmer";
            Console.WriteLine(str6); // I'm John and I'm "good" programmer

            // Экранируем слеш
            string str7 = "C:\\tmp\\test_file.txt";
            Console.WriteLine(str7); // C:\tmp\test_file.txt

            string str8 = @"C:\tmp\test_file.txt";
            Console.WriteLine(str8); // C:\tmp\test_file.txt

            int answer = 42;
            string result = string.Format("{0:d}", answer);
            string result2 = string.Format("{0:d4}", answer);
            Console.WriteLine(result); // 42
            Console.WriteLine(result2); // 0042

            result = string.Format("{0:f}", answer);
            result2 = string.Format("{0:f4}", answer);
            Console.WriteLine(result); // 42,00
            Console.WriteLine(result2); // 42,0000

            Console.OutputEncoding = Encoding.UTF8;

            double money = 12.8;
            result = string.Format("{0:C}", money);
            result2 = string.Format("{0:C2}", money);

            Console.WriteLine(result); // 12,80 Br
            Console.WriteLine(money.ToString("C2")); // 12,80 Br - можно и таким образом
            Console.WriteLine(result2); // 12,80 Br

            result = $"{money:C2}";
            Console.WriteLine(result); // 12,80 Br

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Console.WriteLine(money.ToString("C2")); // $12.80
        }

        static void StringBuilderDemo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("My ");
            sb.Append("name ");
            sb.Append("is ");
            sb.Append("John");
            sb.AppendLine("!");
            sb.AppendLine("Hello!");
            sb.Append("Ok");

            string str = sb.ToString();
            Console.WriteLine(str);
        }

        static void StringModivication()
        {
            string nameConcat = string.Concat("My", "name", "is", "John");
            Console.WriteLine(nameConcat); // MynameisJohn

            nameConcat = string.Join(" ", "My", "name", "is", "John");
            Console.WriteLine(nameConcat); // My name is John

            nameConcat = "My " + "name " + "is " + "John";
            Console.WriteLine(nameConcat); // My name is John

            nameConcat = nameConcat.Insert(0, "By the way, ");
            Console.WriteLine(nameConcat); // By the way, My name is John

            nameConcat = nameConcat.Remove(0, 1);
            Console.WriteLine(nameConcat); // y the way, My name is John

            string replaced = nameConcat.Replace('n', 'z');
            Console.WriteLine(replaced); // y the way, My zame is Johz

            string data = "12;28;34;25;65";
            string[] splitData = data.Split(';');
            string first = splitData[0];
            Console.WriteLine(first); // 12

            char[] chars = nameConcat.ToCharArray();
            Console.WriteLine(chars[0]); // y
            Console.WriteLine(nameConcat[0]); // y

            string lower = nameConcat.ToLower();
            Console.WriteLine(lower); // y the way, my name is john

            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper); // Y THE WAY, MY NAME IS JOHN

            string john = " My name is John ";
            Console.WriteLine(john.Trim()); // 'My name is John'
        }

        static void StringEmptiness()
        {
            string str = string.Empty; // вернет "", то есть пустую строку

            string empty = "";
            string whiteSpaced = " ";
            string notEmpty = " b";
            string nullString = null; // означает отсутствие экземпляра

            Console.WriteLine("IsNullOrEmpty"); // IsNullOrEmpty
            bool isNullOrEmpty = string.IsNullOrEmpty(nullString);
            Console.WriteLine(isNullOrEmpty); // True

            isNullOrEmpty = string.IsNullOrEmpty(whiteSpaced);
            Console.WriteLine(isNullOrEmpty); // False

            isNullOrEmpty = string.IsNullOrEmpty(notEmpty);
            Console.WriteLine(isNullOrEmpty); // False

            isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty); // True

            Console.WriteLine();
            Console.WriteLine("IsNullOrWhiteSpace");

            bool isNullOrWhiteSpace = string.IsNullOrWhiteSpace(nullString);
            Console.WriteLine(isNullOrWhiteSpace); // True

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(whiteSpaced);
            Console.WriteLine(isNullOrWhiteSpace); // True

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(notEmpty);
            Console.WriteLine(isNullOrWhiteSpace); // False

            isNullOrWhiteSpace = string.IsNullOrWhiteSpace(empty);
            Console.WriteLine(isNullOrWhiteSpace); // False
        }

        static void QueringStrings()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a');
            bool containsE = name.Contains("E");

            Console.WriteLine(containsA); // True
            Console.WriteLine(containsE); // False

            bool endWithAbra = name.EndsWith("abra");
            Console.WriteLine(endWithAbra); // True

            bool startsWithAbra = name.StartsWith("abra");
            Console.WriteLine(startsWithAbra); // True

            int indexOfA = name.IndexOf("a", 1);
            Console.WriteLine(indexOfA); // 3

            int lastIndexOfR = name.LastIndexOf("r");
            Console.WriteLine(lastIndexOfR); // 9

            Console.WriteLine(name.Length); // 11

            string substrFrom5 = name.Substring(5);
            string substrFromTo = name.Substring(0, 3);
            Console.WriteLine(substrFrom5); // adabra
            Console.WriteLine(substrFromTo); // abr
        }

        static void StaticAndInstanceMembers()
        {
            string name = "abracadabra";
            bool containsA = name.Contains('a'); // Метод Contains не статический, а метод экземпляра
            bool containsE = name.Contains("E");

            Console.WriteLine(containsA); // True
            Console.WriteLine(containsE); // False
    
            string abc = string.Concat("a", "b", "c"); // здесь Concat статический
            Console.WriteLine(abc); // abc

            Console.WriteLine(int.MinValue); // статический член, т.к. вызывается напрямую на типе
            // -2147483648

            int x = 1;
            string xStr = x.ToString();
            Console.WriteLine(xStr); // 1 string
            Console.WriteLine(x); // 1 int
        }

        static void ComparisonOperations()
        {
            int x = 1;
            int y = 2;

            bool areEqual = x == y;
            Console.WriteLine(areEqual); // False

            bool result = x > y;
            Console.WriteLine(result); // False

            result = x >= y;
            Console.WriteLine(result); // False

            result = x < y;
            Console.WriteLine(result); // True

            result = x <= y;
            Console.WriteLine(result); // True

            result = x != y;
            Console.WriteLine(result); // True
        }

        static void ArithmeticOperations()
        {
            int x = 1;
            int y = 2;

            int z = x + y;
            int k = x - y;
            int a = z + k - y;

            Console.WriteLine(z); // 3
            Console.WriteLine(k); // -1
            Console.WriteLine(a); // 0

            int l = 2 + 2 * 2;
            Console.WriteLine(l); // 6

            int b = z * 2;
            int c = k / 2;
            Console.WriteLine(b); // 6
            Console.WriteLine(c); // 0

            a = 4 % 2;
            b = 5 % 2;
            Console.WriteLine(a); // 0
            Console.WriteLine(b); // 1

            a = 3;
            a = a * a;
            b = a * a * a;
            Console.WriteLine(a); // 9
            Console.WriteLine(b); // 729

            c = 4;
            c *= 2;
            Console.WriteLine(c); // 8

            c /= 2;
            Console.WriteLine(c); // 4
        }

        static void IncrementDecrementDemo()
        {
            int x = 1;
            x = x + 1;

            Console.WriteLine(x); // 2

            x++;
            Console.WriteLine(x); // 3

            ++x;
            Console.WriteLine(x); // 4

            x = x - 1;
            x--;
            --x;
            Console.WriteLine(x); // 1

            Console.WriteLine("Learn about increments"); // Learn about increments
            Console.WriteLine($"Last x state is {x}");   // Last x state is 1

            int j = x++;
            Console.WriteLine(j); // 1
            Console.WriteLine(x); // 2

            j = ++x;
            Console.WriteLine(j); // 3
            Console.WriteLine(x); // 3

            x += 2;
            Console.WriteLine(x); // 5

            j -= 2;
            Console.WriteLine(j); // 1
        }

        static void Overflow()
        {
            checked // это проверка на переполнение для блока кода
            {
                uint x = uint.MaxValue;
                Console.WriteLine(x);

                x = x + 1;
                Console.WriteLine(x);

                x = x - 1;
                Console.WriteLine(x);
            }
        }

        static void VariablesScope()
        {
            var a = 1;
            {
                var b = 2;
                {
                    var c = 3;

                    Console.WriteLine(a);
                    Console.WriteLine(b);
                    Console.WriteLine(c);
                }
                Console.WriteLine(a);
                Console.WriteLine(b);
                //Console.WriteLine(c); // это переменная не видна здесь
            }
        }
        
        static void Literals()
        {
            int x = 0b11; // числовой литерал в бинарном виде
            int y = 0b1001; // числовой литерал в бинарном виде
            int k = 0b10001001; // числовой литерал в бинарном виде
            int m = 0b1000_1001; // числовой литерал в бинарном виде

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);
            Console.WriteLine();

            x = 0x1F;
            y = 0xFF0D;
            k = 0x1FAB30EF;
            m = 0x1FAB_30EF;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(k);
            Console.WriteLine(m);
            Console.WriteLine();

            Console.WriteLine(4.5e2);
            Console.WriteLine(3.1E-1);
            Console.WriteLine();

            Console.WriteLine('\x78');
            Console.WriteLine('\x5A');

            Console.WriteLine();

            Console.WriteLine('\u0420');
            Console.WriteLine('\u0421');
        }

        static void Variables()
        {
            int x = -1;
            int y;
            y = 2;

            // Int32 x = -1; // то же что и int x = -1;
            // uint z = -1; // ошибка, потому что uint не может быть со знаком -
            float f = 1.1f; // если буква f стоять не будет, получим ошибку       
            double d = 2.3; // дробные значения по умолчанию считаются типом double
            // По умолчанию числовым типам данных присваивается 0

            int x2 = 0; // эти два значения
            int x3 = new int(); // идентичны

            var a = 1; // переменная без указания типа данных, var 
                       // позволяет самостоятельно обозначить тип данных

            // Без необходимости var не используется.
            // Dictionary<int, string> dict = new Dictionary<int, string>(); // длинный тип данных
            // var dict = new Dictionary<int, string>(); // в этом случае тип данных будет короче
            // var v; // так делать нельзя, т.к. у переменной будет не определен тип

            decimal money = 3.0m; // для decimal необходимо у значения переменной доставлять букву m

            char character = 'A';

            string name = "John";

            bool canDrive = true;
            bool canDraw = false;

            object obj1 = 1;
            object obj2 = "obj2";
            // object напрямую практически никогда не используется

            Console.WriteLine(a);
            Console.WriteLine(name);


            // Так же имя переменных пишется слитно или через _
            // Не может начинаться с цифры
            // Если имя переменной совпадает с типом данных, предваряем его @, например char @char = 2;
        }
    }
}