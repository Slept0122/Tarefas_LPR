#include <iostream>
#include <cmath>

using namespace std;

int main()
{
    double horasPorDia;

    do
    {
        cout << "insira o valor de horas treinadas por dia: ";
        cin >> horasPorDia;

    } while (horasPorDia <= 0);

    const int diasPorSemana = 5;
    double horasPorSemana = horasPorDia * diasPorSemana;
    const int totalHoras = 1000;

    double semanasNecessarias = totalHoras / horasPorSemana;
    double diasNecessarios = semanasNecessarias * diasPorSemana;
    double mesesNecessarios = semanasNecessarias / 4.5;

    cout << "Para alcançar 1000 horas de treinamento\n";
    cout << "seria " << round(mesesNecessarios) << " meses de treino.\n";
    cout << "aproximadamente " << round(semanasNecessarias) << " semanas.\n";
    cout << "isso vale " << round(diasNecessarios) << " dias de treinamento.\n";
}
