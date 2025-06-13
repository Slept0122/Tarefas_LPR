#include <iostream> 

using namespace std;

 struct livro {
 string titulo, autor;
 byte ano;
 int paginas;
 double preco;
 };

 int main (){
  livro a1;

  cout << "digite o dados do livro "<< endl;

  for(int i = 1;i < 4 ;i ++){

cout << "insira o titulo do livro" << i <<": " << endl;
cout << "insira o autor do livro" << i <<": " << endl;
cout << "insira o ano de publicaçao do livro" << i <<": " << endl;

  }

 }