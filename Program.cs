// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();

if(number.Length != 5) {
    Console.WriteLine("Число {number} не является пятизначным");
    return;
}

bool isPolindrom = true;
for(int i = 0, j = number.Length - 1; i < 5 && j > 0; i++, j--) {
    if(number[i] != number[j]) {
        isPolindrom = false;
        break;
    }
}

Console.WriteLine($"{number} -> {(isPolindrom ? "да" : "нет")}");