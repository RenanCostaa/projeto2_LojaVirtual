using System;
using System.Collections.Generic;

class Carrinho_Compras{
  //atributos
  string dono;
	List<int> produtos;
	List<int> qtd;

  //getters
  public string getDono(){
    return dono;
  }

  //setters
  void setDono(string d){
    dono=d;
  }

  //contrutores
	public Carrinho_Compras(string d) {
    dono=d;
  }

  //metodos
  public static bool addCarrinho(int cod, int qtd, int estoq){
    if (qtd<=estoq) {
      //Console.WriteLine("aprovado");
      return true;
		}
    else{
      //Console.WriteLine("negado");
      return false;
    }
  }


}