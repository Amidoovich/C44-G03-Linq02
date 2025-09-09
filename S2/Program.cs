using S2.Data;
using System.Collections;
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

        }
    }
}
