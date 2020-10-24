using System;
/* 

  https://drive.google.com/file/d/1aS4HaJdxtWxOzoRdpRRbO8_mgjZdaopl/view
  
  Entrega 03/11 
  
  -Classe Cliente
  -Classe Loja
  -Classe Carrinho de compras

    1- Cliente se cadastra no serviço;

    2- Cliente navega escolhendo
    produtos e quantidades a serem
    adicionados em seu carrinho;

    3- Cliente fecha o carrinho e vai para o
    pagamento;

    4- Após o pagamento, o cliente recebe
    um relatório contendo produto –
    quantidade – valor total de cada item.

  ---------------------------------------
    RN

    1- O cliente não pode escolher uma quantidade de itens superior à do estoque do produto;

    2- Quando a compra for efetivada, os totais de cada item devem ser
    removidos do estoque da Loja.

    3- O método de pagamento deverá ser implementado, podendo ser
    uma simulação de cartão de crédito ou app de pagamento).

*/

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("------ Loja Virtual ------ \n------ Menu de Opções ------");
    Console.WriteLine("\n 1 - Cadastro de Usuário \n 2 - Realizar compra");
    Console.Write("\nSelecione a opção desejada:");
    int opt=int.Parse(Console.ReadLine());

    if(opt=1){
      //chamar cadastro de usuario
    }else{
      if(opt=2){
        //iniciar compra de prods
      }
    }
  }
}