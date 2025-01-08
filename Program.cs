using System;
using System.Collections.Generic;

namespace ZooManagementSystem
{
    public class Animal
    {
        public string Name { get; set; }
        public string Diet { get; set; }

        public Animal(string name, string diet)
        {
            Name = name;
            Diet = diet;
        }

        public string GetFood()
        {
            return Diet == "Carnívoro" ? "carne" : "plantas";
        }
    }
        public class Show
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }

        public Show(string name, DateTime time)
        {
            Name = name;
            Time = time;
        }
    }
    public class Zoo
    {
        public string Name { get; set; }
        private List<Animal> Animals;
        private List<Show> Shows;

        public Zoo(string name)
        {
            Name = name;
            Animals = new List<Animal>();
            Shows = new List<Show>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            Console.WriteLine($"Animal {animal.Name} adicionado ao zoológico.");
        }

        public void ListAnimals()
        {
            Console.WriteLine("Animais no zoológico:");
            foreach (var animal in Animals)
            {
                Console.WriteLine($"- {animal.Name} ({animal.Diet})");
            }
        }

        public void FeedAnimals()
        {
            Console.WriteLine("Alimentando os animais...");
            foreach (var animal in Animals)
            {
                Console.WriteLine($"- {animal.Name} foi alimentado com {animal.GetFood()}.");
            }
        }

        public void ProvideVeterinaryCare(string animalName)
        {
            var animal = Animals.Find(a => a.Name == animalName);
            if (animal != null)
            {
                Console.WriteLine($"Assistência veterinária prestada ao {animal.Name}.");
            }
            else
            {
                Console.WriteLine($"Animal {animalName} não encontrado.");
            }
        }

        public void ScheduleShow(string showName, DateTime time)
        {
            Shows.Add(new Show(showName, time));
            Console.WriteLine($"Espetáculo '{showName}' agendado para dia {time}.");
        }
        public void ListShows()
        {
            Console.WriteLine("Lista de Shows:");
            foreach (var Show in Shows)
            {
                Console.WriteLine($"- {Show.Name} Dia :({Show.Time})");
            }
        }

        public void SellTicket(string visitorName, string showName)
        {
            var show = Shows.Find(s => s.Name == showName);
            if (show != null)
            {
                Console.WriteLine($"Bilhete vendido para {visitorName} para o espetáculo '{showName}'.");
            }
            else
            {
                Console.WriteLine($"Espetáculo '{showName}' não encontrado.");
            }
        }

        public void CleanCages()
        {
            Console.WriteLine("Limpando as jaulas dos animais...");
            foreach (var animal in Animals)
            {
                Console.WriteLine($"- Jaula do {animal.Name} limpa.");
            }
        }
    }

}
