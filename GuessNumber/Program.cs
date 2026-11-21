﻿// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 0) {
//     Console.WriteLine("Число положительное!");
// }
// else if (number < 0) {
//     Console.WriteLine("Число отрицательное!");
// }
// else {
//     Console.WriteLine("Число равно нулю!");
// }


// Console.Write("Введите баллы от 0 до 100: ");
// int score = int.Parse(Console.ReadLine());
// if (score >= 91) {
//     Console.WriteLine("Оценка Отлично (5)");
// }
// else if (score >= 71) {
//     Console.WriteLine("Оценка Хорошо (4)");
// }
// else if (score >= 51) {
//     Console.WriteLine("Оценка Удовлетворительно (3)");
// }
// else {
//     Console.WriteLine("Оценка Неудовлетворительно (2)");
// }


// Console.Write("Введите количество посещений (из 19): ");
// int attendance = int.Parse(Console.ReadLine());
// Console.Write("Введите средний балл по практике: ");
// double practiceGpa = double.Parse(Console.ReadLine());
// bool goodAttendance = attendance >= 14;
// bool goodGrades = practiceGpa >= 3.0;
// if (goodAttendance && goodGrades) {
//     Console.WriteLine("+ Допуск к экзамену разрешён.");
// }
// else if (!goodAttendance && goodGrades) {
//     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// }
// else if (goodAttendance && !goodGrades) {
//     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// }
// else {
//     Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// }


// string result2 = score >= 60 ? "Зачет" : "Незачет";
// Console.WriteLine(result2);


// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "совершеннолетний" : " несовершеннолетний";
// Console.WriteLine($"Вы {ageGroup}.");
// Console.Write("\nВведите температуру за окном (°C): ");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// Console.WriteLine($"За окном {weather}.");
// Console.Write("\nВведите число: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "чётное" : "нечётное";
// Console.WriteLine($"Число {n} - {parity}.");

// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");
// string choice = Console.ReadLine();
// switch (choice) {
//     case "1":
//         Console.WriteLine("Расписание: исп-241, каб. 303, 08:30");
//         break;
//     case "2":
//         Console.WriteLine("Ваши оценки: ИРСПО - 20, РМП - 35,");
//         break;
//     case "3":
//         Console.WriteLine("Email: denis.leontev92@yandex.ru");
//         break;
//     case "4":
//         Console.WriteLine("До свидания!");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
//         break;
// }
// Console.Write("\nВведите номер дня недели (1-7): "); int dayNumber = int.Parse(Console.ReadLine());
// switch (dayNumber) {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Рабочий день - пора учиться!");
//         break;
//     case 6:
//     case 7:
//         Console.WriteLine("Выходной - заслуженный отдых.");
//         break;
//     default:
//         Console.WriteLine("Такого дня не существует.");
//         break;
// }
// Console.Write("\nВведите номер месяца (1-12): ");
// int monthNumber = int.Parse(Console.ReadLine());
// switch (monthNumber) {
//     case 1:
//     case 2:
//     case 12:
//         Console.WriteLine("Зима");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Весна");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("Лето");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("Осень");
//         break;
//     default:
//         Console.WriteLine("Ошибка, введите номер месяца от 1 до 12");
//         break;
// }
//
//
//Random random = new Random();
//int secret = random.Next(1, 101);
//int attempts = 0;
//bool guessed = false;
//Console.WriteLine("Угадай число от 1 до 100");
//Console.WriteLine("Я загадал число, попробуй угадать!");
//while (!guessed) {
//    Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
//    string input = Console.ReadLine();
//    if (!int.TryParse(input, out int guess)) {
//        Console.WriteLine("!!! Введи целое число, а не текст !!!");
//        continue;
//    }
//    if (guess < 1 || guess > 100) {
//        Console.WriteLine("!!! Введи должно быть от 1 до 100");
//        continue;
//    }
//    attempts++;
//    if (guess < secret) {
//        int diff = secret - guess;
//        string hint = GetHint(diff);
//        Console.WriteLine($"⬆ Больше! {hint}\n");
//    }
//    else if (guess > secret) {
//        int diff = guess - secret;
 //       string hint = GetHint(diff);
 //       Console.WriteLine($"⬇ Меньше! {hint}\n");
   // }
    //else {
