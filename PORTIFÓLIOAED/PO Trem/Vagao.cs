class Vagao{
  private int qtdCarregada;
  private string material;

  public Vagao (int qtd, string mat){
    qtdcarregada = qtd;
    material = mat;
  }

  public Vagao(){
    qtdcarregada = 30;
    material = "Madeira";
  }

  public int getQtdCarregada(){
    return qtdCarregada;
  }
  public void setQtdCarregada(int qtd){
    qtdCarregada = qtd ;
  }

  public int getMaterial(){
    return material;
  }
  public void setMaterial(string mate){
    material = mate;
  }

}

