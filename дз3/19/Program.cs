// Задача 19: Напишите программу, которая принимается на 
// пятизначное число и возникает, если оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите число: ");
string? number = Console.ReadLine();

void CheckingNumber(string number){
  if (number[0]==number[4] || number[1]==number[3]){
    Console.WriteLine($"Ваше число: {number} - да");
  }
  else Console.WriteLine($"Ваше число: {number} - нет");
}

if (number!.Length == 5){
  CheckingNumber(number);
}
else Console.WriteLine($"Введи правильное число");
