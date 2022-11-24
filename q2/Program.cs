// принимаем два числа, проверяем, кратность

Console.WriteLine("Введите число");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите ещё число");
int num2 = int.Parse(Console.ReadLine());

if (num1 % num2 == 0) {
    Console.WriteLine ("Числа кратны");
} else {
    Console.WriteLine ("Числа не кратны");
    Console.Write("Остаток: ");
    onsole.WriteLine (num1 % num2);
}