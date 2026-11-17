using LINQ.DataSources;
using LINQ.Models;
using System.Collections;



namespace G_NET_92_LQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question_01
            //1.Get top 3 most expensive products

            //var result = Source.ProductList.OrderByDescending(p => p.UnitPrice).Take(3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question_02
            //2.show page 2 of products, with page size = 5

            //var result = Source.ProductList.Skip((2-1)*5).Take(5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question_03
            //3.Take products from the list as long as Their UnitPrice is less than
            //$25(list is ordered by price).

            //var Result = Source.ProductList.TakeWhile(p=>p.UnitPrice < 25m);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question_04
            //4.Check if ALL products in the "Seafood" category are in stock

            //var Result = Source.ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);

            //Console.WriteLine(Result);
            #endregion
        }
    }
}
