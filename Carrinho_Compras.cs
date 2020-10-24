class Carrinho_Compras{
  //atributos
  string dono;
  string itens;
  int quant_carrinho;

  //getters
  public string getDono(){
    return dono;
  }
  public string getItens(){
    return itens;
  }
  public int getQuant(){
    return quant_carrinho;
  }

  //setters
  void setDono(string d){
    dono=d;
  }
  void setItens(string i){
    itens=i;
  }
  void setQuant(int q){
    quant_carrinho=q;
  }

  //contrutores
  public Carrinho_Compras(string d, string i, int q){
    dono=d;
    itens=i;
    quant_carrinho=q;
  }

  //metodos
}