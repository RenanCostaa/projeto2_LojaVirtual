class Loja{
  //https://www.alura.com.br/artigos/listas-em-csharp
  //http://www.macoratti.net/17/06/c_listas1.htm
  
  //atributos
  string produto;
  double quantidade;
  double preco;

  //getters
  string getProd(){
    return produto;
  }
  double getQuant(){
    return quantidade;
  }
  double getPreco(){
    return preco;
  }

  //setters
  void setProd(string p){
    produto=p;
  }
  void setQuant(double q){
    quantidade=q;
  }
  void setPreco(double p){
    preco=p;
  }

  //construtores
  public Loja(){

  }
  public Loja(string prod, double quant, double preco){
    produto=prod;
    quantidade=quant;
    this.preco=preco;
  }
}