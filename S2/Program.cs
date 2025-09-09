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


            ArrayList arrayList = new ArrayList()
            {
                "Ahmed",
                "Mona",
                "Aya",
                1,
                2,
                3
            };

            var Result = arrayList.OfType<int>();

            foreach(var item in Result)
                Console.WriteLine(item);

            #endregion
        }
    }
}
