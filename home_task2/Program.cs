// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


void prt (string text){
    Console.WriteLine(text);
}

// расчет модуля числа для работы с отрицательными вводными
int md (int num){
    if (num >= 0){
        return num;
    } else {
        return (num * (-1));
    }
}

int secNum (int num){    // принимает целое число
    int range = 0;
    while (num != 0){
        num = num / 10;
        Console.WriteLine($"Уменьшенное число {num}");
        range++;
        Console.WriteLine($"Предполагаемый разряд {range}");
        if (range == 4){
            int res = (num % 10);
            return res;
            Console.WriteLine($"Второе число {res}");
        }
    }
    return range;
    Console.WriteLine($"Разряд числа = {range}");
}

prt("Введите число. Целое.");
bool isInt = int.TryParse(Console.ReadLine(), out int num);
if (!isInt){
    prt("Это что угодно, но только не целое число");
    // todo: добавить аварийный выход
} else {
    num = md(num);
    Console.WriteLine($"Модуль числа  для обработки = {md(num)}");
    Console.WriteLine($"Второе число {secNum(num)}");
}
