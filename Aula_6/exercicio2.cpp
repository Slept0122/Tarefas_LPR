#include <iostream>
#include <locale>
#include <random>
using namespace std;
void exe1()
{
    int num;
    double media;
    int i = 0, quant, soma = 0;
    double pares = 0;

    cout << "insira a quantidade de termos que deseja fazer a media: ";
    cin >> quant;

    while (i < quant)
    {
        i++;
        cout << "quais os numeros: ";
        cin >> num;

        if (num % 2 == 0)
        {
            soma += num;
            pares++;
        }
    }
    if (pares > 0)
    {
        media = soma / pares;
        cout << "a media sera:  " << media;
    }

    else
        cout << "voce digitou so numeros impares ";
}
void exe2()
{

    random_device numAleatorio;
    uniform_int_distribution<> distribuicao(1, 100);
    int valorInteiro = distribuicao(numAleatorio);
    int num, count = 1;
    cout << "Tente acertar o numero de 1 a 100" << endl;

    do
    {
        cout << "Digite um palpite" << endl;
        cin >> num;

        if (num > valorInteiro)
        {
            cout << "Palpite alto" << endl;
            count++;
        }
        if (num < valorInteiro)
        {
            cout << "Palpite baixo" << endl;
            count++;
        }

    } while (num != valorInteiro);
    cout << "acertou em " << count << " tentativas!!";
}
void exe3()
{

    int num, qua, sum = 0;

    cout << "insira um numero: " << endl;
    cin >> num;
    qua = num * num;

    while (qua > 0)
    {
        sum += qua % 10;
        qua /= 10;
    }

    cout << "o valor final da soma dos seus dígitos e: " << sum;
}

int main()
{

    int cond;
    string exercicio;

    cout << "deseja acessar qual exercicio? coloque o numero que esta sua frente" << endl;
    cout << "exercicio 1" << endl;
    cout << "exercicio 2" << endl;
    cout << "exercicio 3" << endl;
    cin >> cond;

    switch (cond)
    {
    case 1:
        exercicio = "1";
        exe1();
        break;

    case 2:
        exercicio = "2";
        exe2();
        break;

    case 3:
        exercicio = "3";
        exe3();
        break;
    }
}