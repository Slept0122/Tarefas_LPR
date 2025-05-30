using System;

class Program
{
    static string nome1 = "", nome2 = "", nome3 = "", nome4 = "", nome5 = "";
    static string poder1 = "", poder2 = "", poder3 = "", poder4 = "", poder5 = "";
    static int pontuacao1 = 0, pontuacao2 = 0, pontuacao3 = 0, pontuacao4 = 0, pontuacao5 = 0;
    static string equipeNome1 = "", equipeNome2 = "", equipeNome3 = "";
    static string equipePoder1 = "", equipePoder2 = "", equipePoder3 = "";
    static int equipePont1 = 0, equipePont2 = 0, equipePont3 = 0;
    static void Main(string[] args)
    {
        menuPrincipal();
    }

    static void menuPrincipal()
    {
        int opcao;
        do
        {
            Console.WriteLine("\nmenu principal");
            Console.WriteLine("1. cadastrar heroi");
            Console.WriteLine("2. selecionar equipe");
            Console.WriteLine("3. exibir equipe");
            Console.WriteLine("4. sair");
            Console.Write("escolha uma opcao: ");
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cadastro();
                    break;
                case 2:
                    selecao();
                    break;
                case 3:
                    equipe();
                    break;
                case 4:
                    Console.WriteLine("saindo");
                    break;
                default:
                    Console.WriteLine("opcao invalida");
                    break;
            }

        } while (opcao != 4);
    }

    static void cadastro()
    {
        string escolhido = "";

        if (nome1 == "")
        {
            Console.Write("nome do heroi 1: ");
            nome1 = Console.ReadLine();
            Console.Write("poder: ");
            poder1 = Console.ReadLine();
            Console.Write("pontuacao: ");
            pontuacao1 = int.Parse(Console.ReadLine());
        }
        else if (nome2 == "")
        {
            Console.Write("nome do heroi 2: ");
            nome2 = Console.ReadLine();
            Console.Write("poder: ");
            poder2 = Console.ReadLine();
            Console.Write("pontuacao: ");
            pontuacao2 = int.Parse(Console.ReadLine());
        }
        else if (nome3 == "")
        {
            Console.Write("nome do heroi 3: ");
            nome3 = Console.ReadLine();
            Console.Write("poder: ");
            poder3 = Console.ReadLine();
            Console.Write("pontuacao: ");
            pontuacao3 = int.Parse(Console.ReadLine());
        }
        else if (nome4 == "")
        {
            Console.Write("nome do heroi 4: ");
            nome4 = Console.ReadLine();
            Console.Write("poder: ");
            poder4 = Console.ReadLine();
            Console.Write("pontuacao: ");
            pontuacao4 = int.Parse(Console.ReadLine());
        }
        else if (nome5 == "")
        {
            Console.Write("nome do heroi 5: ");
            nome5 = Console.ReadLine();
            Console.Write("poder: ");
            poder5 = Console.ReadLine();
            Console.Write("pontuacao: ");
            pontuacao5 = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("maximo de 5 herois cadastrados.");
        }
    }

    static void selecao()
{
    Console.WriteLine("\nherois cadastrados, forme uma equipe de tres herois");
    if (nome1 != "") Console.WriteLine("1. " + nome1);
    if (nome2 != "") Console.WriteLine("2. " + nome2);
    if (nome3 != "") Console.WriteLine("3. " + nome3);
    if (nome4 != "") Console.WriteLine("4. " + nome4);
    if (nome5 != "") Console.WriteLine("5. " + nome5);

    for (int i = 1; i <= 3; i++)
    {
        int escolha;
        string nomeselecionado = "";

        do
        {
            Console.Write("selecione o heroi com o numero correspondente: ");
            escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1: nomeselecionado = nome1; break;
                case 2: nomeselecionado = nome2; break;
                case 3: nomeselecionado = nome3; break;
                case 4: nomeselecionado = nome4; break;
                case 5: nomeselecionado = nome5; break;
                default: 
                    Console.WriteLine("escolha invalida.");
                    nomeselecionado = "invalido";
                    break;
            }

            if (nomeselecionado == equipeNome1 || nomeselecionado == equipeNome2 || nomeselecionado == equipeNome3)
            {
                Console.WriteLine("heroi ja selecionado, escolha outro.");
                nomeselecionado = "repetido";
            }

        } while (nomeselecionado == "repetido" || nomeselecionado == "invalido");

        switch (i)
        {
            case 1:
                atribuirheroi(escolha, ref equipeNome1, ref equipePoder1, ref equipePont1);
                break;
            case 2:
                atribuirheroi(escolha, ref equipeNome2, ref equipePoder2, ref equipePont2);
                break;
            case 3:
                atribuirheroi(escolha, ref equipeNome3, ref equipePoder3, ref equipePont3);
                break;
        }
    }
}

    static void atribuirheroi(int escolha, ref string nome, ref string poder, ref int pontuacao)
    {
        switch (escolha)
        {
            case 1:
                nome = nome1; poder = poder1; pontuacao = pontuacao1; break;
            case 2:
                nome = nome2; poder = poder2; pontuacao = pontuacao2; break;
            case 3:
                nome = nome3; poder = poder3; pontuacao = pontuacao3; break;
            case 4:
                nome = nome4; poder = poder4; pontuacao = pontuacao4; break;
            case 5:
                nome = nome5; poder = poder5; pontuacao = pontuacao5; break;
            default:
                Console.WriteLine("escolha invalida");
                break;
        }
    }

    static int pontuacao()
    {
        return equipePont1 + equipePont2 + equipePont3;
    }

    static void equipe()
    {
        Console.WriteLine("\n equipe selecionada");
        if (equipeNome1 != "") Console.WriteLine($"1. {equipeNome1} - poder: {equipePoder1} - Pontuacao: {equipePont1}");
        if (equipeNome2 != "") Console.WriteLine($"2. {equipeNome2} - poder: {equipePoder2} - Pontuacao: {equipePont2}");
        if (equipeNome3 != "") Console.WriteLine($"3. {equipeNome3} - poder: {equipePoder3} - Pontuacao: {equipePont3}");

        Console.WriteLine("pontuacao total da equipe: " + pontuacao());
    }
}