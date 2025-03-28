string escolha;

Console.WriteLine("Escolha a classe em que deseja jogar: ");
Console.WriteLine("Guerreiro "); 
Console.WriteLine("Mago ");
Console.WriteLine("Arqueiro ");

escolha = Console.ReadLine();

switch (escolha){

case "Guerreiro":
Console.WriteLine("Você escolheu Guerreiro!");
Console.WriteLine("Habilidades: Ataque Pesado, Defesa Total");
break;  

case "Mago":
Console.WriteLine("Você escolheu Mago!");
Console.WriteLine("Bola de Fogo, Escudo de Gelo");
break;

case "Arqueiro":
Console.WriteLine("Você escolheu Arqueiro!");
Console.WriteLine("Flecha Precisa, Disparo Triplo");
break;
               
}