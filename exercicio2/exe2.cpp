#include <iostream>
#include <iomanip>

using namespace std;

int main(){
    int numa,numb;

    cout <<"insira dois numeros:" <<numa << "e" <<numb;
    cin >> numa >> numb;

    if(numa % numb == 0 || numb % numa == 0){
        cout << numa <<"e" << numb << "sao multiplos";

    }else (cout << numa <<"e" << numb << "nao sao multiplos");
}