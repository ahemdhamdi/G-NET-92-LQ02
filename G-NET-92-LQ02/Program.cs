using LINQ.DataSources;
using LINQ.Models;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;



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

            #region Question_05
            //5.Check if the ID list contains 9


            //int[] ids = { 3, 9, 13, 18 };

            //var result = ids.Contains(9);

            //Console.WriteLine(result);
            #endregion

            #region Question_06 & Question_07
            //6.Group all products by Category and print each group with its
            //product count.

            //7.Group products by Category and project only product names per
            //group

            //var result = Source.ProductList.GroupBy(p => p.Category);

            //foreach (var Group in result)
            //{
            //    Console.WriteLine("=========================================================");
            //    Console.WriteLine($"{Group.Key} :::: {Group.Count()}");
            //    Console.WriteLine("====== Group Product ======");
            //    foreach (var item in Group)
            //    {
            //        Console.WriteLine(item.ProductName);
            //    }
            //}

            #endregion

            #region Question_08
            //8.Find all categories that have MORE THAN 3 products

            //var result = Source.ProductList.GroupBy(p => p.Category).Where(G=>G.Count()>3);

            //foreach (var Group in result)
            //{
            //    Console.WriteLine("=========================================================");
            //    Console.WriteLine($"{Group.Key} :::: {Group.Count()}");
            //}

            #endregion


            #region Question_09
            //9.Using QUERY SYNTAX, group customers by Country, and for each
            //group select { Country, Count, TotalOrderValue }.

            //var result = from C in Source.CustomerList
            //             group C by C.Country
            //             into N
            //             select new
            //             {
            //                 Contry = N.Key,
            //                 Count = N.Count(),
            //                 TotalOrderValue = N.SelectMany( c => c.Orders).Sum(o => o.Total)
            //             };



            //foreach (var group in result)
            //{
            //    Console.WriteLine(group);
            //}
            #endregion

            #region Question_10
            //10.Calculate the total number of units in stock across all products

            //var result = Source.ProductList.Count(p => p.UnitsInStock > 0);

            //Console.WriteLine(result);

            #endregion

        }
    }
}
