// Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

// Программа находит любую цифру в любом int числе меньше лярда, ежели она там есть)

// метод для быстрого вывода текстовых замечаний в консоль
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

/*  этот метод принимает на вход целое число и порядковый номер искомого,
    определяет разряд числа, 
    смотрит, есть ли в нем вообще столько цифр, если нет - возвращает 
    отрицательный разряд (для наглядного вывода), если цифр для расчета хватает -
    метод расчитывает первое число, а затем в цикле убирает его, пока не дойдет до 
    искомой цифры, которую уже возвращает.
    В методе закомментированы отладочные строки, если их раскомментировать - 
    будет прослеживаться логика каждого шага работы метода.
*/
int secNum (int num,  int searchNum ) {    // принимает целое число и число для поиска
    int res = 0;  // предполагаемый результат
    int range = 0;   // разряд
    int seek = 1;    // порядковый номер искомого числа
    int tempToRange = md(num);  // временный дубликат числа для потрошения на разряд
    int tempToSeek = md(num); // временный дубликат числа для потрошения на поиск
    while (tempToRange != 0){
        tempToRange = tempToRange / 10;
    //  Console.WriteLine($"Уменьшенное число {search}");
        range++;
    //  Console.WriteLine($"Предполагаемый разряд {range}");
    }
    if (searchNum > range) {
        prt("В этом числе нет таких цифр");
        return range*(-1);
    } else {    
        while (!(seek > searchNum)){
    //        prt("======================");
    //        Console.WriteLine($"работаем с числом = {tempToSeek}");
    //        Console.WriteLine($"Разряд числа = {range}");
            int firstRng = Convert.ToInt32(Math.Pow(10, (range-1)));
    //        Console.WriteLine($"кратность {firstRng}");
            res = tempToSeek / firstRng;
    //        Console.WriteLine($"первое число = {res}");
            int res2 = (tempToSeek - firstRng*res);
    //        Console.WriteLine($"число без первого разряда {res2}");
            tempToSeek = res2;
            seek++;
            range--;
    //        Console.WriteLine($"искомое число = {res}");
        }
    }
    return md(res);
}

// приглашение к вводу числа
prt("Введите число. Целое.");
bool isInt = int.TryParse(Console.ReadLine(), out int num);
// я обратил внимание, что int в этом подходе не может принять число тяжелее 9 знаков
if (!isInt){
    prt("Это что угодно, но только не целое число");
} 

//если число адекватное: 
else {
    prt("какую по счёту цифру ищем?");
    bool isCount = int.TryParse(Console.ReadLine(), out int seek);
    if (!isCount || seek <= 0){
        prt("Это не похоже на место цифры в числе");
        // todo: добавить аварийный выход
    } 
    
    // если можно найти цифру по запросу пользователя:
    else {
//        Console.WriteLine($"Модуль числа  для обработки = {md(num)}");
        int needNum = secNum(num, seek);   // ключевая строка
        if (!(needNum < 0)) {
            Console.WriteLine($"{seek}-я цифра в числе {num} равна {needNum}");
        } 
        
        // если порядковый номер цифры выпадает за пределы числа:
        else {
            Console.WriteLine($"В числе {num} всего {md(needNum)} цифр");
        }
    }
}