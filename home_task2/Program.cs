// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


void prt (string text){
    Console.WriteLine(text);
}

int md (int num){
    if (num >= 0){
        return num;
    } else {
        return (num * (-1));
    }
}

// Делаю метод для определения кратности числа.
int Range (int num){    // принимает целое число
    int range = 0;
    while (num != 0){
        num = num / 10;
        Console.WriteLine(num);
        range++;
    }
    return range;   // метод возвращает разряд числа
}


prt("Введите число. Целое.");
bool isInt = int.TryParse(Console.ReadLine(), out int num);
if (!isInt){
    prt("Это что угодно, но только не целое число");
} else {
    num = md(num);
}
Console.WriteLine(Range(num));
