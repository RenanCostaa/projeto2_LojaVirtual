using System;
using System.Collections.Generic;

class Loja{

	//atributos
  int codigo;
	string produto;
	double preco;
	int estoque;

	//contrutores
	public Loja() {
		produto = "Novo produto";
		preco = 0.00;
		estoque = 0;
	}
	public Loja(int c, string p, int e, double pr) {
    codigo=c;
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
	public int getCodigo(){
    return codigo;
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
  public void setEstoque(int e){
    estoque = e;
  }
	
  //metodos

}