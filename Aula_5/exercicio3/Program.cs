﻿int resultado = 0;

for(int i = 50; i<500 ;i++){

    if(i %2 != 0 && i %3 == 0){
    resultado += i;
    }

}Console.WriteLine($"a soma de todos os numeros imapres multiplos de 3 e: {resultado}");
