using LINQ.DataSources;
using LINQ.Models;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
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

            #region Question_11
            //11.Find the CHEAPEST and MOST EXPENSIVE product prices
            //var MostExpensiveProduct = Source.ProductList.OrderByDescending(p => p.UnitPrice).FirstOrDefault();
            //var CheapestProduct = Source.ProductList.OrderByDescending(p => p.UnitPrice).LastOrDefault();

            //Console.WriteLine($"Most Expensive Product {MostExpensiveProduct}");
            //Console.WriteLine($"Cheapest Product {CheapestProduct}");
            #endregion


            #region Question_12
            //12.Get a distinct list of all product categories
            //var result = Source.ProductList.DistinctBy(p => p.Category);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question_13
            //13.find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Question_14
            //14.Find countries that appear in list1 but NOT in list2
            //    (case -insensitive).
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Question_15
            //15.Build a Dictionary<int, Product> keyed by ProductID. Then
            //retrieve and print the product with ID = 18.

            //var result = Source.ProductList.ToDictionary(P => P.ProductID, P => P).Where(p=>p.Key==18).Select(P=>P.Value);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region Question_16
            //16.Get the first product whose price is greater than $50.

            //var reslut = Source.ProductList.Where(p => p.UnitPrice > 50m)?.FirstOrDefault();


            //    Console.WriteLine(reslut);


            #endregion

            #region Question_17
            //17.Try to get the first product with a price > $500.it returns null
            //instead of throwing.

            //var result = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 500);

            //Console.WriteLine(result);
            #endregion


            #region Question_18
            //18.Generate a multiplication table row for 7
            //int num = 7;

            //var numbers = Enumerable.Range(1, 12);

            //var result = numbers
            //    .Select(n => n * 7)
            //    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Question_19
            //19.Generate even numbers between 1 and 30.

            //var numbers = Enumerable.Range(1, 30);

            //var evenNumbers = numbers.Where(n=>n % 2 == 0);

            //foreach (var item in evenNumbers)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Question_20
            //20.Concatenate the first 3 product names with the first 3
            //    customer company names into a single sequence.

            //var product = Source.ProductList
            //    .Take(3)
            //    .Select(p => p.ProductName);

            //var customer = Source.CustomerList
            //    .Take(3)
            //    .Select(c => c.CustomerName);

            //var result = product.Concat(customer);

            //foreach (var item in result)
            //{
            //    Console.Write($"{item},' ',");
            //}

            #endregion
        }
    }
}
