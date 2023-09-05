using Exemplo___Lista;

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
        Paciente p1 = new Paciente(1, "Elias", "000", "elias.silva", new DateTime(1992, 07, 22));
        Paciente p2 = new Paciente(1, "Julia", "111", "julia@", new DateTime(2000, 01, 25));
        Paciente p3 = new Paciente(1, "Sthefany", "222", "sthefany.lorrany@", new DateTime(2006, 09, 20));
        Paciente p4 = new Paciente(1, "Joao", "333", "joao@", new DateTime(1995, 12, 01));
        Paciente p5 = new Paciente(1, "Joana", "444", "joana@", new DateTime(2013, 02, 28));
        listaPacientes.Add(p1);
        listaPacientes.Add(p2);
        listaPacientes.Add(p3);
        listaPacientes.Add(p4);
        listaPacientes.Add(p5);

        foreach(Paciente p in listaPacientes)
        {
            Console.WriteLine(p.Nome + " " + p.Cpf);
        }
    }
}

