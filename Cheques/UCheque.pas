unit UCheque;

interface

type
  Cheque = class
    public
      function ImprimeValor(Valor: Real): String;
  end;

implementation

const
  VALORES_UNIDADES: array[1..9] of string = ('UM', 'DOIS', 'TRÊS', 'QUATRO',
            'CINCO', 'SEIS', 'SETE', 'OITO', 'NOVE');
  VALORES_DEZENAS: array[1..9] of string = ('DEZ', 'VINTE', 'TRINTA', 'QUARENTA',
            'CINQUENTA', 'SESSENTA', 'SETENTA', 'OITENTA', 'NOVENTA');

{ Cheque }

function Cheque.ImprimeValor(Valor: Real): String;
var
  ValorHelper: Integer;
  Unidades: Integer;
  Dezenas: Integer;
  Centavos: Integer;
  ValorExtenso: string;

begin
  ValorExtenso := '';
  try
    ValorHelper := Trunc(Valor/10);
    Dezenas := ValorHelper;
    Unidades := Trunc((ValorHelper - Dezenas) * 10);
    Centavos := Trunc((Valor - Dezenas - Unidades) * 100);
    if Unidades = 1 then
      ValorExtenso := ValorExtenso + VALORES_UNIDADES[Unidades] + ' REAL';
    if Centavos > 0 then
      ValorExtenso := ValorExtenso + ' E ';
    if Centavos = 10 then
      ValorExtenso := ValorExtenso + 'DEZ CENTAVOS';
  finally
    Result := ValorExtenso;
  end;


end;

end.
