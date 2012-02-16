unit ClsCestaCompras;

interface

uses
  contnrs, SysUtils;

type
  TLivros = class
  private
    FCodigo: Integer;
    FQuantidade: Extended;
  published
  public
    property Codigo: Integer read FCodigo write FCodigo;
    property Quantidade: Extended read FQuantidade write FQuantidade;
    constructor Create(Codigo: Integer; Quantidade: Extended);



  end;

  TCestaCompras = class(TObjectList)
  public
    constructor Create;
    destructor Destroy; override;
    procedure AdicionarLivros(Livro: TLivros);
    function GetValorCompra: Extended;
  end;

implementation

constructor TCestaCompras.Create;
begin
   inherited Create;
end;

destructor TCestaCompras.Destroy;
begin
  inherited Destroy;
end;

{ TLivros }

procedure TCestaCompras.AdicionarLivros(Livro: TLivros);
var
  I: Integer;
  LivroHelper: TLivros;
begin
  for I := 0 to Self.Count - 1 do begin
    LivroHelper := TLivros(Self.Items[i]);
    if LivroHelper.Codigo = Livro.Codigo then begin
      LivroHelper.Quantidade := LivroHelper.Quantidade + Livro.Quantidade;
      Break;
    end;
  end;
  Self.Add(Livro);
end;

constructor TLivros.Create(Codigo: Integer; Quantidade: Extended);
begin
  Self.Codigo := Codigo;
  Self.Quantidade := Quantidade;
end;

function TCestaCompras.GetValorCompra: Extended;
var
  i: integer;
  QtdeLivrosDiversos: Integer;
begin
  QtdeLivrosDiversos := Self.Count;
  case QtdeLivrosDiversos of
    1: Result := 8 *
    2:
    3:
  end;
  if (Self.Count = 1) and (TLivros(Self.Items[0]).Quantidade = 1) then
    result := 8
  else if (Self.Count = 2) and
           (TLivros(Self.Items[0]).Codigo <> TLivros(Self.Items[1]).Codigo) then begin
    Result := 16 * 0.95;
  end
  else begin
    result := 24 * 0.90;
  end;


//    for I := 0 to Self.count - 1 do begin
//      if TLivros(Self.Items[i]).Codigo = 1 then begin
//        QtdeLivro1 := QtdeLivro1 + TLivros(Self.Items[i]).Quantidade;
//      end;
//    end;
//  if QtdeLivro1 = 1 then result := 8;
end;

end.