//        guessed = true;
//    }
//}
//string result = attempts <= 7 ? $"Отличный результат! Всего {attempts} попыток!"
//: $"Число найдено за {attempts} попыток. Можно лучше!";
//Console.WriteLine($"🎉 Правильно! Заданное число: {secret}");
//Console.WriteLine($"{result}");
//string GetHint(int difference) {
//    switch (difference) {
//        case <= 3:
//            return "🔥 Горячо";
//        case <= 10:
//            return "🌡 Тепло";
//        case <= 25:
//            return "🧊 Прохладно";
//        default:
//            return "❄ Холодно";
//    }
//}
﻿// Задание 1

using System.Globalization;

Console.Write("Введите пароль первый раз: ");
string pass1 = Console.ReadLine();
Console.Write("Введите пароль второй раз: ");
string pass2 = Console.ReadLine();
if (pass1 == pass2)
{
    Console.WriteLine("Пароль принят");
}
else
{
    Console.WriteLine("Пароль не принят");
}

Console.WriteLine("");
// Задание 2

Console.Write("Введите ваш возраст: ");
int age = int.Parse(Console.ReadLine());
if (age >= 18)
{
    Console.WriteLine("Доступ разрешён");
}
else
{
    Console.WriteLine("Доступ запрещён");
    Console.WriteLine("");
}

Console.WriteLine("");
// Задание 3

 Console.WriteLine("Калькулятор");
Console.Write("Введите число 1: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
double num2 = double.Parse(Console.ReadLine());
Console.Write("Введите операцию (+, -, *, /): ");
string operation = Console.ReadLine();
switch (operation)
{
    case "+":
        Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        break;
    case "-":
        Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        break;
    case "*":
        Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        break;
    case "/":
        Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        break;
    default:
        Console.WriteLine("Такой операции нет. Выберите из (+, -, *, /). ");
        break;
}

Console.WriteLine("");
// Задание 4

Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
int sum = 0;
if (number1 >= 0)
{
    sum += number1;
}
if (number2 >= 0)
{
    sum += number2;
}
if (number3 >= 0)
{
    sum += number3;
}
Console.WriteLine($"Сумма положительных чисел из этих трёх = {sum}");

Console.WriteLine("");
//Задание 5
Console.WriteLine("Путешествие в Темный лабиринт");
Console.WriteLine("Вы стоите перед первой дверью. Перед вами два пути - Путь A и Путь B");
Console.Write("Выберить путь (A или B): ");
string choice = Console.ReadLine().ToUpper();
if (choice == "A")
{
    Console.WriteLine($"Вы вошли в комнату с огромным драконом.");
    Console.WriteLine("Вам нужно будет ответить на загадку дракона: ");
    Console.WriteLine("Дракон говорит: «Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.»");
    Console.Write("Ваш ответ: ");
    string otv1 = Console.ReadLine().ToLower();
    if (otv1 == "рыба")
    {
        Console.WriteLine("Правильно! Дракон открывает дверь в следующую комнату."); 
    }
    else
    {
        Console.WriteLine("Неправильно! Дракон съедает вас.");
    }
}
else if (choice == "B")
{
    Console.WriteLine("\nВы вошли в тёмную комнату с двумя дверями.");
    Console.WriteLine("Дверь 1: За ней скрыты сокровища Dungeon Master'а.");
    Console.WriteLine("Дверь 2: За ней — ловушка с ядовитыми шипами.");
    Console.Write("Какую дверь вы выберете? (1 или 2): ");
    string choice2 = Console.ReadLine();
    if (choice2 == "1")
    {
        Console.WriteLine("Вы выбрали правильную дверь и получили сокровища!");
    }
    else if (choice2 == "2")
    {
        Console.WriteLine("Вы попали в ловушку с ядовитыми шипами!");
    }
    else
    {
        Console.WriteLine("Неверный ввод. Вы стоите в нерешительности, и время уходит.");
    }
}
else
{
    Console.WriteLine("Неверный выбор. Вы не решились сделать шаг.");
}
    