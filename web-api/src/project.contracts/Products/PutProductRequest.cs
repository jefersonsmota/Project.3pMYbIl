﻿namespace project.contracts.Products
{
    public class PutProductRequest
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        protected PutProductRequest() { }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

        public PutProductRequest(string name, decimal price, string imageUrl)
        {
            Name = name;
            Price = price;
            ImageURL = imageUrl;
        }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public string ImageURL { get; private set; }
    }
}