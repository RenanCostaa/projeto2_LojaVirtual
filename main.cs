using System;
using System.Collections.Generic;

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
		int opt, cod, qtd;
		string nome, cpf, endereco, telefone;

		//iniciando o estoque

		List<string> descricao = new List<string>{"10 COLOUR SPACEBOY PEN","SET/10 BLUE POLKADOT PARTY CANDLES","POTTING SHED SOW \'N\' GROW SET","PAPERWEIGHT KINGS CHOICE ","WOVEN BERRIES CUSHION COVER ","WHITE/PINK MINI CRYSTALS NECKLACE","SET/3 RED GINGHAM ROSE STORAGE BOX","MAGNETS PACK OF 4 VINTAGE LABELS ","WHITE CHRYSANTHEMUMS ART FLOWER","WHITE FRANGIPANI NECKLACE","SILVER FABRIC MIRROR","PINK  HONEYCOMB PAPER FAN","PINK BOUDOIR T-LIGHT HOLDER","BLACK CHERRY LIGHTS","GLASS CAKE COVER AND PLATE","DECORATION SITTING BUNNY","ANTIQUE MID BLUE FLOWER EARRINGS","VINTAGE LEAF CHOPPING BOARD  ","SNACK TRAY I LOVE LONDON","DECROTIVEVINTAGE COFFEE GRINDER BOX","IVORY ENCHANTED FOREST PLACEMAT","ANTIQUE SILVER TEA GLASS ETCHED","BLUE FELT HANGING HEART W FLOWER","PACK OF 12 COLOURED PENCILS","CLAM SHELL SMALL ","TWO DOOR CURIO CABINET","GREEN GOOSE FEATHER CHRISTMAS TREE ","MULTICOLOUR HONEYCOMB FAN","GREEN DROP EARRINGS W BEAD CLUSTER","BOTANICAL LILY GREETING CARD","SILVER DROP EARRINGS WITH FLOWER","CANDY SPOT BUNNY","WHITE WITH BLACK CATS PLATE","VEGETABLE MAGNETIC  SHOPPING LIST","FLOWER PURPLE CLOCK WITH SUCKER","VINTAGE CHRISTMAS GIFT SACK","found box","SET 10 CARDS SNOWY SNOWDROPS  17100","JUMBO SHOPPER VINTAGE RED PAISLEY","SET OF 4 ENGLISH ROSE PLACEMATS","FELTCRAFT HAIRBAND RED AND BLUE","BLUE GIANT GARDEN THERMOMETER","VINTAGE PAISLEY STATIONERY SET","SET OF 4 NAPKIN CHARMS CUTLERY","CARAVAN SQUARE TISSUE BOX","FRENCH PAISLEY CUSHION COVER ","GOLD FISHING GNOME","PINK BABY BUNTING","DROP DIAMANTE EARRINGS CRYSTAL","RED FLOCK LOVE HEART PHOTO FRAME"};
    
    List<double> preco = new List<double>{10.65,9.13,0.66,175.69,15.5,206.4,194.7,3.26,2019.05,109.19,404.49,157.08,183.2,124.87,888.42,736.38,0.84,0.07,2.4,24.96,9.72,160.0,18.62,14.75,2.82,10.2,29.74,19.96,80.46,183.09,152.19,49.13,8.0,138.46,135.08,2.41,10.82,425.14,2028.25,5.13,20.38,5.76,199.33,192.44,2.62,201.84,170.92,0.0,0.87,537.83};

		List<int> estoque = new List<int>{123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123,123};

		List<Loja> produtos = new List<Loja>();
		for (int i=0; i<descricao.Count; i++) {
			produtos.Add(new Loja(descricao[i], estoque[i], preco[i]));
		}
		
    Console.WriteLine("\n\nOlá! Para começarmos, faça seu cadastro:\n\n");

    //chamar cadastro de usuario
    Console.Write("Digite o seu nome >> ");
    nome = Console.ReadLine();
    Console.Write("Digite o seu CPF >> ");
    cpf = Console.ReadLine();
    Console.Write("Digite o seu Endereço >> ");
    endereco = Console.ReadLine();
    Console.Write("Digite o seu Telefone >> ");
    telefone = Console.ReadLine();
    Cliente novoCliente = new Cliente(nome, cpf, endereco, telefone);

    Carrinho_Compras novoCarrinho = new Carrinho_Compras(novoCliente.getNome());

    Console.WriteLine("\n\nSeja bem-vindo(a) à nossa loja, {0}.\nConfira os nossos produtos:\n\n", novoCliente.getNome());
    
    //vitrine de produtos
    string continuar = "s";
    while (continuar == "s") {
      Console.WriteLine("*********************PRODUTOS***********************\n**Cód...Nome.................................Preço**");
			
      for (int i=0; i<produtos.Count; i++){
        Console.WriteLine("**{0} - {1} - R${2} **", i+1, produtos[i].getProduto(),produtos[i].getEstoque(),produtos[i].getPreco());
      }

      Console.Write("\n\nEscolha um produto através do código >> ");
      cod= int.Parse(Console.ReadLine())-1;
      Console.Write("Digite a quantidade desejada >> ");
      qtd= int.Parse(Console.ReadLine());


      Carrinho_Compras.addCarrinho(cod,qtd,produtos[cod].getEstoque());

      Console.Write("\n\nDeseja escolher mais produtos? 's' para escolher, 'n' para finalizar o pedido >> ");
      continuar = Console.ReadLine();
    }

  }
}