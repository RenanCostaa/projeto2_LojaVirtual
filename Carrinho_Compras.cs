using System;
using System.Collections.Generic;

class Carrinho_Compras{
  //atributos
  string dono;
	/*List<int> produtos;
	List<int> qtd;*/
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

  //metodos
  /*public void addCarrinho(int cod, int quantd){
    produtos.Add(cod);
    qtd.Add(quantd);
    Console.WriteLine("feito");
  }*/



}