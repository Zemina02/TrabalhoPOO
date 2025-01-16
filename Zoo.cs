using System.Text.Json;
using ZooManagementSystem;

Zoo zoo = new Zoo("Safari Zoo");

string filepath1 = "C:/Users/home/Desktop/Programação orientada a objetos/trabalho grupo/jardim zoo/files de guardar/lista.json"; // @"C:\Users\...\lista.json"
string filepath2 = "C:/Users/home/Desktop/Programação orientada a objetos/trabalho grupo/jardim zoo/files de guardar/show.json";  // @"C:\Users\...\show.json"

Animal animal;
// Adicionar animais ao zoológico
zoo.AddAnimal(new Animal("Leao", "Carnívoro", 190));
zoo.AddAnimal(new Animal("Elefante", "Herbívoro", 6000));
zoo.AddAnimal(new Animal("Golfinho", "Carnívoro", 100));

int colha = 1;
while (colha != 0)
{
    Console.WriteLine($"\n\n\nBEM-VINDO AO {zoo.Name}");
    Console.WriteLine("1 - Adicionar Animal");
    Console.WriteLine("2 - Alimentar Animal");
    Console.WriteLine("3 - Ver Lista de Animais");
    Console.WriteLine("4 - Assistência veterinaria");
    Console.WriteLine("5 - Planejar espetáculos");
    Console.WriteLine("6 - Emitir bilhetes");
    Console.WriteLine("7 - Ver Lista de Espetáculos");
    Console.WriteLine("8 - Limpar jaulas");
    Console.WriteLine("9 - Gravar Zoo");
    Console.WriteLine("11 - Carregar Zoo");
    Console.WriteLine("0 - Sair");


    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        //Adicionar Animal
        case 1: AdicionarAnimal(); break;
        // Gerenciar tarefas de alimentação
        case 2: zoo.FeedAnimals(); break;
        // Listar os animais
        case 3: zoo.ListAnimals(); break;
        // Gerenciar assistência veterinária
        case 4: AssistenciaVet(); break;
        // Planejar espetáculos
        case 5: PlanejarEspetaculos(); break;
        // Emitir bilhetes
        case 6: EmitirBilhetes(); break;
        // Listar os espetáculos
        case 7: zoo.ListShows(); break;
        // Limpar jaulas
        case 8: zoo.CleanCages(); break;
        // Gravar Zoo
        case 9: GravarZoo(zoo); break;
        // Carregar Zoo
        case 10: zoo = CarregarZoo(); break;
    }
    colha = opcao;
    Console.WriteLine("Pressione Enter para continuar...");
    Console.ReadLine();

    //Adicionar Animal
    void AdicionarAnimal()
    {
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
    }

    // Gerenciar assistência veterinária
    void AssistenciaVet()
    {
        Console.WriteLine("Qual o animal que presisa de assistência médica?(NOME)\n");
        zoo.ListadeAnimais();
        string nanimal = Console.ReadLine();
        zoo.ProvideVeterinaryCare(nanimal);
    }

    // Planejar espetáculos
    void PlanejarEspetaculos()
    {
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
        if (anus != null || miz != null || diz != null || horus != null || anus != 0 || miz != 0 || diz != 0)
        {
            zoo.ScheduleShow(spec, new DateTime(anus, miz, diz, horus, 0, 0));
        }
        else
        {
            Console.WriteLine("Valores inválidos");
        }
    }

    // Emitir bilhetes
    void EmitirBilhetes()
    {
        Console.WriteLine("Qual o nome?");
        string nambre = Console.ReadLine();
        Console.WriteLine("Qual o espetáculo?");
        zoo.ListShows();
        string showdebola = Console.ReadLine();
        zoo.SellTicket(nambre, showdebola);
    }

    //Gravar Zoo
    void GravarZoo(Zoo zoo)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        string animals = JsonSerializer.Serialize(zoo, options);
        File.WriteAllText(filepath1, animals);
        Console.WriteLine("Zoo gravado com exito");
    }

    //Carregar Zoo
    Zoo CarregarZoo()
    {
        string animals = File.ReadAllText(filepath1);
        return JsonSerializer.Deserialize<Zoo>(animals);
    }
}
