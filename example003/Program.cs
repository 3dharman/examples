// Начало
// Определить первое число
// Определить второе число
// Вывести сумму введеных чисел
// Конец
// new Random().Next(min, max) даёт случайное целое от min до max

int numberA = new Random().Next(1, 10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1, 10);
Console.WriteLine(numberB);
int result = numberA + numberB;
Console.WriteLine(result);
