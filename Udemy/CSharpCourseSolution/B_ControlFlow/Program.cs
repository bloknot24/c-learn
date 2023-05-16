using System.Security.Cryptography.X509Certificates;

namespace B_ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's calculate the square of a triangle.");
            Console.WriteLine("Enter the lenght of side AB:");
            double ab = GetDouble();

            Console.WriteLine("Enter the lenght of side BC:");
            double bc = GetDouble();

            Console.WriteLine("Enter the lenght of side AC:");
            double ac = GetDouble();

            int divisor = int.Parse(Console.ReadLine());

            int result = 5 / divisor;

            double p = (ab + bc + ac) / divisor;

            double square = Math.Sqrt(p * (p - ab) * (p - bc) * (p - ac));
            Console.WriteLine($"Square of the triangle equals {square}");

            Console.ReadLine();
        }

        static double GetDouble()
        {
            return double.Parse(Console.ReadLine());
        }

        static void SwitchCase()
        {
            int month = int.Parse(Console.ReadLine());

            string season = string.Empty;
            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    season = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    season = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    season = "Summer";
                    break;
                case 9:
                case 10:
                case 11:
                    season = "Autumn";
                    break;
                default:
                    throw new ArgumentException("Unexpected number of month");
            }
            Console.WriteLine(season);

            Console.ReadLine();

            int weddingYears = int.Parse(Console.ReadLine());

            string name = string.Empty;

            switch (weddingYears)
            {
                case 5:
                    name = "Деревянная свадьба";
                    break;
                case 10:
                    name = "Оловянная свадьба";
                    break;
                case 15:
                    name = "Хрустальная свадьба";
                    break;
                case 20:
                    name = "Форфоровая свадьба";
                    break;
                case 25:
                    name = "Серебрянная свадьба";
                    break;
                case 30:
                    name = "Жумчужная свадьба";
                    break;
                default:
                    name = "Не знаем такого юбилея";
                    break;
            }
            Console.WriteLine(name);
        }

        static void BreakContinue()
        {
            int[] nums = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (int n in nums)
            {
                /* if(n % 2 == 0)
                {
                    Console.Write($" {n} "); // 0 2 4 6 8
                } */

                if (n % 2 != 0)
                {
                    continue;
                }

                Console.Write($" {n} "); // 0 2 4 6 8
            }

            Console.ReadLine();

            char[] letters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j' };

            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine($"Number = {nums[i]}");

                for (int j = 0; j < letters.Length; j++)
                {
                    if (nums[i] == j)
                    {
                        break;
                    }
                    Console.Write($" {letters[j]} ");
                }
                Console.WriteLine();
            }
            /*
            Number = 0

            Number = 1
             a
            Number = 2
             a b
            Number = 3
             a b  c
            Number = 4
             a b  c d
            Number = 5
             a b  c d  e
            Number = 6
             a b  c d  e f
            Number = 7
             a b  c d  e f  g
            Number = 8
             a b  c d  e f  g h
            Number = 9
             a b  c d  e f  g h  i
            */

            Console.ReadLine();

            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            int counter = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (counter == 3)
                {
                    break;
                }

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                        counter++;
                    }
                    if (counter == 3)
                    {
                        break;
                    }
                }

            }
        }

        static void WhileDoWhile(int count)
        {
            int age = 30;

            // Цикл будет отрабатываться до тех пор, пока пользователь не укажен возраст больше 18
            // Если age = 30, цикл вообще не отработает
            while (age < 18)
            {
                Console.WriteLine("Первый цикл");
                Console.WriteLine("Какой возвраст?");
                age = int.Parse(Console.ReadLine());
            }

            /*do
            {
                Console.WriteLine("Do\\While");
                Console.WriteLine("Какой возвраст?");
                age = int.Parse(Console.ReadLine());
            }
            while(age < 18); */

            int[] numbers = { 1, 2, 3, 4, 5 };
            int i = 0;
            while (i < numbers.Length)
            {
                Console.Write(numbers[i] + " ");
                i++;
            }
            // ->
            //1 2 3 4 5
        }

        static void NestedFor()
        {
            int[] numbers = { 1, -2, 4, -7, 5, 3, 2, -1, -3, 2, 7, -1, -3, 1, 7 };

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int atI = numbers[i];
                    int atJ = numbers[j];

                    if (atI + atJ == 0)
                    {
                        Console.WriteLine($"Pair ({atI};{atJ}). Indexes ({i};{j})");
                    }
                    // ->
                    //Pair(1; -1). Indexes(0; 7)
                    //Pair(1; -1). Indexes(0; 11)
                    //Pair(-2; 2). Indexes(1; 6)
                    //Pair(-2; 2). Indexes(1; 9)
                    //Pair(-7; 7). Indexes(3; 10)
                    //Pair(-7; 7). Indexes(3; 14)
                    //Pair(3; -3). Indexes(5; 8)
                    //Pair(3; -3). Indexes(5; 12)
                    //Pair(-1; 1). Indexes(7; 13)
                    //Pair(-1; 1). Indexes(11; 13)
                }
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length - 2; i++)
            {
                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    for (int k = j + 1; k < numbers.Length; k++)
                    {
                        int atI = numbers[i];
                        int atJ = numbers[j];
                        int atK = numbers[k];

                        if (atI + atJ + atK == 0)
                        {
                            Console.WriteLine($"Triplets ({atI};{atJ};{atK}). Indexes ({i};{j};{k})");
                        }
                    }
                    // ->
                    //Triplets(1; -2; 1). Indexes(0; 1; 13)
                    //Triplets(1; 2; -3). Indexes(0; 6; 8)
                    //Triplets(1; 2; -3). Indexes(0; 6; 12)
                    //Triplets(1; -3; 2). Indexes(0; 8; 9)
                    //Triplets(1; 2; -3). Indexes(0; 9; 12)
                    //Triplets(-2; 5; -3). Indexes(1; 4; 8)
                    //Triplets(-2; 5; -3). Indexes(1; 4; 12)
                    //Triplets(-2; 3; -1). Indexes(1; 5; 7)
                    //Triplets(-2; 3; -1). Indexes(1; 5; 11)
                    //Triplets(4; -7; 3). Indexes(2; 3; 5)
                    //Triplets(4; -1; -3). Indexes(2; 7; 8)
                    //Triplets(4; -1; -3). Indexes(2; 7; 12)
                    //Triplets(4; -3; -1). Indexes(2; 8; 11)
                    //Triplets(4; -1; -3). Indexes(2; 11; 12)
                    //Triplets(-7; 5; 2). Indexes(3; 4; 6)
                    //Triplets(-7; 5; 2). Indexes(3; 4; 9)
                    //Triplets(2; -1; -1). Indexes(6; 7; 11)
                    //Triplets(2; -3; 1). Indexes(6; 8; 13)
                    //Triplets(2; -3; 1). Indexes(6; 12; 13)
                    //Triplets(-1; 2; -1). Indexes(7; 9; 11)
                    //Triplets(-3; 2; 1). Indexes(8; 9; 13)
                    //Triplets(2; -3; 1). Indexes(9; 12; 13)
                }
            }
        }

        static void ForForeach()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " "); // 1 2 3 4 5 6 7 8 9
            }
            Console.WriteLine();
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.Write(numbers[i] + " "); // 9 8 7 6 5 4 3 2 1
            }
            Console.WriteLine();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    Console.Write(numbers[i] + " "); // 2 4 6 8
                }
            }
            Console.WriteLine();
            foreach (int val in numbers)
            {
                Console.Write(val + " "); // 1 2 3 4 5 6 7 8 9
            }
        }

        static void IfElseHW()
        {
            Console.WriteLine("Введите число а");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число b");
            int b = int.Parse(Console.ReadLine());

            // 1
            int max = a;
            if (b > a)
            {
                max = b;
            }
            Console.WriteLine(max);

            // 2
            if (a > b)
            {
                Console.WriteLine($"{a} больше");
            }
            else if (a == b)
            {
                Console.WriteLine($"{a} и {b} равны");
            }
            else
            {
                Console.WriteLine($"{b} больше");
            }

            // 2
            string description = a > b ? $"{a} больше" : $"{b} больше";
            Console.WriteLine(description);
        }

        static void IfElse()
        {
            Console.WriteLine("Введите ваш возвраст, лет:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш вес, кг:");
            int weight = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост, cм:");
            double height = double.Parse(Console.ReadLine());
            height = height / 100;
            double bmi = weight / (height * height);

            bool isTooLow = bmi <= 18.5;
            bool isNormal = bmi > 18.5 && bmi < 25; // && - Логическое И
            bool isAboveNormal = bmi >= 25 && bmi <= 30;
            bool isTooFat = bmi > 30;
            bool isFat = isAboveNormal || isTooFat; // || - Логическое ИЛИ

            if (isFat) // isFat == true
            {
                Console.WriteLine("Неплохо бы сбросить пару килограмм");
            }
            else
            {
                Console.WriteLine("Вы в хорошей форме");
            }

            if (!isFat) // isFat == false
            {
                Console.WriteLine("Вы не толстый");
            }

            if (isTooLow)
            {
                Console.WriteLine("Малый вес");
            }
            else if (isNormal)
            {
                Console.WriteLine("Вес в порядке");
            }
            else if (isAboveNormal)
            {
                Console.WriteLine("Осторожно, лишний вес на подходе");
            }
            else
            {
                Console.WriteLine("Тебе нужно потерять немного веса");
            }

            if (isFat || isTooFat)
            {
                Console.WriteLine("Время сесть на диету");
            }

            string description = age > 18 ? "Вы можете выпивать алкоголь" : "Вам нужно еще подрасти"; // Тернарный оператор
            // То же что и...
            if (age > 18)
            {
                description = "Вы можете выпивать алкоголь";
            }
            else
            {
                description = "Вам нужно еще подрасти";
            }
            Console.WriteLine(description);
        }
    }
}