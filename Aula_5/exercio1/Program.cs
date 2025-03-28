using System;

int num, i = 0, quant, soma = 0;
double media, pares = 0;

Console.WriteLine("insira a quantidade de termos que deseja fazer a media: ");
quant = Convert.ToInt32(Console.ReadLine());

while (i < quant)
{
    i++;
    Console.WriteLine("quais os numeros: ");
    num = Convert.ToInt32(Console.ReadLine());

    if (num % 2 == 0)
    {
        soma += num;
        pares++;
    }
}
if (pares > 0)
    {
        media = soma / pares;
        Console.WriteLine($"a media sera: {media} ");

    }

    else Console.WriteLine("voce digitou so numeros impares ");
