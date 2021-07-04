﻿using Catalog.API.Entities;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Catalog.API.Data
{
    internal class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> products)
        {
            bool existProduct = products.Find(p => true).Any();
            if (!existProduct)
            {
                products.InsertManyAsync(GetMyProducts());
            }
        }

        private static IEnumerable<Product> GetMyProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = "91b62118-dba1-11eb-8d19-0242ac130003",
                    Name = "IPhone X",
                    Description = "Sed gravida leo vehicula lorem tristique tempor. Sed cursus tempor dictum. Mauris quis vestibulum augue. Cras tincidunt finibus gravida. Praesent.",
                    Image = "product-1.png",
                    Price = 950.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "fdd7acc2-dba1-11eb-8d19-0242ac130003",
                    Name = "Huawei Plus",
                    Description = "Duis cursus sodales accumsan. Mauris a lectus scelerisque, fringilla elit ut, efficitur augue. Sed sapien turpis, euismod ut quam eu.",
                    Image = "product-2.png",
                    Price = 700.00M,
                    Category = "White Appliances"
                },
                new Product()
                {
                    Id = "29139eb4-dba2-11eb-8d19-0242ac130003",
                    Name = "Samsung A71",
                    Description = "Aenean congue quam nec orci finibus gravida. Nulla eu lacinia tortor. Cras mattis ante augue, nec pulvinar orci fringilla ut.",
                    Image = "product-3.png",
                    Price = 600.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "55ae5e28-dba2-11eb-8d19-0242ac130003",
                    Name = "Xiamoi Mi 10",
                    Description = "Aenean congue quam nec orci finibus gravida. Nulla eu lacinia tortor. Cras mattis ante augue, nec pulvinar orci fringilla ut.",
                    Image = "product-4.png",
                    Price = 600.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "c9bca2342-dba2-11eb-8d19-0242ac130003",
                    Name = "HTC U11+",
                    Description = "Vestibulum venenatis sem et arcu volutpat, commodo eleifend diam lacinia. Ut eu diam sem. Vestibulum egestas volutpat leo non convallis.",
                    Image = "product-5.png",
                    Price = 600.00M,
                    Category = "Smart Phone"
                },
                new Product()
                {
                    Id = "9ff06f08-dba2-11eb-8d19-0242ac130003",
                    Name = "LG G7 ThinQ",
                    Description = "Pellentesque non ipsum tortor. Aenean a dignissim elit. Quisque eget est quis lorem vulputate congue nec et urna. Duis non.",
                    Image = "product-6.png",
                    Price = 240.00M,
                    Category = "Home Kitchen"
                }
            };
        }
    }
}