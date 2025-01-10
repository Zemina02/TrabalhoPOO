
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using ZooManagementSystem;

Zoo zoo = new Zoo("Safari Zoo");
Animal animal;
// Adicionar animais ao zoológico
zoo.AddAnimal(new Animal("Leão", "Carnívoro", 190));
zoo.AddAnimal(new Animal("Elefante", "Herbívoro",6000));
zoo.AddAnimal(new Animal("Golfinho", "Carnívoro",100));

int colha = 1;
while (colha != 0){
    Console.WriteLine($"\n\n\nBEM-VINDO AO {zoo.Name}");
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
        Console.WriteLine("Insira o número da escolha que pretende:\n1 - Herbívoro\n2 - Carnívoro");
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
        Console.WriteLine("Qual o peso do animal(em kilos)?");
        float pess = float.Parse(Console.ReadLine());
        zoo.AddAnimal(new Animal(zigler, diets, pess));
        break;
    // Gerenciar tarefas de alimentação
    case 2: zoo.FeedAnimals(); break;
    // Listar os animais
    case 3: zoo.ListAnimals(); break;
    // Gerenciar assistência veterinária
    case 4:
    Console.WriteLine("Qual o animal que presisa de assistência médica?\n");
    string nanimal = Console.ReadLine();
    zoo.ProvideVeterinaryCare(nanimal);
    break;
    // Planejar espetáculos
    case 5:
        Console.WriteLine("Qual o nome do espetáculo?");
        string spec = Console.ReadLine();
        Console.WriteLine("Ano do espetáculo?");
        int anus = int.Parse(Console.ReadLine());
        Console.WriteLine("Mês do espetáculo?");
        int miz = int.Parse(Console.ReadLine());
        Console.WriteLine("Dia do espetáculo?");
        int diz = int.Parse(Console.ReadLine());
        Console.WriteLine("Hora?");
        int horus = int.Parse(Console.ReadLine());
        if(anus != null || miz != null || diz != null || horus != null || anus != 0 || miz != 0 || diz != 0){
        zoo.ScheduleShow(spec,new DateTime(anus,miz,diz,horus,0,0));
        }
        else{Console.WriteLine("Valores inválidos");}
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






