using S2.Data;
using System.Collections;
using System.ComponentModel;
using static S2.Data.ListGenerator;

namespace S2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting Operators - Immediate Execution  

            //List<Product> Results = ProductList.Where(P => P.UnitsInStock == 0).ToList();

            //Product[] Results = ProductList.Where(P => P.UnitsInStock == 0).ToArray();

            //Dictionary<long, string> Result = ProductList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID,P => P.ProductName);

            //foreach (var item in Result)
            //    Console.WriteLine($"Key = {item.Key} , Value = {item.Value}");

            //HashSet<Product> Result = ProductList.Where(P => P.UnitsInStock == 0).ToHashSet();


            //ArrayList arrayList = new ArrayList()
            //{
            //    "Ahmed",
            //    "Mona",
            //    "Aya",
            //    1,
            //    2,
            //    3
            //};

            //var Result = arrayList.OfType<int>();

            //foreach(var item in Result)
            //    Console.WriteLine(item);

            #endregion

            #region Generation Operators

            //var Result = Enumerable.Range(0, 100);

            //Result = Enumerable.Repeat(2, 100);
            //var Result = Enumerable.Repeat(new Product(), 100);

            ////var Result02 = Enumerable.Empty<Product>().ToArray;
            //var Result02 = Enumerable.Empty<Product>().ToList();
            //Product[] products = new Product[0];



            //foreach(var i in Result)
            //    Console.Write($"{i} ");

            #endregion

            #region Set Operators

            //var Seq01 = Enumerable.Range(0, 100); // 0 .. 99

            //var Seq02 = Enumerable.Range(50, 100); // 50 .. 149 


            //var Seq03 = Seq01.Union(Seq02);

            //Seq03 = Seq01.Concat(Seq02);

            //Seq03 = Seq03.Distinct(); 

            //Seq03 = Seq01.Except(Seq02);

            //Seq03 = Seq01.Intersect(Seq02);





            //Console.WriteLine("=================Seq01================");
            //foreach (var i in Seq01)
            //    Console.Write($"{i} ");

            //Console.WriteLine();
            //Console.WriteLine("=================Seq02================");
            //foreach (var i in Seq02)
            //    Console.Write($"{i} ");

            //Console.WriteLine();
            //Console.WriteLine("=================Seq03================");
            //foreach (var i in Seq03)
            //    Console.Write($"{i} ");

            #endregion

            #region Quantifier Operators

            //List<Product> TestProducts = new List<Product>();
            //var Result = ProductList.Any(P=>P.UnitsInStock == 1000);


            //var Result = ProductList.All(P=>P.UnitsInStock >= 0);


            //var Seq01 = Enumerable.Range(0, 100); // 0 .. 99

            //var Seq02 = Enumerable.Range(50, 100); // 50 .. 149 

            //var Result = Seq01.SequenceEqual(Seq02);




            //Result = TestProducts.Any();
            //Console.WriteLine(Result);

            #endregion

            #region Zipping Operator

            //string[] Names = { "Ahmed", "Mona", "Aya", "Ali", "Mohamed" };

            //int[] Numbers = Enumerable.Range(1, 10).ToArray(); // 1 .. 10

            //char[] Chars = { 'A', 'B', 'C', 'D', 'E' };


            ////var Result = Names.Zip(Numbers,(Name,Number) => new {index = Number , Name = Name});
            //var Result = Names.Zip(Numbers,Chars);

            //foreach (var i in Result)
            //    Console.WriteLine(i);


            #endregion

            #region Grouping Operators

            #region Get Products Grouped by Category 

            //var Result = from P in ProductList
            //             group P by P.Category;

            //Result = ProductList.GroupBy(p => p.Category);

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(  Category.Key);
            //    foreach(var Product in Category)
            //        Console.WriteLine($"             {Product.ProductName}");


            //}


            #endregion

            #region Get Products in Stock Grouped by Category 

            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0   
            //             group P by P.Category;

            //Result = ProductList.Where(P => P.UnitsInStock > 0).GroupBy(p => p.Category);

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //        Console.WriteLine($"             {Product.ProductName}");


            //}

            #endregion

            #region  Get Products in Stock Grouped by Category That Contains More Than 10 Products
            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 10
            //             select Category;


            //Result = ProductList.Where(P => P.UnitsInStock > 0).GroupBy(p => p.Category).Where(Category => Category.Count() > 10);

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category.Key);
            //    foreach (var Product in Category)
            //        Console.WriteLine($"             {Product.ProductName}");


            //}
            #endregion

            #region Get Category Name of Products in Stock That Contains More Than 10 Product and Number of Product In Each Category

            //var Result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 10
            //             select new
            //             {
            //                 CategoryName = Category.Key,
            //                 NumberOfProducts = Category.Count(),
            //             };

            //Result = ProductList.Where(P => P.UnitsInStock > 0).GroupBy(p => p.Category).Where(Category => Category.Count() > 10).Select(Category => new
            //{
            //    CategoryName = Category.Key,
            //    NumberOfProducts = Category.Count()
            //});

            //foreach (var Category in Result)
            //{
            //    Console.WriteLine(Category);



            //}
            #endregion
            #endregion

            #region Partitioning Operartor

            //int[] Numbers = { 5, 4, 1, 9, 7, 6, 2, 3 };

            //var Result = ProductList.Where(P => P.UnitsInStock > 0).Take(10);
            //Result = ProductList.TakeLast(10);

            //var Result = ProductList.Where(P => P.UnitsInStock == 0).Skip(2);
            //var Result = ProductList.Where(P => P.UnitsInStock == 0).SkipLast(2);

            //var Result = Numbers.TakeWhile((Number,I) => Number > I);

            //var Result = Numbers.SkipWhile(N => N < 9);

            //var Result = ProductList.Skip(20).Take(10);

            //foreach (var item in Result)
            //    Console.WriteLine(item);
            #endregion

        }
    }
}
