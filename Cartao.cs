class Cartao {

	private Cliente donoCartao;
	private string numero;
	private string validade;
	private double limite;

	public Cartao() {
		numero = "0000.0000.0000.0000";
		validade = "00/0000";
		limite = 0.00;
	}

	public Cartao(Cliente c, string n, string v, double l) {
		donoCartao = c;
		numero = n;
		validade = v;
		limite = l;
	}

	public double getLimite() {
		return limite;
	}

}