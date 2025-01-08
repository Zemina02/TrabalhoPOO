
using Microsoft.AspNetCore.Mvc;
using ZooManagementSystem;

Zoo zoo = new Zoo("Safari Zoo");
Animal animal;
// Adicionar animais ao zoológico
zoo.AddAnimal(new Animal("Leão", "Carnívoro"));
zoo.AddAnimal(new Animal("Elefante", "Herbívoro"));
zoo.AddAnimal(new Animal("Golfinho", "Carnívoro"));

int colha = 1;
while (colha != 0){
Console.WriteLine("1 - Adicionar Animal");
Console.WriteLine("2 - Alimentar Animal");
Console.WriteLine("3 - Ver Lista de Animais");
Console.WriteLine("4 - Assistência veterinaria");
Console.WriteLine("5 - Planejar espetáculos");
Console.WriteLine("6- Emitir bilhetes");
Console.WriteLine("7- Limpar jaulas");
Console.WriteLine("0- Sair");


int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 0:break;
    case 1:
        Console.WriteLine("Qual o animal?");
        string zigler = Console.ReadLine();
        Console.WriteLine("1 - Herbívoro\n2 - Carnívoro");
        string diets;
        int escolha = int.Parse(Console.ReadLine());
        if (escolha == 1)
        {
            diets = "Herbívoro";
        }
        else
        {
            diets = "Carnívoro";
        }
        zoo.AddAnimal(new Animal(zigler, diets));
        break;
    // Gerenciar tarefas de alimentação
    case 2: zoo.FeedAnimals(); break;
    // Listar os animais
    case 3: zoo.ListAnimals(); break;
    // Gerenciar assistência veterinária
    case 4: zoo.ProvideVeterinaryCare("Elefante"); break;
    // Planejar espetáculos
    case 5:
        Console.WriteLine("Qual o nome do espetáculo?");
        string spec = Console.ReadLine();
        Console.WriteLine("Dias até ao espetáculo?");
        int horus = int.Parse(Console.ReadLine());
        zoo.ScheduleShow(spec,DateTime.Now.AddDays(horus));
        break;
    // Emitir bilhetes
        case 6:
        Console.WriteLine("Qual o nome?");
        string nambre = Console.ReadLine();
        Console.WriteLine("Qual o espetáculo?");
        zoo.ListShows();
        string showdebola =Console.ReadLine();
        zoo.SellTicket(nambre,showdebola);
        break;
    // Limpar jaulas
        case 7:
        zoo.CleanCages();
        break;
}
colha = opcao;
Console.WriteLine("Pressione Enter para continuar...");
Console.ReadLine();
}






