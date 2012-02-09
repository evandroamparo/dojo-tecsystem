package br.com.dojo.jokenpo;

import junit.framework.TestCase;

import org.junit.Test;

public class JokenpoTest extends TestCase
{	
	public void setUp()
	{}
	
	public void tearDown()
	{}
	
	@Test
	public void testPedraEmpataPedra()
	{
		Jokenpo jkpo = new Jokenpo();
		assertEquals(Jokenpo.EMPATE, jkpo.getVerificaJogada(Jokenpo.PEDRA, Jokenpo.PEDRA));
	}
	
	@Test
	public void testPedraGanhaTesoura()
	{
		Jokenpo jkpo = new Jokenpo();
		assertEquals(Jokenpo.PEDRA, jkpo.getVerificaJogada(Jokenpo.PEDRA, Jokenpo.TESOURA));
	}
	
	@Test
	public void testTesouraEmpataTesoura()
	{
		Jokenpo jkpo = new Jokenpo();
		assertEquals(Jokenpo.EMPATE, jkpo.getVerificaJogada(Jokenpo.TESOURA, Jokenpo.TESOURA));
	}
	
	@Test
	public void testTesouraGanhaPapel()
	{
		Jokenpo jkpo = new Jokenpo();
		assertEquals(Jokenpo.TESOURA, jkpo.getVerificaJogada(Jokenpo.TESOURA, Jokenpo.PAPEL));
	}
	
	@Test
	public void testPapelEmpataPapel()
	{
		Jokenpo jkpo = new Jokenpo();
		assertEquals(Jokenpo.EMPATE, jkpo.getVerificaJogada(Jokenpo.PAPEL, Jokenpo.PAPEL));
	}
	@Test
	public void testPapelGanhaPedra()
	{
		Jokenpo jkpo = new Jokenpo();
		assertEquals(Jokenpo.PAPEL, jkpo.getVerificaJogada(Jokenpo.PAPEL, Jokenpo.PEDRA));
	}
}