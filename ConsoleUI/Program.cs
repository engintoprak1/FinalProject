﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {

            ProductTest();
            //Data Transformation Object
            //CategoryTest();

            //ProductManager productManager = new ProductManager(new EfProductDal());
            //foreach (var product in productManager.GetProductDetails())
            //{
            //    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            //}

        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll().Data)
            {
                Console.WriteLine(category.CategoryName);
            }

            //Console.WriteLine(categoryManager.GetById(2).CategoryName);
        }

        private static void ProductTest()
        {
            //ProductManager productManager = new ProductManager(new EfProductDal());

            ////var result = productManager.GetProductDetails();

            //if (result.Success==true)
            //{
            //    foreach (var product in result.Data)
            //    {
            //        Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            
        }
    }
}
