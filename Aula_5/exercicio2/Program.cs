Random numAleatorio = new Random();
int valorInteiro = numAleatorio.Next(1,100);
int num,count = 1;
Console.WriteLine("Tente acertar o numero de 1 a 100");

do {
Console.WriteLine("Digite um palpite");
num = Convert.ToInt32(Console.ReadLine());


if (num >valorInteiro ){
Console.WriteLine("Palpite alto");
count++;

} 
if (num <valorInteiro ){
    Console.WriteLine("Palpite baixo");
count++;
}

}while(num != valorInteiro);
Console.WriteLine($"acertou em {count} tentativas!!");






