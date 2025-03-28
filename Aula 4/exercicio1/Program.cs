using System;

int num;

Console.WriteLine("digite um numero :");
num = Convert.ToInt32(Console.ReadLine());

if(num %2 == 0 ){
Console.WriteLine($"o {num} e par");

}else Console.WriteLine($"o {num} e impar");


