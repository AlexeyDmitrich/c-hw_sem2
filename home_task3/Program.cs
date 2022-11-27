// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели");
bool isDay = int.TryParse(Console.ReadLine(), out int day);
// если введено не число от 1 до 7, отказываемся от дальнейших проверок
if (!(isDay) || day < 1 || day > 7){
    Console.WriteLine("Это никак не номер дня недели");
} else {
    if (day < 6){
        Console.WriteLine("Обычный рабочий день");
    } else {
        Console.WriteLine("Выходной");
    } 
}
