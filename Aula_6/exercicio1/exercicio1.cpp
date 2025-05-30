#include <iostream>
#include <cstring>

using namespace std;

int main()
{
    char num[5];
    cout << "Insira um numero de 4 algarismos: ";
    cin >> num;

    if (num[4] != '\0') {
        cout << "Por favor, insira um numero com exatamente 4 algarismos." << endl;
        return 1;
    }
    char numInvertido[5];
    for (int i = 0; i < 4; i++) {
        numInvertido[i] = num[3 - i];
    }
    numInvertido[4] = '\0';
    cout << "O numero invertido fica: " << numInvertido << endl;
    return 0;
}
