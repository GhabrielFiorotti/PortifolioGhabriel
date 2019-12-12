class Caneta{

	// ATRIBUTOS
	private string cor;
	private string marca;
	private float qtd_tinta;
  private float max_tinta;

	//CONSTRUTORES
	public Caneta(){
		cor = "azul";
		marca = "bic";
		qtd_tinta = 100f;
    max_tinta = 100f;

	}
	public Caneta(string c, string m, float qt){
		cor = c;
		marca = m;
		qtd_tinta = qt;
    max_tinta = 100f;
    
	}

	//METODOS DE ACESSO
	//get(acessar) e set(alterar)
	public string getCor(){
		return cor;
	}
	public void setCor(string c){
		cor = c;
	}
	public string getMarca(){
		return marca;
	}
	public void setMarca(string m){
		marca = m;
	}
	public float getQtd(){
		return qtd_tinta;
	}
	public void setQtd(float qt){
		qtd_tinta = qt;
	}

	//DEMAIS METODOS
	public string resumoDados(){
		return string.Format("Cor - {0} Marca - {1} Qtd - {2}", cor, marca, qtd_tinta);
	}

  public bool transferirCarga (Caneta destino, float qtd){
    //verificar se cabe no destino a quantidade
    if ((destino.max_tinta - destino.qtd_tinta) >= qtd){
      //verificar se há tinta SUFICIENTE na origem
      if (this.qtd_tinta >= qtd){
        //verificar se a cor é a mesma
        if (this.cor == destino.cor){
          //transferir:subtrair qtd da origem e adicionar no destino          
          destino.qtd_tinta += qtd;
          this.qtd_tinta -= qtd;
          return true;
        }
      }
    }
    return false;
  }
}
