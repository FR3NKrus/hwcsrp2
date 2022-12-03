// Домашняя работа №2 по C#


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
void Second (int num){
    int secNum = num / 10 % 10;
    Console.WriteLine(secNum);
}
Console.WriteLine("Введите трёхзначное число: ");
Second (Convert.ToInt32(Console.ReadLine()));

// 456 -> 5
// 782 -> 8
// 918 -> 1


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
void Third (int num){
    if (num < 100)
        Console.WriteLine("Третьей цифры нет :(");
    else {
        while (num > 1000)
            num /= 10;
            Console.WriteLine($"Третья цифру заданного числа: {num % 10}");
    }   
}
Console.WriteLine("Введите число: ");
Third (Convert.ToInt32(Console.ReadLine()));

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
void Weekend (int weekend){
    if (weekend <1 || weekend > 7)
        Console.WriteLine("Такого дня в неделе не существует");
    else if (weekend > 5)
        Console.WriteLine("Выходной день");
    else 
        Console.WriteLine("Будний день");
}
Console.WriteLine("Введите день недели от (1 до 7): ");
Weekend (Convert.ToInt32(Console.ReadLine()));

// 6 -> да
// 7 -> да
// 1 -> нет
