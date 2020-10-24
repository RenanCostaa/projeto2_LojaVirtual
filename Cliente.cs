class Cliente{
  
  string nome;
  string cpf;
  string endereco;
  string telefone;

  public string getNome(){
    return nome;
  }
  public string getCpf(){
    return cpf;
  }
  public string getEndr(){
    return endereco;
  }
  public string gerTel(){
    return telefone;
  }

  // não tenho certeza se precisamos de SET p/ nome e/ou cpf
  /*
  void setNome(string n){
    nome=n;
  }
  void setCpf(string c){
    cpf=c;
  }
  */
  void setEndr(string e){
    endereco=e;
  }
  void setTel(string t){
    telefone=t;
  }

  public Cliente(string n){
    nome=n;
  }
  public Cliente(string n, string c){
    nome=n;
    cpf=c;
  }
  public Cliente(string n, string c, string e){
    nome=n;
    cpf=c;
    endereco=e;
  }
  public Cliente(string n, string c, string e, string t){
    nome=n;
    cpf=c;
    endereco=e;
    telefone=t;
  }

}