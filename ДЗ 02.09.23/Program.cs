using System;

namespace ДЗ_02._09._23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание №1. Программа выводит на экран три строки.
            Console.WriteLine("{0, 80}", "ЗАДАНИЕ №1. ПРОГРАММА ВЫВОДИТ НА ЭКРАН ТРИ СТРОКИ\n");

            Console.Write("Мир ");
            Console.Write("Труд ");
            Console.WriteLine("Май");

            Console.WriteLine("Мир");
            Console.WriteLine("{0, 12}", "Труд");
            Console.WriteLine("{0, 20}", "Май");


            // Задание №2. Программа получает два числа, меняет их местами и выводит на экран.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 98}", "ЗАДАНИЕ №2. ПРОГРАММА ПОЛУЧАЕТ ДВА ЧИСЛА, МЕНЯЕТ ИХ МЕСТАМИ И ВЫВОДИТ НА ЭКРАН\n");

            double firstNumber, secondNumber, thirdNumber;
            bool firstResult, secondResult;

            Console.Write("Введите первое число: ");
            firstResult = double.TryParse(Console.ReadLine(), out firstNumber);
            Console.Write("Введите второе число: ");
            secondResult = double.TryParse(Console.ReadLine(), out secondNumber);

            if (firstResult && secondResult)
            {
                thirdNumber = firstNumber;
                firstNumber = secondNumber;
                secondNumber = thirdNumber;

                Console.WriteLine("\nЧисла поменялись местами: ");
                Console.WriteLine($"Первое число: {firstNumber} Второе число: {secondNumber}");
            }
            else
            {
                Console.WriteLine("\nВы ввели не число! В дробном числе необходимо использовать запятую, а не точку!");
            }


            // Задание №3. Прогрмма вычисляет длину окружности и площадь круга.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 90}", "ЗАДАНИЕ №3. ПРОГРАММА ВЫЧИСЛЯЕТ ДЛИНУ ОКРУЖНОСТИ И ПЛОЩАДЬ КРУГА\n");

            double radius, length, square;
            bool parseResult;

            Console.Write("Введите радиус окружности: ");
            parseResult = double.TryParse(Console.ReadLine(), out radius);

            if (parseResult)
            {
                length = 2 * Math.PI * radius;
                square = Math.PI * radius * radius;

                Console.WriteLine($"\nДлина окружности: {length},  площадь круга: {square}");
            }
            else
            {
                Console.WriteLine("\nВы ввели не число! В дробном числе необходимо использовать запятую, а не точку!");
            }


            // Задание №4. Программа находит значение y=cos(x).
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 82}", "ЗАДАНИЕ №4. ПРОГРАММА НАХОДИТ ЗНАЧЕНИЕ y=cos(x)\n");

            double argument, result;

            Console.Write("Введите значение аргумента (значение переменной x) в радианах: ");
            parseResult = double.TryParse(Console.ReadLine(), out argument);

            if (parseResult)
            {
                result = Math.Cos(argument);
                Console.WriteLine($"\nПри x = {argument} радиан значение y=cos(x) будет {result}");
            }
            else
            {
                Console.WriteLine("\nВы ввели не число! В дробном числе необходимо использовать запятую, а не точку!");
            }


            // Задание №5. Программа находит корни квадратного уравнения.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 84}", "ЗАДАНИЕ №5. ПРОГРАММА НАХОДИТ КОРНИ КВАДРАТНОГО УРАВНЕНИЯ\n");

            double coefficientA, coefficientB, coefficientC;
            double discriminant, x1, x2, x;
            bool resultA, resultB, resultC;

            Console.Write("Введите коэффициент A: ");
            resultA = double.TryParse(Console.ReadLine(), out coefficientA);
            Console.Write("Введите коэффициент B: ");
            resultB = double.TryParse(Console.ReadLine(), out coefficientB);
            Console.Write("Введите коэффициент С: ");
            resultC = double.TryParse(Console.ReadLine(), out coefficientC);

            if (resultA && resultB && resultC)
            {
                discriminant = (coefficientB * coefficientB) - (4 * coefficientA * coefficientC);

                if (discriminant > 0)
                {
                    x1 = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);
                    x2 = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);
                    Console.WriteLine("\nПервый корень: " + x1);
                    Console.WriteLine("Второй корень: " + x2);
                }
                else if (discriminant == 0)
                {
                    x = (-coefficientB) / (2 * coefficientA);
                    Console.WriteLine("\nЕдинственный корень: " + x);
                }
                else
                {
                    Console.WriteLine("\nДискриминант меньше нуля. Корней нет.");

                }
            }
            else
            {
                Console.WriteLine("\nВы ввели не число! В дробном числе необходимо использовать запятую, а не точку!");
            }


            // Задание №6. Программа обменивает значение трех переменных.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 84}", "ЗАДАНИЕ №6. ПРОГРАММА ОБМЕНИВАЕТ ЗНАЧЕНИЯ ТРЕХ ПЕРЕМЕННЫХ\n");

            double a, b, c, d;

            Console.WriteLine("Первая схема:");

            Console.Write("Введите значение переменной a: ");
            resultA = double.TryParse(Console.ReadLine(), out a);
            Console.Write("Введите значение переменной b: ");
            resultB = double.TryParse(Console.ReadLine(), out b);
            Console.Write("Введите значение переменной c: ");
            resultC = double.TryParse(Console.ReadLine(), out c);

            if (resultA && resultB && resultC)
            {
                d = c;
                c = a;
                a = b;
                b = d;

                Console.WriteLine($"\nПеременная a: {a}, переменная b: {b}, переменная c: {c}");
            }
            else
            {
                Console.WriteLine("\nВы ввели не число! В дробном числе необходимо использовать запятую, а не точку!");
            }

            Console.WriteLine("\nВторая схема:");

            Console.Write("Введите значение переменной a: ");
            resultA = double.TryParse(Console.ReadLine(), out a);
            Console.Write("Введите значение переменной b: ");
            resultB = double.TryParse(Console.ReadLine(), out b);
            Console.Write("Введите значение переменной c: ");
            resultC = double.TryParse(Console.ReadLine(), out c);

            if (resultA && resultB && resultC)
            {
                d = a;
                a = c;
                c = b;
                b = d;

                Console.WriteLine($"\nПеременная a: {a}, переменная b: {b}, переменная c: {c}");
            }
            else
            {
                Console.WriteLine("\nВы ввели не число! В дробном числе необходимо использовать запятую, а не точку!");
            }


            // Задание №7. Программа генерирует случайные числа и выводит их на экран
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 88}", "ЗАДАНИЕ №7. ПРОГРАММА ГЕНЕРИРУЕТ СЛУЧАЙНЫЕ ЧИСЛА И ВЫВОДИТ ИХ НА ЭКРАН\n");

            int firstValue, secondValue, thirdValue, fourthValue;
            Random RandomNumbers = new Random();

            firstValue = RandomNumbers.Next(100);
            secondValue = RandomNumbers.Next(100);
            thirdValue = RandomNumbers.Next(100);
            fourthValue = RandomNumbers.Next(100);

            Console.WriteLine($"Первое число: {firstValue} \nВторое число: {secondValue} \nТретье число: {thirdValue} \nЧетвертое число: {fourthValue}");


            // Задание №8. Программа получает одно трехзначное число и преобразует его в другое.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 96}", "ЗАДАНИЕ №8. ПРОГРАММА ПОЛУЧАЕТ ОДНО ТРЕХЗНАЧЕНОЕ ЧИСЛО И ПРЕОБРАЗУЕТ ЕГО В ДРУГОЕ\n");

            int value;

            Console.Write("Введите трехзначное число: ");
            parseResult = int.TryParse(Console.ReadLine(), out value);

            if (parseResult && Math.Floor((double)value / 100) != 0)
            {
                firstValue = value / 100;
                secondValue = (value - firstValue * 100) / 10;
                thirdValue = value - (firstValue * 100) - (secondValue * 10);

                Console.WriteLine("\nПреобразованное число: " + thirdValue + firstValue + secondValue);
            }
            else
            {
                Console.WriteLine("\nВы ввели не число или оно не является трехзначным, или оно является дробным!");
            }


            // Задание №9. Программа находит стоимость всей покупки.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 81}", "ЗАДАНИЕ №9. ПРОГРАММА НАХОДИТ СТОИМОСТЬ ВСЕЙ ПОКУПКИ\n");

            double firstProduct, secondProduct, thirdProduct, summ;
            bool thirdResult;

            double firstPrice = 429;
            double secondPrice = 300;
            double thirdPrice = 40;

            Console.Write("Сколько килограмм конфет купили: ");
            firstResult = double.TryParse(Console.ReadLine(), out firstProduct);
            Console.Write("Сколько килограмм печенья купили: ");
            secondResult = double.TryParse(Console.ReadLine(), out secondProduct);
            Console.Write("Сколько килограмм яблок купили: ");
            thirdResult = double.TryParse(Console.ReadLine(), out thirdProduct);

            if (firstResult && secondResult && thirdResult)
            {
                summ = (firstProduct * firstPrice) + (secondProduct * secondPrice) + (thirdProduct * thirdPrice);

                Console.WriteLine($"\nЕсли купить {firstProduct} кг конфет, {secondProduct} кг печенья и {thirdProduct} кг яблок, нужно заплатить {summ} рублей\n");
            }
            else
            {
                Console.WriteLine("\nВы ввели не число! В дробном числе необходимо использовать запятую, а не точку!");
            }
        }
    }
}
