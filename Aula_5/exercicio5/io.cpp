#include <iostream>
#include <iomanip>

using namespace std;

double horas, horasem, horasmes;
int dias_necessarios;

int main()
{
   
    {
        cout << "Horas de treinamento de um Jedi por dia (deve ser maior que 0): ";
        cin >> horas;

        if (horas <= 0)
        {
            cout << "Por favor, insira um número de horas maior que 0.\n";
        }

    } while (horas <= 0);  
    
    horasem = horas * 5;
    
    double semanas_necessarias = 1000 / horasem;
    
    dias_necessarios = semanas_necessarias * 5;
    
    horasmes = semanas_necessarias / 4.5;
    
    cout << "Para " << horas << " horas de treino por dia, você precisaria de:\n";
    cout << "Meses: " << fixed << setprecision(2) << horasmes << " meses.\n";
    cout << "Semanas: " << fixed << setprecision(2) << semanas_necessarias << " semanas.\n";
    cout << "Dias úteis: " << dias_necessarios << " dias.\n"<<endl;
return 0;
}