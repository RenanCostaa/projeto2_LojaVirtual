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
	/*PASSADO PARA A CLASSE LOJA
  public string getItens(){
    return itens;
  }
  public int getQuant(){
    return quant_carrinho;
  }*/

  //setters
  void setDono(string d){
    dono=d;
  }
	/*PASSADO PARA A CLASSE LOJA
  void setItens(string i){
    itens=i;
  }
  void setQuant(int q){
    quant_carrinho=q;
  }*/

  //contrutores
  //public Carrinho_Compras(string d, string i, int q){
	public Carrinho_Compras(string d) {
    dono=d;
    /*PASSADO PARA A CLASSE LOJA
		itens=i;
    quant_carrinho=q;
		*/
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