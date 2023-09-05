using Exemplo___Lista;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

public class Program
{ 
    static void Main(string[] args)
    {
        //ExemploLista1();
        ExemploListaObjetos();

    }

    static void ExemploLista1()
    {
        List<string> ListaString = new List<string>();//string
        ListaString.Add("Natalia"); //adicionar elemento no final da lista
        ListaString.Add("Julia");
        ListaString.Insert(1, "Joao");//adicionar um elemento em uma posição especifica da lista 
        ListaString.Add("Ana Maria");

        //ListaString.Remove("Batata");//remove pelo nome
        //ListaString.RemoveAt(2);//remove pela posição
        //ListaString.Clear(); //limpa a lista inteira
        ListaString.Sort(); //comando responsavel por ordenar a lista

        /*for(int i  = 0; i < ListaString.Count; i++)//percorrer lista com for
         {
             Console.WriteLine(ListaString[i]);  
         }*/
        //ListaString.Count = retorna o tamanho da lista

        //segunda forma de percorrer de percorrer todos os elementos da lista, da primeira posição ate a ultima 
        //para cada repetição, copia e endereço da posição atual da lista
        //ou seja, na primeira repetição a variável str recebe o valor da posição 0 da lista (Natalia)
        //Na segunda repetição, str recebe o valor da posição 1 da lista (Joao)

        List<string> ListaB = new List<string> { "Maria a", "Maria b" };
        ListaString.AddRange(ListaB); //adicionar toda a listab no final da listastring
                                      // bool contem = ListaB.Contains("Maria"); //comparar se tem (true) ou não (false)
                                      //Console.WriteLine(contem);


        foreach (string str in ListaString)
        {
            Console.WriteLine(str);//imprimi valores da lista

        }

        List<int> ListaInt = new List<int>();//int
        ListaInt.Add(1);
        ListaInt.Add(4);
        ListaInt.Add(2);
        ListaInt.Sort();
        /*List<int> ListaInt2 = ListaInt.OrderDescending().ToList(); 
        foreach (int i in ListaInt2) 
        {
            Console.WriteLine(i);
        }*/

        foreach (int str in ListaInt)
        {
            Console.WriteLine(str);//imprimi valores da lista

        }


        /*  foreach (string i in ListaString) //usando for com foreach 
           { 
               Console.WriteLine(i);//imprimi valores da lista

           }*/

        List<double> ListaDouble = new List<double> { 2, 5, 3, 8, 2 }; //iniciar lista com alguns elementos
        ListaDouble.Add(1);

    }

    static void ExemploListaObjetos()
    {
        List<Paciente> listaPacientes = new List<Paciente>();   
        Paciente p1 = new Paciente(1, "Elias".ToUpper(), "000", "elias.silva@", new DateTime(1992, 07, 22));
        Paciente p2 = new Paciente(2, "Julia".ToUpper(), "111", "julia@", new DateTime(2000, 01, 25));
        Paciente p3 = new Paciente(3, "Sthefany".ToUpper(), "222", "sthefany.lorrany@", new DateTime(2006, 09, 20));
        Paciente p4 = new Paciente(4, "Joao".ToUpper(), "333", "joao@", new DateTime(1995, 12, 01));
        Paciente p5 = new Paciente(5, "Joana".ToUpper(), "444", "joana@", new DateTime(2013, 02, 28));
        //Paciente p6 = new Paciente ();//para digitar
       
        listaPacientes.Add(p1);
        listaPacientes.Add(p2);
        listaPacientes.Add(p3);
        listaPacientes.Add(p4);
        listaPacientes.Add(p5);
        listaPacientes.Insert(0, p5);
        listaPacientes.Remove(p5);
        //listaPacientes.OrderBy(x=> x.Nome);

        //O metodo orderBy orderna uma lista a partir de um determinado atributo 
        //Esse método retorna uma lista ordenada (precisa armazenar esse resultado)
        //ToList() converte o resultado para uma lista
        //Caso queira apresentar a nova lista ordenada, somente percorre-la
        //No exemplo, x.Nome especifica que irá ordernar pelo atributo nome,
        //pode ser qualquer atributo do objeto
        List<Paciente> pOrdenados = listaPacientes.OrderBy(x=> x.Nome).ToList();
        List<Paciente> pOrdenadosD = listaPacientes.OrderBy(x => x.Nome).ToList();
        //OrderBy ordernar e retornar

        //Recupera determinado elemnto que contem o valor passado na expressão.
        //No exemplo, recupera o paciente que contém o cpf 000.
        /*Paciente pCpf0 = listaPacientes.SingleOrDefault(x => x.Cpf == "111");
        if (pCpf0 != null)
        {
            Console.WriteLine(pCpf0.Nome);
        }
        else
        {
            Console.WriteLine("Paciente não encontrado!");
        }*/




        /* foreach (Paciente p in pOrdenadosD)
         {
             if(p.Cpf == "000")
             {
                 Paciente pCpf00 = p;
             }
         }*/

        //O método Where é utilizado para selecionar todos que atende alguma expressão
        //No exemplo abaixo, seleciona e armazena na lista busca todos os pacientes que possuem 
        //o valor de Id_paciente maior que 2;

        Console.WriteLine("Digite o nome para realizar a busca");
        string nomeBusca = Console.ReadLine();
        // List<Paciente> busca = listaPacientes.Where(x => x.Id_paciente > 2 || x.Nome == "Elias".ToUpper()).ToList();
        List<Paciente> busca = listaPacientes.Where(x => x.Nome.ToUpper() == nomeBusca.ToUpper()).ToList();
        
        //Buscar todos que começam com determinada letra. EX: A
        List<Paciente> busca2 = listaPacientes.Where(x => x.Nome.ToUpper().StartsWith("A")).ToList();

        foreach (Paciente p in busca)
        {
           Console.WriteLine(p.Nome + " " + p.Cpf + " " + p.Email);
        }
    }
}

