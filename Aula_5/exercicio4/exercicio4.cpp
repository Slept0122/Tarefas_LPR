#include <iostream>
#include <iomanip>

using namespace std;

int num, qua, sum = 0;

int main()
{
    cout << "insira um numero: ";
    cin >> num;
    qua = num * num;

    while (qua > 0)
    {
        sum += qua % 10;
        qua /= 10;
    }

    cout << "o avalor final: " <<sum;
    //me ajudaram a fazer este
}