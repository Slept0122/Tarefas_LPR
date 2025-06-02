#include <iostream>
#include <vector>

using namespace std;

vector<int> num(10);
vector<int> escolhido(10);

int main()
{
    cout << "digite 10 valores inteiros para fazer separacao impar ou par" << endl;

    cin >> escolhido[0] >> escolhido[1] >> escolhido[2] >> escolhido[3] >> escolhido[4] >> escolhido[5] >> escolhido[6] >> escolhido[7] >> escolhido[8] >> escolhido[9];

    for (int i = 0; i < 10; i++)
    {

        if (escolhido[i] % 2 == 0)
        {
            cout << "estes numeros sao pares: " << escolhido[i] << endl;
        }
        else
            cout << "estes numeros sao impares: " << escolhido[i] << endl;
    }
}