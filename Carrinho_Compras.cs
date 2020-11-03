using System;
using System.Collections.Generic;

class Carrinho_Compras{
  //atributos
  string dono;
	public List<Loja> prodsCarrinho;

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
    prodsCarrinho = new List<Loja>();
  }
}