﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to product review management using linq");
            ProductReviewManagement productReview = new ProductReviewManagement();
            productReview.AddProductReviewManagement();
            Console.ReadLine();
        }
    }
}
