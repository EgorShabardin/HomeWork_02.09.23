using System;

namespace ДЗ_02._09._23
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание №1. Программа выводит на экран три строки.
            Console.WriteLine("{0, 80}", "ЗАДАНИЕ №1. ПРОГРАММА ВЫВОДИТ НА ЭКРАН ТРИ СТРОКИ");
            Console.WriteLine();

            Console.Write("Мир ");
            Console.Write("Труд ");
            Console.WriteLine("Май");

            Console.WriteLine("Мир");
            Console.WriteLine("{0, 12}", "Труд");
            Console.WriteLine("{0, 20}", "Май");


            // Задание №2. Программа получает два числа, меняет их местами и выводит на экран.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 98}", "ЗАДАНИЕ №2. ПРОГРАММА ПОЛУЧАЕТ ДВА ЧИСЛА, МЕНЯЕТ ИХ МЕСТАМИ И ВЫВОДИТ НА ЭКРАН");
            Console.WriteLine();

            double firstNumber, secondNumber;
            bool firstResult, secondResult;

            Console.Write("Введите первое число: ");
            firstResult = double.TryParse(Console.ReadLine(), out firstNumber);
            Console.Write("Введите второе число: ");
            secondResult = double.TryParse(Console.ReadLine(), out secondNumber);

            if (firstResult && secondResult)
            {
                Console.WriteLine("Числа поменялись местами");
                Console.WriteLine($"Первое число: {secondNumber} Второе число: {firstNumber}");
            }
            else
            {
                Console.WriteLine("Вы неверно ввели число! В дробном числе необходимо использовать ',', а не '.'");
            }


            // Задание №3. Прогрмма вычисляет длину окружности и площадь круга.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 90}", "ЗАДАНИЕ №3. ПРОГРАММА ВЫЧИСЛЯЕТ ДЛИНУ ОКРУЖНОСТИ И ПЛОЩАДЬ КРУГА");
            Console.WriteLine();

            double radius, length, square;

            Console.Write("Введите радиус окружности: ");
            radius = double.Parse(Console.ReadLine());

            length = 2 * Math.PI * radius;
            square = Math.PI * radius * radius;

            Console.WriteLine($"Длина окружности: {length},  площадь круга: {square}");


            // Задание №4. Программа находит значение y=cos(x).
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 82}", "ЗАДАНИЕ №4. ПРОГРАММА НАХОДИТ ЗНАЧЕНИЕ y=cos(x)");
            Console.WriteLine();

            double argument, result;

            Console.Write("Введите значение аргумента (значение переменной x) в радианах: ");
            argument = double.Parse(Console.ReadLine());

            result = Math.Cos(argument);

            Console.WriteLine("При x = " + argument + " радиан значение y=cos(x) будет " + result);


            // Задание №5. Программа находит корни квадратного уравнения.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 84}", "ЗАДАНИЕ №5. ПРОГРАММА НАХОДИТ КОРНИ КВАДРАТНОГО УРАВНЕНИЯ");
            Console.WriteLine();

            double coefficientA, coefficientB, coefficientC;
            double discriminant, x1, x2, x;

            Console.Write("Введите коэффициент A: ");
            coefficientA = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент B: ");
            coefficientB = double.Parse(Console.ReadLine());
            Console.Write("Введите коэффициент С: ");
            coefficientC = double.Parse(Console.ReadLine());

            discriminant = (coefficientB * coefficientB) - (4 * coefficientA * coefficientC);

            if (discriminant > 0)
            {
                x1 = (-coefficientB + Math.Sqrt(discriminant)) / (2 * coefficientA);
                x2 = (-coefficientB - Math.Sqrt(discriminant)) / (2 * coefficientA);
                Console.WriteLine("Первый корень: " + x1);
                Console.WriteLine("Второй корень: " + x2);
            }
            else if (discriminant == 0)
            {
                x = (-coefficientB) / (2 * coefficientA);
                Console.WriteLine("Единственный корень: " + x);
            }
            else
            {
                Console.WriteLine("Дискриминант меньше нуля. Корней нет.");
            }


            // Задание №6. Программа обменивает значение трех переменных.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 84}", "ЗАДАНИЕ №6. ПРОГРАММА ОБМЕНИВАЕТ ЗНАЧЕНИЯ ТРЕХ ПЕРЕМЕННЫХ");
            Console.WriteLine();

            double a, b, c, d;

            Console.WriteLine("Первая схема:");

            Console.Write("Введите значение переменной a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной c: ");
            c = double.Parse(Console.ReadLine());
            d = c;
            c = a;
            a = b;
            b = d;
            Console.WriteLine($"Переменная a: {a}, переменная b: {b}, переменная c: {c}");

            Console.WriteLine("Вторая схема:");

            Console.Write("Введите значение переменной a:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной b:");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите значение переменной c:");
            c = double.Parse(Console.ReadLine());
            d = a;
            a = c;
            c = b;
            b = d;
            Console.WriteLine($"Переменная a: {a}, переменная b: {b}, переменная c: {c}");


            // Задание №7. Программа генерирует случайные числа и выводит их на экран
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 88}", "ЗАДАНИЕ №7. ПРОГРАММА ГЕНЕРИРУЕТ СЛУЧАЙНЫЕ ЧИСЛА И ВЫВОДИТ ИХ НА ЭКРАН");
            Console.WriteLine();

            int firstValue, secondValue, thirdValue, fourthValue;
            Random RandomNumbers = new Random();

            firstValue = RandomNumbers.Next(100);
            secondValue = RandomNumbers.Next(100);
            thirdValue = RandomNumbers.Next(100);
            fourthValue = RandomNumbers.Next(100);

            Console.WriteLine($"Первое число: {firstValue}");
            Console.WriteLine($"Второе число: {secondValue}");
            Console.WriteLine($"Третье число: {thirdValue}");
            Console.WriteLine($"Четвертое число: {fourthValue}");


            // Задание №8. Программа получает одно трехзначное число и преобразует его в другое.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 96}", "ЗАДАНИЕ №8. ПРОГРАММА ПОЛУЧАЕТ ОДНО ТРЕХЗНАЧЕНИЕ ЧИСЛО И ПРЕОБРАЗУЕТ ЕГО В ДРУГОЕ");
            Console.WriteLine();

            int value;

            Console.Write("Введите трехзначное число: ");
            value = int.Parse(Console.ReadLine());

            firstValue = value / 100;
            secondValue = (value - firstValue * 100) / 10;
            thirdValue = value - (firstValue * 100) - (secondValue * 10);

            Console.WriteLine("Преобразованное число: " + thirdValue + firstValue + secondValue);


            // Задание №9. Программа находит стоимость всей покупки.
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("{0, 81}", "ЗАДАНИЕ №9. ПРОГРАММА НАХОДИТ СТОИМОСТЬ ВСЕЙ ПОКУПКИ");
            Console.WriteLine();

            double firstProduct, secondProduct, thirdProduct, summ;

            double firstPrice = 429;
            double secondPrice = 300;
            double thirdPrice = 40;

            Console.Write("Сколько килограмм конфет купили: ");
            firstProduct = double.Parse(Console.ReadLine());
            Console.Write("Сколько килограмм печенья купили: ");
            secondProduct = double.Parse(Console.ReadLine());
            Console.Write("Сколько килограмм яблок купили: ");
            thirdProduct = double.Parse(Console.ReadLine());


            summ = (firstProduct * firstPrice) + (secondProduct * secondPrice) + (thirdProduct * thirdPrice);

            Console.WriteLine($"Если купить {firstProduct} кг конфет, {secondProduct} кг печенья и {thirdProduct} кг яблок, нужно заплатить {summ} рублей");
        }
    }
}
