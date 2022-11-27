var numbers = new[] { 12, 9, 10, 2, 43, 67, 45, 13, 6, 9, 1, 11 };
var avg = numbers.Where(x => x > 10).Average();

Console.WriteLine("Среднее арифметическое число: " + avg);