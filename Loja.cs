using System;
using System.Collections.Generic;

class Loja{
  //https://www.alura.com.br/artigos/listas-em-csharp
  //http://www.macoratti.net/17/06/c_listas1.htm

	string produto;
	double preco;
	int estoque;

	public Loja() {
		produto = "Novo produto";
		preco = 0.00;
		estoque = 0;
	}
	public Loja(string p, int e, double pr) {
		produto = p;
		estoque = e;
    preco = pr;
	}

	//getters
  public string getProduto(){
    return produto;
  }
  public int getEstoque(){
    return estoque;
  }
  public double getPreco(){
    return preco;
  }

  //setters
  void setProd(string p){
    produto = p;
  }
  void setQuant(int q){
    estoque = q;
  }
  void setPreco(double p){
    preco = p;
  }
  
  //metodos

}