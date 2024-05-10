﻿namespace la_mia_pizzeria_static.Models
{
    public class PizzasViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Immage { get; set; }
        public double Price { get; set; }

        public PizzasViewModel() { }

        public PizzasViewModel(string name, string description, string immage, double price)
        {
            Name = name;
            Description = description;
            Immage = immage;
            Price = price;
        }
    }
}
