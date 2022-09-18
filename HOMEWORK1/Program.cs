using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HOMEWORK1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Ex13();
        }
        public static void Ex1()
        {
            Console.WriteLine("Задача1:вывести е с точностью до десятых");
            double e = Math.E;
            e = Math.Round(e, 1);
            Console.WriteLine(e);
            Console.ReadKey();
        }
        public static void Ex2()
        {
            Console.WriteLine("Задача2:вывести на экран числа 50 и 10 друг под другом");
            int x = 50, y = 10;
            Console.WriteLine($"{x}\n{y}");
            Console.ReadKey();
        }
        public static void Ex3()
        {
            Console.WriteLine("Задача3:Вывести в столбик четыре любых числа");
            Random rnd = new Random();
            int x = rnd.Next();
            int y = rnd.Next();
            int s = rnd.Next();
            int o = rnd.Next();
            Console.WriteLine($"{x}\n{y}\n{s}\n{o}");
            Console.ReadKey();
        }
        public static void Ex4()
        {
            Console.WriteLine("Задача4: вывести на экран число на 10 больше, чем введенное пользователем");
            Console.Write("Введите любое число:");
            int x = int.Parse(Console.ReadLine());
            int y = x + 10;
            Console.WriteLine(y);
            Console.ReadKey();
        }
        public static void Ex5()
        {
            Console.WriteLine("Задача5:Найти периметр квадрата");
            Console.Write("Введите сторону квадрата:");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                //

            }
            if (x <= 0)
            {
                Console.WriteLine("Вы ввели отрицательное число");
                Console.ReadKey();
            }
            double y = Math.Pow(x, 2);
            Console.WriteLine(y);
            Console.ReadKey();
        }
        public static void Ex6()
        {
            Console.WriteLine("Задача6:Найти длину окружности и площадь круга");
            Console.Write("Введите радиус круга:");
            if (double.TryParse(Console.ReadLine(), out double r))
            {
                //

            }
            if (r <= 0)
            {
                Console.WriteLine("Вы ввели отрицательное число");
                Console.ReadKey();
            }
            double len = 2 * r * Math.PI;
            double s = Math.PI * Math.Pow(r, 2);
            Console.WriteLine($"Длина окружности:{len}\nПлощадь окружности:{s}");
            Console.ReadKey();

        }
        public static void Ex7()
        {
            Console.WriteLine("Задача7:найдите значение косинуса х");
            Console.Write("Введите значение х=");
            double x = double.Parse(Console.ReadLine());
            double y = Math.Cos(x);
            Console.WriteLine(y);
            Console.ReadKey();
        }
        public static void Ex8()
        {
            Console.WriteLine("Задача7:найдите периметр равнобедренной трапеции");
            Console.Write("Введите значение верхнего основания трапеции х=");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                //

            }
            if (x <= 0)
            {
                Console.WriteLine("Вы ввели отрицательное число");
                Console.ReadKey();
            }
            Console.Write("Введите значение нижнего основания трапеции х=");
            if (double.TryParse(Console.ReadLine(), out double m))
            {
                //

            }
            if (m <= 0)
            {
                Console.WriteLine("Вы ввели отрицательное число");
                Console.ReadKey();
            }
            Console.Write("Введите значение высоты трапеции y=");
            if (double.TryParse(Console.ReadLine(), out double y))
            {
                //

            }
            if (y <= 0)
            {
                Console.WriteLine("Вы ввели отрицательное число");
                Console.ReadKey();
            }
            double c = Math.Sqrt(Math.Pow(y, 2) + Math.Pow(m - x, 2));
            double ans = 2 * c + x + m;
            Console.WriteLine($"Периметр равнобедренной трапеции равен:{ans}");
            Console.ReadKey();


        }
        public static void Ex9()
        {
            Console.WriteLine("Задача9:найти сумму за покупку конфет, печенья и яблок");
            int c = 10;
            int b = 20;
            int a = 5;
            Console.WriteLine("Найти стоимость покупки конфет,печенья и яблок");
            Console.Write("Введите количество кг конфет:");
            if (double.TryParse(Console.ReadLine(), out double x))
            {
                //

            }
            if (x <= 0)
            {
                Console.WriteLine("Вы ввели отрицательное число");
                Console.ReadKey();
            }
            Console.Write("Введите количество кг печенья:");
            if (double.TryParse(Console.ReadLine(), out double y))
            {
                //

            }
            if (y <= 0)
            {
                Console.WriteLine("Вы ввели отрицательное число");
                Console.ReadKey();
            }
            Console.Write("Введите количество кг яблок:");
            if (double.TryParse(Console.ReadLine(), out double z))
            {
                //

            }
            if (z <= 0)
            {
                Console.WriteLine("Вы ввели отрицательное число");
                Console.ReadKey();
            }
            double summ = x * c + y * b + z * a;
            Console.WriteLine($"Сумма покупки:{summ}");
            Console.ReadKey();
        }
        public static void Ex10()
        {
            Console.WriteLine("Задача10:вывести надпись мир труд май");
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("    Труд");
            Console.WriteLine("         Май");
            Console.ReadKey();
        }
        public static void Ex11()
        {
            Console.WriteLine("Задача11:Программа просит пользователя ввести 2 числовые переменные. А после она меняет их местами и выводит результат на экран. Но, так как пользователь может ошибиться, необходимо предусмотреть тот факт, что пользователь может ввести, например, букву или строку, а так же учесть, что число может быть дробным, и для выделения её дробной части одни используют точку, другие – запятую.");
            Console.Write("a = ");
            var num1 = Console.ReadLine().Replace(".", ","); //Считываем первое число и заменяем в нём точку на запятую
            Console.Write("b = ");
            var num2 = Console.ReadLine().Replace(".", ",");////Считываем второе число и заменяем в нём точку на запятую
            //переменные в которых хранятся числа
            double a;
            double b;
            //Пытаемся перевести числа из типа стринг в тип дабл,
            //метод TryParse() возвращает true или false в
            //зависимости от того получилось ли у него перевести число или нет
            bool isNumber1 = Double.TryParse(num1, out a);
            bool isNumber2 = Double.TryParse(num2, out b);
            //проверяем введённые значения на корректность
            //если хоть в одной из переменных isNumber значение равно false,
            //то мы выводим на консоль сообщение "Введены неверные данные"


            if (!(isNumber1 && isNumber2))
                Console.WriteLine("Введены неверные данные");
            else
            {
                //Меняем переменные местами
                var t = a;
                a = b;
                b = t;
                //Выводим на консоль их значения
                Console.WriteLine("a = {0}", a);
                Console.WriteLine("b = {0}", b);
            }
            Console.ReadKey();
        }
        public static void Ex12()
        {
            Console.WriteLine("1 - Треугольник, 2 - Четырехугольник, 3 - Круг");
            var figure = Console.ReadLine();
            //в свич помещаем переменную, и определяем блоки,
            //которые будут выполнятся если значение переменной совпадает с значением в case
            //Напимер если figure = "1", то запуститься case с функцией GetTriangle();
            //в конце case обязательно нужно писать break!!!!
            switch (figure)
            {
                case "1":
                    GetTriangle();//Вызывает функции для треугольников
                    break;
                case "2":
                    GetQuadrilateral();//Вызывает функции для 4-угольников
                    break;
                case "3":
                    GetCircle();//для круга
                    break;
                default:
                    Console.WriteLine("Вы ввели неверное число");
                    break;
            }
        }
        public static void GetTriangle()
        {
            Console.WriteLine("1 - Периметр, 2 - Площадь");
            var s = Console.ReadLine();
            switch (s)
            {
                case "1":

                    GetTrianglePerimeter();
                    break;
                case "2":
                    GetTriangleS();
                    break;
            }
        }

        private static void GetTriangleS()
        {
            Console.WriteLine("Введите стороны треугольника");
            Console.Write("a=");
            var a = Double.Parse(Console.ReadLine());
            Console.Write("b=");
            var b = Double.Parse(Console.ReadLine());
            Console.Write("c=");
            var c = Double.Parse(Console.ReadLine());
            if (a + b < c)
            {
                Console.WriteLine("Такого треугольника не существует");
                return;
            }

            var p = (a + b + c) / 2;
            var S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            var R = (a * b * c) / (4 * S);
            Console.WriteLine("Площадь треугольника: {0}", S);
            Console.WriteLine("Прощадь окружности: {0}", Math.PI * R * R);
            Console.WriteLine("Площадь четырёхугольника: {0}", 2 * S);
            Console.ReadKey();
        }

        private static void GetTrianglePerimeter()
        {
            Console.WriteLine("Введите стороны треугольника");
            Console.Write("a=");
            var a = Double.Parse(Console.ReadLine());
            Console.Write("b=");
            var b = Double.Parse(Console.ReadLine());
            Console.Write("c=");
            var c = Double.Parse(Console.ReadLine());
            if (a + b < c)
            {
                Console.WriteLine("Такого треугольника не существует");
                return;
            }
            Console.WriteLine("Периметр треугольника:{0}", a + b + c);
            var p = (a + b + c) / 2;
            var S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            var R = (a * b * c) / (4 * S);
            Console.WriteLine("Периметр описанной окружности: {0}", Math.PI * 2 * R);
            Console.WriteLine("Четырёхугольник с диаганалью равной строне a: {0}", 2 * (b + c));
            Console.WriteLine("Четырёхугольник с диаганалью равной строне b: {0}", 2 * (a + c));
            Console.WriteLine("Четырёхугольник с диаганалью равной строне c: {0}", 2 * (b + a));
            Console.ReadKey();
        }


        public static void GetQuadrilateral()
        {
            Console.WriteLine("1 - Периметр, 2 - Площадь");
            var s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    GetQuadrilateralPerimeter();
                    break;
                case "2":
                    GetQuadrilateralS();
                    break;
            }

        }
        //Метод вычисляет площадь четырёхугольника
        private static void GetQuadrilateralS()
        {
            Console.Write("a=");
            var a = Double.Parse(Console.ReadLine());
            Console.Write("b=");
            var b = Double.Parse(Console.ReadLine());
            var S = a * b;
            Console.WriteLine("Площадь четырёхугольника: {0}", S);
            Console.WriteLine("Площадь равностороннего треугольника со стороной а/b и высотой b/a:{0}", 0.5 * a * b);
            Console.WriteLine("Площадь круга с радиусом a:{0}", Math.PI * a * a);
            Console.WriteLine("Площадь круга с радиусом b:{0}", Math.PI * b * b);
            Console.ReadKey();
        }
        //Метод вычисляет периметр четырёхугольника
        private static void GetQuadrilateralPerimeter()
        {
            Console.WriteLine("Введите стороны четырехугольника");
            Console.Write("a=");
            var a = Double.Parse(Console.ReadLine());
            Console.Write("b=");
            var b = Double.Parse(Console.ReadLine());
            Console.Write("c=");
            var c = Double.Parse(Console.ReadLine());
            Console.WriteLine("d=");
            var d = Double.Parse(Console.ReadLine());
            Console.WriteLine("Периметр четырехугольника={0}", a + b + c + d);
            Console.WriteLine("Периметр треугольника со сторонами a,b,c={0}", a + b + c);
            Console.WriteLine("Периметр треугольника со сторонами a,b,d={0}", a + b + d);
            Console.WriteLine("Периметр треугольника со сторонами a,d,c={0}", a + d + c);
            Console.WriteLine("Периметр треугольника со сторонами d,b,c={0}", d + b + c);
            Console.WriteLine("Периметр окружности с радиусом a:{0}", 2 * Math.PI * a);
            Console.WriteLine("Периметр окружности с радиусом b:{0}", 2 * Math.PI * b);
            Console.WriteLine("Периметр окружности с радиусом c:{0}", 2 * Math.PI * c);
            Console.WriteLine("Периметр окружности с радиусом d:{0}", 2 * Math.PI * d);
            Console.ReadKey();

        }
        public static void GetCircle()
        {
            Console.WriteLine("1 - Периметр, 2 - Площадь");
            var s = Console.ReadLine();
            switch (s)
            {
                case "1":
                    GetCirclePerimeter();
                    break;
                case "2":
                    GetCircleS();
                    break;
            }
        }
        //Метод вычисляет площадь круга
        private static void GetCircleS()
        {
            Console.Write("Введите радиус:");
            var R = Double.Parse(Console.ReadLine());
            Console.WriteLine("Прощадь окружности: {0}", Math.PI * R * R);
            Console.WriteLine("Прощадь квадрата: {0}", R * R);
            Console.WriteLine("Прощадь треугольника нельзя найти по одной стороне");
            Console.ReadKey();
        }
        //Метод вычисляет периметр круга
        private static void GetCirclePerimeter()
        {
            Console.Write("Введите радиус:");
            var R = Double.Parse(Console.ReadLine());
            Console.WriteLine("Периметр окружности: {0}", Math.PI * 2 * R);
            Console.WriteLine("Периметр квадрата: {0}", 4 * R);
            Console.WriteLine("Периметр треугольника: {0}", 3 * R);
            Console.ReadKey();
        }


        public static void Ex13()
        {
            Console.WriteLine("Задача13:вывести на экран число");
            Console.WriteLine("Вы ввели число:");

            if (double.TryParse(Console.ReadLine(), out double x))
            {
                //

            }
            else
            {
                Console.WriteLine("Вы ввели не цифру");
                Console.ReadKey();
            }
            Console.WriteLine($"Вы ввели число:{x}");
            Console.ReadKey();
        }
        public static void Ex14()
        {
            Console.WriteLine("Задача14:вывести на экран 2 кг 13 17 столбиком");
            Console.WriteLine("2 кг\n13 17");
            Console.ReadKey();
        }
        public static void Ex15()
        {
            Console.WriteLine("Задача15:вывести на экран 4 рандомных числа столбиком");
            Random rnd = new Random();//создан объект для генерации
            int x = rnd.Next();
            int y = rnd.Next();
            int z = rnd.Next();
            int m = rnd.Next();
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(m);
            Console.ReadKey();
        }
        public static void Ex16()
        {
            Console.WriteLine("Задача16:найти корни квадратного уравнения");
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0) Console.WriteLine("У уравнения нет корней");
            else
            {
                double x1 = -(b - Math.Sqrt(D)) / 2;
                double x2 = -(b + Math.Sqrt(D)) / 2;

                if (x1 == x2)
                {
                    Console.WriteLine("У уравнения только один корень: x={0}", x1);
                }
                else
                {
                    Console.WriteLine($"У уравнения два корня: x1={0}; x2={1}", x1, x2);
                }

            }
            Console.ReadKey();
        }
        public static void Ex17()
        {
            Console.WriteLine("Задача17:найти среднее арифметическое и среднее геометрическое двух чисел");
            Console.WriteLine("Введите первое число:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int y = int.Parse(Console.ReadLine());
            int ar = (x + y) / 2;
            double geo = 2 * Math.Sqrt(x * y);
            Console.WriteLine($"Среднее арифметическое двух чисел:{ar}");
            Console.WriteLine($"Среднее геометрическое двух чисел:{geo}");
            Console.ReadKey();

        }
        public static void Ex18()
        {
            Console.WriteLine("Задача18:найти расстояние между двумя точками");
            Console.Write("Введите X1: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.Write("Введите Y1: ");
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите X2: ");
            double x2 = double.Parse(Console.ReadLine());
            Console.Write("Введите Y2: ");
            double y2 = double.Parse(Console.ReadLine());
            double res = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"Расстояние между двумя точками равно: {res}");
            Console.ReadKey();
        }
        public static void Ex19a()
        {
            Console.WriteLine("Задача19:обмен значениями трех переменных величин а, b, c");
            Console.WriteLine("a. b присвоить значение c, а присвоить значение b, с присвоить значение а");
            int a = 1;
            int b = 2;
            int c = 5;
            int buffer = a;
            a = b;
            b = c;
            c = buffer;
            Console.WriteLine($"a={a}, b={b}, c={c}");
            Console.ReadKey();

        }
        public static void Ex19b()
        {
            Console.WriteLine("Задача19:обмен значениями трех переменных величин а, b, c");
            Console.WriteLine("b. b присвоить значение а, с присвоить значение b, а присвоить значение с");
            int a = 1;
            int b = 2;
            int c = 5;
            int buffer = a;
            a = c;
            c = b;
            b = buffer;
            Console.WriteLine($"a={a}, b={b}, c={c}");
            Console.ReadKey();
        }
        public static void Ex20a()
        {
            Console.WriteLine("Задача20a:определить сколько полных часов прошло с начала суток");
            Console.WriteLine("Введите количество секунд:");
            double n = double.Parse(Console.ReadLine());
            double ans = Math.Floor(n / 3600);
            Console.WriteLine($"Прошло {ans} часов с начала суток");
            Console.ReadKey();
        }
        public static void Ex20b()
        {
            Console.WriteLine("Задача20b:определить сколько полных минут прошло с начала суток");
            Console.WriteLine("Введите количество секунд:");
            double n = double.Parse(Console.ReadLine());
            double ans = Math.Floor(n / 60);
            Console.WriteLine($"Прошло {ans} минут с начала суток");
            Console.ReadKey();

        }
        public static void Ex20v()
        {
            Console.WriteLine("Задача20v:определить сколько полных минут прошло с начала суток");
            Console.WriteLine("Введите количество секунд:");
            double n = double.Parse(Console.ReadLine());
            double ans = Math.Floor(n);
            Console.WriteLine($"Прошло {ans} секунд с начала суток");
            Console.ReadKey();
        }
        public static void Ex21()
        {
            Console.WriteLine("Задача21:Дан прямоугольник с размерами 543 х 130 мм. Сколько квадратов со стороной 130 мм можно отрезать от него");
            int s1 = 543 * 130;
            Console.WriteLine($"Площадь прямоугольника:{s1}");
            int x = 130;
            Console.WriteLine($"Сторона квадрата:{x}");
            int s2 = 130 * 130;
            Console.WriteLine($"Площадь квадрата:{s2}");
            int col = s1 / s2;
            Console.WriteLine($"Количество квадратов, которое можно отрезать от прямоугольника:{col}");
            Console.ReadKey();

        }
        public static void Ex22()
        {
            Console.WriteLine("Задача22:В трехзначном числе зачеркивают последнюю цифру и приписывают ее в начале:");
            Console.WriteLine("Введите трехзначное число:");
            int x = int.Parse(Console.ReadLine());
            if (x >= 100)
            {
                //
            }
            if (x <= 999)
            {
                //
            }
            else
            {
                Console.WriteLine("Вы ввели не трехзначное число!");
                Console.ReadKey();
            }

            x = x % 10 * 100 + x / 10;
            Console.WriteLine($"Вы получили число:{x}");
            Console.ReadKey();



        }
        public static void Ex23a()
        {
            Console.WriteLine("Задача23a:Найти в натуральном числе число сотен");
            Console.Write("Введите число n>999\nn=");
            int n = int.Parse(Console.ReadLine());
            if (n < 999)
            {
                Console.WriteLine("Вы ввели не то число!");
                Console.ReadKey();
            }
            else
            { //
            }
            int s = n / 100;
            if (s > 10)
            {
                s = s % 10;
            }
            Console.WriteLine($"Число сотен:{s}");
            Console.ReadKey();
        }
        public static void Ex23b()
        {
            Console.WriteLine("Задача23a:Найти в натуральном числе число тысяч");
            Console.Write("Введите число n>999\nn=");
            int n = int.Parse(Console.ReadLine());
            if (n < 999)
            {
                Console.WriteLine("Вы ввели не то число!");
                Console.ReadKey();
            }
            else
            { //
            }
            int s = n / 1000;
            Console.WriteLine($"Число тысяч:{s}");
            Console.ReadKey();
        }
        public static void Ex24a()
        {
            Console.WriteLine("Задача24a:Вывести четырехзначное число справа налево");
            Console.Write("Введите число:n=");
            int n = int.Parse(Console.ReadLine());
            if (n < 1000)
            {
                Console.WriteLine("Вы ввели не то число!");
                Console.ReadKey();
            }
            if (n > 9999)
            {
                Console.WriteLine("Вы ввели не то число!");
                Console.ReadKey();
            }
            else
            { //
            }
            string text = Convert.ToString(n);
            char[] l = text.ToCharArray();
            string ans = String.Empty;//создаем пустую строку
            for (int i = l.Length - 1; i > -1; i--)
            {
                ans += l[i];
            }
            Console.WriteLine($"Зеркально отраженное число:{ans}");
            Console.ReadKey();
        }
        public static void Ex24b()
        {
            Console.WriteLine("Задача24b:Вывести четырехзначное число, поменяв местами первое со втором и третье с четвертым");
            Console.Write("Введите число:n=");
            int n = int.Parse(Console.ReadLine());
            if (n < 1000)
            {
                Console.WriteLine("Вы ввели не то число!");
                Console.ReadKey();
            }
            if (n > 9999)
            {
                Console.WriteLine("Вы ввели не то число!");
                Console.ReadKey();
            }
            else
            { //
            }
            string str = Convert.ToString(n);
            char i = str[0], i1 = str[1], i2 = str[2], i3 = str[3];
            Console.Write($"{i1}{i}{i3}{i2}");
            Console.ReadKey();
        }
        public static void Ex24v()
        {
            Console.WriteLine("Задача24b:Вывести четырехзначное число, поменяв местами вторую с третьей цифры");
            Console.Write("Введите число:n=");
            int n = int.Parse(Console.ReadLine());
            if (n < 1000)
            {
                Console.WriteLine("Вы ввели не то число!");
                Console.ReadKey();
            }
            if (n > 9999)
            {
                Console.WriteLine("Вы ввели не то число!");
                Console.ReadKey();
            }
            else
            { //
            }
            string str = Convert.ToString(n);
            char i = str[0], i1 = str[1], i2 = str[2], i3 = str[3];
            Console.Write($"{i}{i2}{i1}{i3}");
            Console.ReadKey();
        }
        public static void Ex24g()
        {
            Console.WriteLine("Задача24b:Вывести четырехзначное число, поменяв местами две первые и две вторые цифры");
            Console.Write("Введите число:n=");
            int n = int.Parse(Console.ReadLine());
            if (n < 1000)
            {
                Console.WriteLine("Вы ввели не то число!");
                Console.ReadKey();
            }
            if (n > 9999)
            {
                Console.WriteLine("Вы ввели не то число!");
                Console.ReadKey();
            }
            else
            { //
            }
            string str = Convert.ToString(n);
            char i = str[0], i1 = str[1], i2 = str[2], i3 = str[3];
            Console.Write($"{i1}{i}{i3}{i2}");
            Console.ReadKey();
        }
        public static void Ex25()
        {
            Console.WriteLine("Задача25:получить исходное число х");
            Console.WriteLine("Введите число 100<= n <= 999");
            int n = int.Parse(Console.ReadLine());
            if (n <= 100)
            {
                Console.WriteLine("Вы ввели не то число!");
                Console.ReadKey();
            }
            if (n >= 999)
            {
                Console.WriteLine("Вы ввели не то число!");
                Console.ReadKey();
            }
            else
            {
                //
            }
            int c = n / 100;
            int a = (n % 100) / 10;
            int b = n % 10;
            Console.WriteLine(a + "" + b + "" + c);
        }
        public static void Ex26()
        {
            Console.WriteLine("Задача26:найти угол стрелки часов");
            Console.Write("Введите часы: "); // 0<=часы<=23
            int hour = Convert.ToInt32(Console.ReadLine());
            if (hour <= 0)
            {
                Console.WriteLine("Время не может быть отрицательной величиной");
                Console.ReadKey();

            }
            if (hour >= 23)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();

            }
            else
            {
                //
            }
            Console.Write("Введите минуты: "); // 0<=минуты<=59
            int minut = Convert.ToInt32(Console.ReadLine());
            if (minut <= 0)
            {
                Console.WriteLine("Время не может быть отрицательной величиной");
                Console.ReadKey();

            }
            if (minut >= 59)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();

            }
            else
            {
                //
            }
            Console.Write("Введите секунды: "); // 0<=секунды<=59
            int sec = Convert.ToInt32(Console.ReadLine());
            if (sec <= 0)
            {
                Console.WriteLine("Время не может быть отрицательной величиной");
                Console.ReadKey();

            }
            if (sec >= 59)
            {
                Console.WriteLine("Ошибка ввода");
                Console.ReadKey();

            }
            else
            {
                //
            }
            int s = (hour * 3600) + (minut * 60) + sec;
            int corner = (s / 10) % 360;
            Console.WriteLine($"Угол стрелки часов ={corner} градусов(-а)");
            Console.ReadKey();


        }
        public static void Ex27()
        {
            int hour, minutes = 0;
            var alp = Double.Parse(Console.ReadLine());
            hour = (int)(alp / (2 * Math.PI / 12));// целых часов
            var m1 = 2 * Math.PI / 60;// угол одной минуты для минутной стрелки
            var step = (2 * Math.PI / 12) / 60;// угол одной минуты в пределах часа, для часовой стрелки
            var min_h = (2 * Math.PI / 12) * hour; // угол целого часа

            while (min_h < alp) // пока угол не достигнет введенного значения
            {
                min_h += step; // улол увеличиваем
                minutes++; // считаем минуты
            }
            if (minutes == 60) // если введено пограничное значение
            {
                minutes = 0; // обнуляем минуты
                hour++; // увеличиваем часы
            }

            Console.WriteLine(hour);
            Console.WriteLine(minutes);
            Console.WriteLine(minutes * m1);
            Console.ReadKey();
        }
        public static void Ex28()
        {
            Console.WriteLine("Задача28:вывести минимальное по модулю число");
            int n = 3;
            int x = 0;
            double[] numbers = new double[n];
            while (x < n)
            {
                Console.WriteLine("Введите число №" + x);
                numbers[x] = double.Parse(Console.ReadLine());
                ++x;
            }
            for (int i = 0; i < numbers.Length; i++) ;
            double min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
                if (Math.Abs(numbers[i]) < Math.Abs(min))
                {
                    min = numbers[i];
                }
            Console.WriteLine("Минимальный по модулю элемент: {0}", min);
            Console.ReadKey();
        }
        public static void Ex29()
        {
            int max, min = 0;
            Console.WriteLine("Задача29:найти сумму большего и меньшего из трех заданных чисел");
            Console.WriteLine("Введите первое число:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            int z = int.Parse(Console.ReadLine());
            if (x > y)
            {
                max = x;
            }
            else
            {
                max = y;
            }
            if (z > max)
            {
                max = z;
            }
            if (x < y)
            {
                min = x;
            }
            else
            {
                min = y;
            }
            if (z < min)
            {
                min = z;
            }
            int summ = max + min;
            Console.WriteLine("Сумма максимального и минимального числа ={0}", summ);
            Console.ReadKey();


        }
        public static void Ex30()
        {
            Console.WriteLine("Задача30:найти число натуральных делителей");
            Console.WriteLine("Введите натуральное число:");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int i = 0;
            while (i < n)
            {
                i++;
                if (n % i == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }



        public static void Ex31()
        {
            Console.WriteLine("Задача31:найти корни кубического уравнения");
            Console.Write("a=");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("c=");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("d=");
            int d = Int32.Parse(Console.ReadLine());
            for (int x = -100; x <= 100; x++)
            {
                double result = a * Math.Pow(x, 3) + b * x * x + c * x + d;
                if (result == 0)
                {
                    Console.WriteLine("X = " + x);
                }

            }
            Console.ReadKey();
        }

        public static void Ex32()
        {
            Console.WriteLine("Задача32:поиск элемента прогресси по ее номеру");
            Console.Write("Введите первый элемент прогрессии:x1=");
            int x1 = int.Parse(Console.ReadLine());
            Console.Write("Введите второй элемент прогрессии:x2=");
            int x2 = int.Parse(Console.ReadLine());
            Console.Write("Введите номер элемента,который хотите найти:num=");
            int num = int.Parse(Console.ReadLine());
            int d = x2 - x1;
            int ans = x1 + d * (num - 1);
            Console.WriteLine("Искомый элемент прогрессии:{0}", ans);
            Console.ReadKey();

        }
        public static void Ex33()
        {
            Console.WriteLine("Задача33:выдавать кредит изходя из введенной пользователем информации");
            Console.WriteLine("Вы пенсионер или студент?Введите слово полностью, или введите оба слова через союз и.Вводить с маленькой буквы");
            string x = Console.ReadLine();
            Console.WriteLine("Вы трудоустроены?Введите да или нет.");
            string y = Console.ReadLine();
            if (((x == "пенсионер") && (y == "нет")) || ((x == "студент") && (y == "нет")))
            {
                Console.WriteLine("Вам одобрен кредит");
                Console.ReadKey();
            }
            else if (((x == "пенсионер и студент") || (x == "студент и пенсионер")) || ((x == "пенсионер") && (y == "да")) || ((x == "студент") && (y == "да")))
            {
                Console.WriteLine("Вам не одобрен кредит");
                Console.ReadKey();
            }


        }
        public static void Ex34a()
        {
            Console.WriteLine("Задача34a:повторяет введенное пользователем имя на экране");
            Console.Write("Введите свое имя:");
            string x = Console.ReadLine();
            Console.WriteLine("Ваше имя:{0}", x);
            Console.ReadKey();
        }
        public static void Ex34b()
        {
            Console.WriteLine("Задача34b:повторяет введенное пользователем имя на экране с приветствием");
            Console.Write("Введите свое имя:");
            string x = Console.ReadLine();
            Console.WriteLine("Привет,{0}", x);
            Console.ReadKey();
        }
        public static void Ex35()
        {
            string str = "";
            //Цикл продолжается до тех пор пока пользователь не введёт "Привет"
            while (str != "Привет")
            {
                str = Console.ReadLine();
            }
            Console.WriteLine("Как тебя зовут?");
            var name = Console.ReadLine();
            Console.WriteLine("Привет, {0}", name);
            //Цикл продолжается до тех пор пока пользователь не введёт "Знаешь ли ты что-то о тайной комнате?"
            while (str != "Знаешь ли ты что-то о тайной комнате?")
            {
                str = Console.ReadLine();
            }
            Console.WriteLine("Да");
            //Цикл продолжается до тех пор пока пользователь не введёт "Можешь рассказать?"
            while (str != "Можешь рассказать?")
            {
                str = Console.ReadLine();
            }
            Console.WriteLine("Нет");
            Thread.Sleep(5000);//Заставляем программу остановиться на 5 секунд
            Console.WriteLine("но могу показать");
            Random random = new Random();
            var color = (ConsoleColor)random.Next(0, 15);//Генерируем случайное число от 0 до 15 и приводим его к типу ConsoleColor
            //ConsoleColor это enum тип, который хранит intы, потому мы можем так спокойно парсить int к ConsoleColor
            Console.BackgroundColor = color;//Тут присваеваем заднему фону консоли цвет
            Console.ReadKey();

        }
        public static void Ex36a()
        {
            Console.WriteLine("Задача36a:вычислить контрольную цифру штрихкода,12 цифр случайным образом");
            StringBuilder stringBuilder = new StringBuilder();
            Random rnd = new Random();
            //цикл продолжается пока длинна нашей строки не будет равна 12
            while (stringBuilder.Length != 12)
            {
                string value = rnd.Next(0, 10).ToString();//генерируем случайное число от 0 до 9
                stringBuilder.Append(value);//кладем это число в stringBuilder
            }
            var code = stringBuilder.ToString();//переводим stringBuilder в string
            Console.WriteLine(code);
            int sum = 0;
            //Находим сумму чисел которые стоят на четных позициях в code
            for (int i = 1; i < code.Length; i += 2)
                sum += code[i] - '0';
            sum *= 3;//умнжаем сумму на 3
            //Находим сумму чисел которые стоят на нечетных позициях в code
            int sum2 = 0;
            for (int i = 0; i < code.Length; i += 2)
                sum2 += code[i] - '0';

            sum += sum2;//находим сумму нечётных числел и чётных уможенных на три и записываем его в переменную sum
            //Находим ближайшее число, которое кратно 10 и больше sum и записываем его в sum2
            if (sum % 10 != 0)
                sum2 = (sum / 10) * 10 + 10;
            Console.WriteLine("Контрольная цифра штрихкода{0}", sum2 - sum);//разность этих значений и будет нашим результатом
            Console.ReadKey();
        }
        //программа, которая считывает код с консоли
        public static void Ex36b()
        {
            Console.WriteLine("Задача36a:вычислить контрольную цифру штрихкода,12 цифр вводит пользователь");

            StringBuilder stringBuilder = new StringBuilder();
            while (stringBuilder.Length != 12)
            {
                string value = Console.ReadLine();
                stringBuilder.Append(value);
            }
            var code = stringBuilder.ToString();
            Console.WriteLine(code);
            int sum = 0;
            for (int i = 1; i < code.Length; i += 2)
                sum += code[i] - '0';
            sum *= 3;
            int sum2 = 0;
            for (int i = 0; i < code.Length; i += 2)
                sum2 += code[i] - '0';
            sum += sum2;
            if (sum % 10 != 0)
                sum2 = (sum / 10) * 10 + 10;
            Console.WriteLine("Контрольная цифра штрихкода{0}", sum2 - sum);
            Console.ReadKey();
        }
    }
}
