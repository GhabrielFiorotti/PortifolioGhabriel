class Bola{

	// ATRIBUTOS
	private string cor;
	private string material;

	//CONSTRUTORES
	public Bola(){
		cor = "branca";
		material = "Plástico";


	}
	public Bola(string c, string m){
		cor = c;
		material = m;

	}

	public string getCor(){
		return cor;
	}
	public void setCor(string c){
		cor = c;
	}
	public string getMaterial(){
		return material;
	}
	public void setMaterial(string m){
		material = m;
	}
}