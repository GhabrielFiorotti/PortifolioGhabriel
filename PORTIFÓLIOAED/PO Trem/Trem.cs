class Trem{

	//Atributos da classe
	private int velocidade;
	private int qtdTrem;
  private Vagao vagao1;
  private Vagao vagao2;
  private Vagao vagao3;

	//Construtor da classe
	public Trem(string i, string n, Vagao vg1  , Vagao vg2, Vagao vg3){
		velocidade = i;
		qtdTrem = n;
    vagao1 = vg1;
    vagao2 = vg2;
    vagao3 = vg3;
	}

  public Trem(){
    velocidade = 100;
    qtdTrem = 120;
    vagao1 = new Vagao();
    vagao2 = new Vagao();
    vagao3 = new Vagao();
  }

	//Métodos de acesso
	public int getVelocidade(){
		return velocidade;
	}
	public void setVelocidade(int i){
		velocidade = i;
	}
	public int getQtdTrem(){
		return qtdTrem;
	}
	public void setQtdTrem(int n){
		qtdTrem = n;
  }
  public Vagao getVagao1(){
    return vagao1;
  }
  public void setVagao1(Vagao v1){
    vagao1 = v1;
  }
  public Vagao getVagao2(){
    return vagao2;
  }
  public void setVagao2(Vagao v2){
    vagao1 = v2;
  }  
  public Vagao getVagao3(){
    return vagao3;
  }
  public void setVagao3(Vagao v3){
    vagao1 = v3;
  }

  //Método carga restante  

  public int cargaRestante (){
    return (qtdTrem - (vagao1.getQtdCarregada() + vagao2.getQtdCarregada() + vagao3.getQtdCarregada()))

  }

  //Método Transferir Carga
  public bool transferirCargaPara()


}


