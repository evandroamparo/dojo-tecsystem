{
To try and encourage more sales of the 5 different Harry
Potter books they sell, a bookshop has decided to offer 
discounts of multiple-book purchases. 

One copy of any of the five books costs 8 EUR.

If, however, you buy two different books, you get a 5%
discount on those two books.

If you buy 3 different books, you get a 10% discount.

If you buy 4 different books, you get a 20% discount.

If you go the whole hog, and buy all 5, you get a huge 25%
discount.

Note that if you buy, say, four books, of which 3 are 
different titles, you get a 10% discount on the 3 that 
form part of a set, but the fourth book still costs 8 EUR. 

Your mission is to write a piece of code to calculate the 
price of any conceivable shopping basket (containing only 
Harry Potter books), giving as big a discount as possible.

For example, how much does this basket of books cost?

2 copies of the first book
2 copies of the second book
2 copies of the third book
1 copy of the fourth book
1 copy of the fifth book

Answer: 51.20 EUR




Para tentar estimular mais vendas dos 5 diferentes livros de Harry Potter
que vende, uma livraria decidiu oferecer descontos de m�ltiplas compras de livros.

Uma c�pia de qualquer um dos cinco livros custa 8 euros.

Se, no entanto, voc� compra dois livros diferentes, voc� tem de desconto de 5%
sobre esses dois livros.

Se voc� comprar 3 livros diferentes, voc� recebe um desconto de 10%.

Se voc� comprar 4 livros diferentes, voc� recebe um desconto de 20%.

Se voc� comprar os 5 livors diferentes, voc� tem um desconto 25%.

Note que se voc� comprar, digamos, quatro livros, dos quais 3
t�tulos diferentes, voc� recebe um desconto de 10% sobre os 3, que
fazem parte de um conjunto, mas o quarto livro ainda custa 8 euros.

Sua miss�o � escrever um peda�o de c�digo para calcular o
pre�o de qualquer cesta de compras conceb�vel (contendo apenas
livros do Harry Potter), dando um desconto t�o grande quanto poss�vel.

Por exemplo, quanto custa esta cesta?

2 c�pias do primeiro livro
2 c�pias do segundo livro
2 c�pias do terceiro livro
1 c�pia do quarto livro
1 c�pia do quinto livro

Resposta: 51,20 EUR
}

unit ClsCestaComprasTest;

interface

uses
   TestFramework,
   ClsCestaCompras;

type
   TCestaComprasTest = class(TTestCase)
   strict private
      //
   private
      CestaCompras: TCestaCompras;
      //
   public
      procedure SetUp; override;
      procedure TearDown; override;
   published
      procedure DeveRetornar8EurosPara1Livro;
      procedure DeveRetornarCincoPorcentoDescontoPara2LivrosDiferentes;
      procedure DeveRetornarDezPorcentoDescontoPara3LivrosDiferentes;
  end;

implementation

procedure TCestaComprasTest.DeveRetornarCincoPorcentoDescontoPara2LivrosDiferentes;
var
  ValorCompra: Extended;
begin
  CestaCompras := TCestaCompras.Create();
  CestaCompras.AdicionarLivros(TLivros.Create(1, 1));
  CestaCompras.AdicionarLivros(TLivros.Create(2, 1));
  ValorCompra := CestaCompras.GetValorCompra();
  CheckEquals(16 * 0.95, ValorCompra);
end;

procedure TCestaComprasTest.DeveRetornarDezPorcentoDescontoPara3LivrosDiferentes;
var
  ValorCompra: Extended;
begin
 CestaCompras := TCestaCompras.Create();
  CestaCompras.AdicionarLivros(TLivros.Create(1, 1));
  CestaCompras.AdicionarLivros(TLivros.Create(2, 1));
  CestaCompras.AdicionarLivros(TLivros.Create(3, 1));
  ValorCompra := CestaCompras.GetValorCompra();
  CheckEquals(24 * 0.90, ValorCompra);
end;

procedure TCestaComprasTest.SetUp;
begin
  Self.CestaCompras := TCestaCompras.Create();
end;

procedure TCestaComprasTest.TearDown;
begin
 Self.CestaCompras.Free();
end;

procedure TCestaComprasTest.DeveRetornar8EurosPara1Livro();
var
  ValorCompra: Extended;
begin
  CestaCompras := TCestaCompras.Create();
  CestaCompras.AdicionarLivros(TLivros.Create(1, 1));
  ValorCompra := CestaCompras.GetValorCompra();
  Assert(ValorCompra =  8);
end;



initialization
  RegisterTest(TCestaComprasTest.Suite);

end.

