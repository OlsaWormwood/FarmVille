using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            GardenBed GardenBed1 = new GardenBed("Pervaya", 200);

            Plant Tomato = new Plant("Tomato", "Summer", "Autumn", 10);
            GardenBed1.AddPlant(Tomato);
            Plant Potato = new Plant("Potato", "Summer", "Autumn", 45);
            GardenBed1.AddPlant(Potato);
            GardenBed1.GetInfo();

            // Plant Tomato = new Plant("Tomato", "Summer", "Autumn", 10);
            // // Tomato.PlantName = "Tomato";
            // // Tomato.PlantingSeason = "Summer"; 
            // // Tomato.HarvestSeason = "Autumn";
            // // Tomato.Area = 10;
            // Tomato.GetInfo();

            // Plant Potato = new Plant("Potato", "Summer", "Autumn", 45);
            // Potato.GetInfo();

            // Plant Carrot = new Plant("Carrot", "Winter", "Summer", 20);
            // Carrot.GetInfo();

            // Plant Beetroot = new Plant("Beetroot", "Winter", "Summer", 15);
            // Beetroot.GetInfo();

            // Plant Onion = new Plant("Onion", "Winter", "Summer", 5);
            // Onion.GetInfo();
        }
    }

    class Plant
    {
        public string PlantName { get; }
        public string PlantingSeason { get; }
        public string HarvestSeason { get; }
        public int Area { get; }

        public Plant(string name, string plantingSeason, string harvestSeason, int area)
        {
            PlantName = name;
            PlantingSeason = plantingSeason;
            HarvestSeason = harvestSeason;
            Area = area;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Plant {PlantName} \tPlanting Season: {PlantingSeason} \tHarvest Season {HarvestSeason} \tArea:{Area}");
        }
    }

    class GardenBed
    {
        public string Name { get; set; }
        public int Area { get; set; }
        public int Load { get; set; }
        public List<Plant> PlantsOnGardenBed = new List<Plant>();
        public List<Animal> Animals = new List<Animal>();
        // public List<string> Plants = new List<string>() { "Tomato", "Potato", "Carrot", "Beetroot", "Onion"};

        public GardenBed(string name, int area)
        {
            Name = name;
            Area = area;
        }

        public void AddPlant(Plant plant)
        {
            if (Area < (Load + plant.Area))
            {
                Console.WriteLine("Oops! It's a pity but this garden bed is full.");
            }
            else
            {
                Load += plant.Area;
                PlantsOnGardenBed.Add(plant);
            }
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public void GetInfo()
        {
            Console.WriteLine($"GardenBed {Name} \tArea of garden bed: {Area} \tLoad of the garden bed {Load} \tList of plants on it: {PlantsOnGardenBed.Count} \tList of animals: { Animals.Count }");
   }
    }

    class LivestockProduct
    {
        public string Name { get; }
        public int Weight { get; }
        public void GetInfo()
        {
            Console.WriteLine($"Livestock Product {Name} \tWeight: {Weight}");
        }
    }

    class Animal
    {
        public string Name { get; }
        public LivestockProduct Product { get; }
        public Animal(string name, LivestockProduct livestockProduct)
        {
            Name = name;
            Product = livestockProduct;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Animal {Name} \tProduct: {Product.Name}");
        }
    }
}

