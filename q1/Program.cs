// вывести случ 3зн число и убрать 2ю цифру из него

Random rnd = new Random();

int num = rnd.Next(100,1000);
int first = num / 100;
int last = num % 10;
int res = (first * 10)+last;

Console.WriteLine(num);
Console.WriteLine(res);