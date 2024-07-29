// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using ExampleApp;
using System.Numerics;

var calculator1 = new Calculator<NumberInt, NumberDouble>();
Console.WriteLine($"1 + 1 = {calculator1.Add(new NumberInt(1), new NumberDouble(1))}");

var calculator2 = new Calculator<NumberDouble, NumberInt>();
Console.WriteLine($"1.5 + 1 = {calculator2.Add(new NumberDouble(1.5), new NumberInt(1))}");

//Console.WriteLine($"The max date of next month is {GetNextMonthMaxDate()}");
//Console.WriteLine("\n");
//Console.WriteLine($"Total Odd Number : {CountTotalOddNumbers(new int[] { 1, 2, 3})}");
//Console.WriteLine("\n");
//var arr1 = new string[]{"test", "test1"};
//var arr2 = new string[] { "test", "test2" };
//Console.WriteLine($"Unique Array: {string.Join(", ", UniqueNames(arr1, arr2))}");
//Console.ReadLine();

//int GetNextMonthMaxDate()
//{
//    var currentDate = DateTime.Now.Date;
//    return currentDate.AddMonths(2).AddDays(- (currentDate.Day)).Day;
//}

//int CountTotalOddNumbers(int[] numbers)
//{
//    return numbers.Where(n => n % 2 != 0).Sum();
//}

//string[] UniqueNames(string[] arr1, string[] arr2)
//{
//    var strArray = arr1.ToList();
//    strArray.AddRange(arr2);
//    return strArray.GroupBy(x => x).Select(x => x.Key).ToArray();
//}
