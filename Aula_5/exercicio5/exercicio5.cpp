#include <iostream>
#include <iomanip>

using namespace std;
double horas, horasem, horasmes, semneces, diasneces;
int main()
{
    do
    {
        cout << "horas de treinamento de um jedi por dia: ";
        cin >> horas;
    }while (horas <= 0);  

    horasem = horas * 5;
    semneces = 1000 / horasem;
    horasmes = semneces / 4.5;

    cout << "para " << horas << " horas de treino por dia daria " << horasmes << " meses," << horasem << " semanas e" << horas << " dias";
}