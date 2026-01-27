using System;
using System.Collections.Generic;
using System.Linq;

namespace AnimalExample
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Cost { get; set; }

        protected Animal(string name, int age, decimal cost)
        {
            Name = name;
            Age = age;
            Cost = cost;
        }

        public virtual decimal HowMuch()
        {
            return Cost;
        }
    }

    public class Species : Animal
    {
        public string Type { get; set; }   
        public string Breed { get; set; }
        public decimal WalkFee { get; set; } 

        public Species(string name, int age, string type, string breed, decimal cost, decimal walkFee = 0)
            : base(name, age, cost)
        {
            Type = type;
            Breed = breed;
            WalkFee = Type.Equals("Dog", StringComparison.OrdinalIgnoreCase) ? walkFee : 0;
        }

        public override decimal HowMuch()
        {
            if (Type.Equals("Dog", StringComparison.OrdinalIgnoreCase))
            {
                return Cost + WalkFee;
            }

            return Cost;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Species dog1 = new Species("Bobby", 3, "Dog", "Golden Retriever", 100m, 20m);
            Species dog2 = new Species("Snoopy", 5, "Dog", "Poodle", 120m, 25m);
            Species dog3 = new Species("Karabos", 2, "Dog", "Golden Retriever", 100m, 20m);
            Species dog4 = new Species("Cont", 5, "Dog", "Poodle", 120m, 25m);

            Species cat1 = new Species("Mirmir", 2, "Cat", "British Shorthair", 80m);
            Species cat2 = new Species("Tekirs", 4, "Cat", "Street Cat", 50m);
            Species cat3 = new Species("Beyaz", 2, "Cat", "British Shorthair", 80m);
            Species cat4 = new Species("Spanky", 4, "Cat", "Street Cat", 50m);

            List<Animal> animals = new List<Animal> { dog1, dog2, dog3, dog4, cat1, cat2, cat3, cat4 };

            var dogList = animals
                .OfType<Species>()
                .Where(s => s.Type.Equals("Dog", StringComparison.OrdinalIgnoreCase))
                .ToList();

            var catList = animals
                .OfType<Species>()
                .Where(s => s.Type.Equals("Cat", StringComparison.OrdinalIgnoreCase))
                .ToList();

            Console.WriteLine("===== DOGS =====");
            foreach (var d in dogList)
            {
                decimal totalCost = d.HowMuch();
                Console.WriteLine(
                    $"{d.Name} - breed: {d.Breed}, base: {d.Cost} PLN, walk fee: {d.WalkFee} PLN, total: {totalCost} PLN");
            }

            Console.WriteLine();
            Console.WriteLine("===== CATS =====");
            foreach (var c in catList)
            {
                decimal totalCost = c.HowMuch();
                Console.WriteLine(
                    $"{c.Name} - breed: {c.Breed}, total: {totalCost} PLN");
            }

            Console.WriteLine();
            Console.WriteLine("===== TOTALS =====");

            if (dogList.Any())
            {
                var dogTotals = dogList.Select(d => d.HowMuch()).ToList();
                decimal dogSum = dogTotals.Sum();
                decimal dogAvg = dogTotals.Average();
                Console.WriteLine($"Dogs -> count: {dogList.Count}, total: {dogSum} PLN, average: {dogAvg} PLN");
            }

            if (catList.Any())
            {
                var catTotals = catList.Select(c => c.HowMuch()).ToList();
                decimal catSum = catTotals.Sum();
                decimal catAvg = catTotals.Average();
                Console.WriteLine($"Cats -> count: {catList.Count}, total: {catSum} PLN, average: {catAvg} PLN");
            }

            decimal grandTotal = animals.OfType<Species>().Select(s => s.HowMuch()).Sum();
            Console.WriteLine($"All animals total cost: {grandTotal} PLN");

            Console.ReadLine();
        }
    }
}