using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using static S2.Data.ListGenerator;
using static System.Net.Mime.MediaTypeNames;

namespace S2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Aggregate Operators

            #region 1. Get the total units in stock for each product category.

            //var Result = ProductsList.GroupBy(P => P.Category).Select(C => new
            //{
            //    CategoryName = C.Key,
            //    TotalUnitsInstock = C.Sum(P => P.UnitsInStock)
            //});

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 2. Get the cheapest price among each category's products

            //var Result = ProductsList.GroupBy(p => p.Category).Select(C => new
            //{
            //    CategoryName = C.Key,
            //    ChepeastPrice = C.Min(P => P.UnitPrice)
            //});

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region 3. Get the products with the cheapest price in each category (Use Let)

            //var Result = from P in ProductsList
            //             group P by P.Category
            //             into C
            //             let MinPrice = C.Min(P => P.UnitPrice)
            //             from P in C
            //             where P.UnitPrice == MinPrice
            //             select new
            //             {
            //                 CategoryName = C.Key,
            //                 P.ProductName,
            //                 P.UnitPrice,
            //             };


            //foreach (var P in Result)
            //    Console.WriteLine(P);

            #endregion

            #region 4. Get the most expensive price among each category's products.

            //var Result = ProductsList.GroupBy(P => P.Category).Select(C => new
            //{
            //    CategoryName = C.Key,
            //    MostExpesivePrice = C.Max(P => P.UnitPrice)
            //});

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #region 5. Get the products with the most expensive price in each category.

            //var Result = from P in ProductsList
            //             group P by P.Category
            //             into C
            //             let Maxprice = C.Max(P => P.UnitPrice)
            //             from P in C
            //             where P.UnitPrice == Maxprice
            //             select new
            //             {
            //                 CategoryName = C.Key,
            //                 P.ProductName,
            //                 P.UnitPrice,
            //             };

            //foreach (var item in Result)
            //    Console.WriteLine(item);



            #endregion

            #region 6. Get the average price of each category's products.

            //var Result = ProductsList.GroupBy(P => P.Category).Select(C => new
            //{
            //    CategoryName = C.Key,
            //    AveragePrice = C.Average(P => P.UnitPrice)
            //});

            //foreach (var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #endregion

            #region LINQ - Set Operators

            #region 1. Find the unique Category names from Product List

            //var Result = ProductsList.Select(P => P.Category).Distinct();

            //foreach (var Item in Result)
            //    Console.WriteLine(Item);

            #endregion

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.

            //var Result = ProductsList.Select(P => P.ProductName[0]).Union(CustomersList.Select(C => C.CustomerName[0]));

            //foreach(var i in Result)
            //    Console.WriteLine(i);

            #endregion

            #region 3. Create one sequence that contains the common first letter from both product and customer names.

            //var Result = ProductsList.Select(P => P.ProductName[0]).Intersect(CustomersList.Select(C => C.CustomerName[0]));

            //foreach (var i in Result)
            //    Console.WriteLine(i);
            #endregion

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var Result = ProductsList.Select(P => P.ProductName[0]).Except(CustomersList.Select(C => C.CustomerName[0]));

            //foreach (var i in Result)
            //    Console.WriteLine(i);

            #endregion

            #region 5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var Result = ProductsList.Select(P => P.ProductName.Trim().TakeLast(3)).Concat(CustomersList.Select(C => C.CustomerName.Trim().TakeLast(3)));

            //foreach (var Chars in Result)
            //{
            //    foreach(var Char in Chars)
            //        Console.Write(Char);
            //    Console.WriteLine();
            //}



            #endregion

            #endregion

            #region LINQ - Partitioning Operators

            #region 1. Get the first 3 orders from customers in Washington

            //var Result = CustomersList.Where(C => C.Region == "WA").Take(3).SelectMany(O => O.Orders);

            //foreach (var C in Result)
            //    Console.WriteLine(C);

            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington.
            //var Result = CustomersList.Where(C => C.Region == "WA").Skip(2).SelectMany(O => O.Orders);

            //foreach (var C in Result)
            //    Console.WriteLine(C);
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((N, I) => N >= I);

            //foreach (int i in Result)
            //    Console.WriteLine(i);

            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile(N => N % 3 == 0 );

            //foreach (int i in Result)
            //    Console.WriteLine(i);
            //#endregion
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile((N, I) => N >= I);

            //foreach (int i in Result)
            //    Console.WriteLine(i);
            #endregion

            #endregion

            #region LINQ - Quantifiers

            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] StringFirst = File.ReadAllLines("dictionary_english.txt ");

            //var Result = StringFirst.Any(Word => Word.Contains("ei"));
            //Console.WriteLine(Result);

            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var Result = ProductsList.GroupBy(P => P.Category).Where(C => C.Any(P => P.UnitsInStock == 0));


            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach(var Product in Category)
            //    {
            //        Console.WriteLine($"               {Product}");
            //    }
            //}




            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.

            //var Result = ProductsList.GroupBy(P => P.Category).Where(C => C.All(P => P.UnitsInStock > 0));


            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //    {
            //        Console.WriteLine($"               {Product}");
            //    }
            //}

            #endregion
            #endregion

            #region LINQ – Grouping Operators

            #region 1. Use group by to partition a list of numbers by their remainder when divided by 5

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result = numbers.GroupBy(N => N % 5);

            //foreach (var Reminder in Result)
            //{
            //    Console.WriteLine($"Numbers With a Reminder {Reminder.Key} when divided by 5 : ");
            //    foreach (var N in Reminder)
            //        Console.WriteLine(N);
            //}



            #endregion

            #region 2. Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input


            //string[] StringFirst = File.ReadAllLines("dictionary_english.txt ");

            //var Result = StringFirst.GroupBy(Word => Word[0]);

            //foreach ( var FirstChar in Result)
            //{
            //    Console.WriteLine(FirstChar.Key);
            //    foreach(var Word in FirstChar)
            //        Console.WriteLine($"           {Word}");
            //}


            #endregion

            #region 3. Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var Result = Arr.GroupBy(Word => Word, new StringComparer());

            //foreach(var i in Result)
            //{
            //    foreach(var Word in i)
            //        Console.WriteLine(Word);
            //    Console.WriteLine("----");
            //}    

            #endregion

            #endregion
        }
    }
}
