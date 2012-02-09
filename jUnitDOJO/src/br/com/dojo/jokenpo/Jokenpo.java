package br.com.dojo.jokenpo;

public class Jokenpo 
{
    public static final int PEDRA = 1;
    
	public static final int PAPEL = 5;
	
	public static final int PEDRA_PAPEL = PEDRA + PAPEL;
	
	public static final int TESOURA = 7;
	
	public static final int PEDRA_TESOURA = PEDRA + TESOURA;
	
	public static final int EMPATE = 100;
	
	public static final int TESOURA_PAPEL = TESOURA + PAPEL; 
	

	public int getVerificaJogada(int jogador1, int jogador2) 
	{
		switch (jogador1 + jogador2)
		{
			case PEDRA * 2:
			case PAPEL * 2:
			case TESOURA * 2:
				return EMPATE;
				
			case PEDRA_PAPEL:
				return PAPEL;
			case PEDRA_TESOURA:
				return PEDRA;
			case TESOURA_PAPEL:
				return TESOURA;
				
			default:
				return -1;
		}
		 
	}
}